using System;

namespace Przychodnia
{
    public class Patient
    {
        //ID
        public string Id { get; set; } = Guid.NewGuid().ToString();

        // Dane osobowe
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pesel { get; set; }
        public DateTime Date { get; set; }
        public bool Sex { get; set; }

        // Dane kontaktowe
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string HouseNumber { get; set; }
    }
}