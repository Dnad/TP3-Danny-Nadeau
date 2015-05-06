using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorat.appl.ViewModel
{
    class WorkingHoursTutorListVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int TotalHour { get; set; }
        public string ToString()
        {
            return LastName + ", " + FirstName + ", " + EmailAddress + " Total Heures: " + TotalHour + " heures.";
        }
    }
}
