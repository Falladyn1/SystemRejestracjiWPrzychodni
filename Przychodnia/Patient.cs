using System;

namespace Przychodnia
{
    public class Patient
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pesel { get; set; }
        public DateTime Date { get; set; }
        public bool Sex { get; set; } // true - mężczyzna, false - kobieta

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string HouseNumber { get; set; }

        public DateTime DateVisit { get; set; }
        public string HourVisit { get; set; }
        public string Doctor { get; set; }
    }
}