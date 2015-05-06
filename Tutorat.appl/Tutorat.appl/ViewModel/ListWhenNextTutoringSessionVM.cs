using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorat.appl.ViewModel
{
    class ListWhenNextTutoringSessionVM
    {
        public string HelpedFirstName { get; set; }
        public DateTime DateTimeSession{get; set;}
        public string HelpedLastName{get; set;}
        public int LengthSession { get; set; }
        public string ToString()
        {
            return DateTimeSession + ", " + "Duree:" + LengthSession + ", " + HelpedLastName + ", " + HelpedFirstName;
        }
    }
}
