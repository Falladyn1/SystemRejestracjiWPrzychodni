using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace Przychodnia
{
    internal class Database
    {
        public static BindingList<Patient> patientList = new BindingList<Patient>();
        public static BindingList<Appointment> appointmentList = new BindingList<Appointment>();

        private readonly static string patientsFilePath = "pacjenci.txt";
        private readonly static string appointmentsFilePath = "wizyty.txt";

        public static BindingList<Patient> FilterPatients(Func<Patient, bool> checkCondition)
        {
            var filteredList = new BindingList<Patient>();
            foreach (Patient p in patientList)
            {
                if (checkCondition(p))
                {
                    filteredList.Add(p);
                }
            }
            return filteredList;
        }

        public static void Save()
        {
            SaveList(patientList, patientsFilePath);
            SaveList(appointmentList, appointmentsFilePath);
        }

        private static void SaveList<T>(IEnumerable<T> list, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (T item in list)
                {
                    Type t = item.GetType();
                    writer.WriteLine("[" + t.Name + "]");

                    PropertyInfo[] properties = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);

                    foreach (PropertyInfo prop in properties)
                    {
                        string key = prop.Name;
                        object val = prop.GetValue(item);

                        if (val != null)
                        {
                            if (val is DateTime dt)
                                writer.WriteLine(key + ": " + dt.ToString("o"));
                            else
                                writer.WriteLine(key + ": " + val.ToString());
                        }
                        else
                        {
                            writer.WriteLine(key + ": null");
                        }
                    }
                    writer.WriteLine();
                }
            }
        }

        public static void Load()
        {
            patientList.Clear();
            appointmentList.Clear();

            LoadList(patientList, patientsFilePath);
            LoadList(appointmentList, appointmentsFilePath);
        }

        private static void LoadList<T>(BindingList<T> targetList, string filePath) where T : new()
        {
            if (!File.Exists(filePath))
                return;

            using (StreamReader reader = new StreamReader(filePath))
            {
                T currentObject = default(T);
                Type currentType = typeof(T);
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim();

                    if (string.IsNullOrEmpty(line))
                    {
                        if (currentObject != null)
                        {
                            targetList.Add(currentObject);
                            currentObject = default(T);
                        }
                        continue;
                    }

                    if (line.StartsWith("[") && line.EndsWith("]"))
                    {
                        currentObject = new T();
                    }
                    else if (currentObject != null && line.Contains(": "))
                    {
                        string[] lineParts = line.Split(new[] { ": " }, 2, StringSplitOptions.None);

                        if (lineParts.Length == 2)
                        {
                            string propName = lineParts[0];
                            string propValue = lineParts[1];

                            if (propValue == "null")
                                continue;

                            PropertyInfo property = currentType.GetProperty(propName, BindingFlags.Public | BindingFlags.Instance);

                            if (property != null && property.CanWrite)
                            {
                                try
                                {
                                    if (property.PropertyType == typeof(DateTime))
                                    {
                                        property.SetValue(currentObject, DateTime.Parse(propValue));
                                    }
                                    else if (property.PropertyType == typeof(bool))
                                    {
                                        property.SetValue(currentObject, bool.Parse(propValue));
                                    }
                                    else
                                    {
                                        property.SetValue(currentObject, Convert.ChangeType(propValue, property.PropertyType));
                                    }
                                }
                                catch { }
                            }
                        }
                    }
                }

                if (currentObject != null)
                {
                    targetList.Add(currentObject);
                }
            }
        }
    }
}