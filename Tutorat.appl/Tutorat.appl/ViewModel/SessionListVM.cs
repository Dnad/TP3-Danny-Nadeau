using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorat.appl.ViewModel
{
    class SessionListVM
    {
        public DateTime DateTimeSession { get; set; }
        public int Time { get; set; }
        public string HelpedFirstName { get; set; }
        public string HelpedLastName { get; set; }
        public int LengthSession { get; set; }
        public string TutorFirstName { get; set; }
        public string TutorLastName { get; set; }
        public override string ToString()
        {
            return DateTimeSession + ", " + LengthSession + ", " + HelpedFirstName + ", " + HelpedLastName + ", " + TutorFirstName + ", " + TutorLastName;
        }
    }
}
