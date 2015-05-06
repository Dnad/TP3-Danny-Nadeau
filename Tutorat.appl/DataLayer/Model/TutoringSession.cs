using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class TutoringSession:Entity
    {
        public DateTime DateTimeSession { get; set; }
        public int LengthSession { get; set; }
        //cles etrangeres
        public int TutorID { get; set; }
        public int HelpedStudentID { get; set; }
        public virtual HelpedStudent Helped { get; set; }
        public virtual Tutor Tutor { get; set; }
    }
}
