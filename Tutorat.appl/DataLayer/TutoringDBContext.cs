using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class TutoringDBContext:DbContext
    {
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<HelpedStudent> HelpedStudents { get; set; }
        public DbSet<TutoringSession> TutoringSessions { get; set; }
    }
}
