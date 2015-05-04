using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    class TutoringSession:Entity
    {
        public DateTime DateTimeSession { get; set; }
        public int LengthSession { get; set; }

        public int Time { get; set; }
        //cles etrangeres
        public int TutorID { get; set; }
        public int HelpedStudentID { get; set; }
        public HelpedStudent Helped { get; set; }
        public Tutor Tutor { get; set; }
    }
}
