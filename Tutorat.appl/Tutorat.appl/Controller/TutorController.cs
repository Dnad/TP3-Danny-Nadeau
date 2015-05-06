using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorat.appl.Controller
{
    class TutorController
    {
        private readonly IEntityRepository<Tutor> _tutorRepository;


        public TutorController(IEntityRepository<Tutor> _repository)
        {
            _tutorRepository = _repository;
        }
        void ListAll()
        {
            
        }
        void ListAllWithWorkingHoursTotal()
        {

        }
        void ListWhenNextTutoringSession()
        {

        }
        void ListWhenWithoutTutoringSession(DateTime _sessionDate)
        {

        }
    }
}
