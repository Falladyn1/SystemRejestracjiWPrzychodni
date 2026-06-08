using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;

namespace Przychodnia
{
    internal class Database
    {
        public static BindingList<Patient> patientList = new BindingList<Patient>();
        private readonly static string filePath = "zapis.txt";

        public static void Save()
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (Patient p in patientList)
                {
                    Type t = p.GetType();
                    writer.WriteLine("[" + t.Name + "]");

                    PropertyInfo[] properties = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);

                    foreach (PropertyInfo prop in properties)
                    {
                        string key = prop.Name;
                        object val = prop.GetValue(p);

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

            if (!File.Exists(filePath))
                return;

            using (StreamReader reader = new StreamReader(filePath))
            {
                Patient currentObject = null;
                Type currentType = typeof(Patient); 
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim();

                    if (string.IsNullOrEmpty(line))
                    {
                        if (currentObject != null)
                        {
                            patientList.Add(currentObject);
                            currentObject = null;
                        }
                        continue;
                    }

                    if (line.StartsWith("[") && line.EndsWith("]"))
                    {
                        currentObject = new Patient();
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
                    patientList.Add(currentObject);
                }
            }
        }
    }
}