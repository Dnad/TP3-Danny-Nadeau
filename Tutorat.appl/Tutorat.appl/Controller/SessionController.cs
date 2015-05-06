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
    class SessionController
    {
        private readonly IEntityRepository<TutoringSession> _sessionRepository;

        public SessionController(IEntityRepository<TutoringSession> _repository)
        {
            _sessionRepository = _repository;
        }

        public void ListAll()
        {
            var sessionList = _sessionRepository.GetAll().ToList<TutoringSession>();
            var sessionsVM = new List<SessionListVM>();

            foreach (TutoringSession tutoringSession in sessionList)
            {
                sessionsVM.Add(new SessionListVM()
                {
                    DateTimeSession = tutoringSession.DateTimeSession,
                    HelpedFirstName = tutoringSession.Helped.FirstName,
                    HelpedLastName = tutoringSession.Helped.LastName,
                    Id = tutoringSession.Id,
                    LengthSession = tutoringSession.LengthSession,
                    TutorFirstName = tutoringSession.Tutor.FirstName,
                    TutorLastName = tutoringSession.Tutor.LastName
                });
            }
            new SessionListView(sessionsVM).Display();
        }
    }
}
