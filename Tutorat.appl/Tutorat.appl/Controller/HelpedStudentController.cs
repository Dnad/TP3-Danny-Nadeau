using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorat.appl.View;
using Tutorat.appl.ViewModel;

namespace Tutorat.appl.Controller
{
    class HelpedStudentController
    {
        private readonly IEntityRepository<HelpedStudent> _helpedRepository;


        public HelpedStudentController(IEntityRepository<HelpedStudent> _repository)
        {
            _helpedRepository = _repository;
        }
        public void ListAll()
        {
            var helpedList = _helpedRepository.GetAll().ToList<HelpedStudent>();
            var helpedVM = new List<HelpedListVM>();

            foreach (HelpedStudent helpedStudent in helpedList)
            {
                helpedVM.Add(new HelpedListVM()
                {
                    Id = helpedStudent.Id,
                    FirstName = helpedStudent.FirstName,
                    LastName = helpedStudent.LastName,
                    EmailAddress = helpedStudent.EmailAddress
                });
            }
            new HelpedListView(helpedVM).Display();
        }

        public void ListWhenWithoutTutoringSession()
        {
            var helpedList = _helpedRepository.GetAll().ToList<HelpedStudent>();
            var helpedVM = new List<HelpedListVM>();

            foreach (HelpedStudent helpedStudent in helpedList)
            {
                if (helpedStudent.Session.Count == 0)
                {
                    helpedVM.Add(new HelpedListVM()
                    {
                        FirstName = helpedStudent.FirstName,
                        LastName = helpedStudent.LastName,
                        EmailAddress = helpedStudent.EmailAddress
                    });
                }
            }
            new HelpedListView(helpedVM).Display();
        }
    }
}
