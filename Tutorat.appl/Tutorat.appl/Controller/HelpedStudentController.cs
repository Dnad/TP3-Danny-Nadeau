using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorat.appl.Controller
{
    class HelpedStudentController
    {
        private readonly IEntityRepository<HelpedStudent> _helpedRepository;


        public HelpedStudentController(IEntityRepository<HelpedStudent> _repository)
        {
            _helpedRepository = _repository;
        }
        void ListAll()
        {

        }

        void ListWhenWithoutTutoringSession()
        {

        }
    }
}
