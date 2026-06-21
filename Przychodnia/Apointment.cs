using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    internal class Appointment
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string PatientId { get; set; }

        public DateTime DateVisit { get; set; }
        public string HourVisit { get; set; }
        public string DoctorName { get; set; }

        public string FullVisitInfo
        {
            get
            {
                return DateVisit.ToString("dd.MM.yyyy") + " - " + HourVisit;
            }
        }
    }
}
