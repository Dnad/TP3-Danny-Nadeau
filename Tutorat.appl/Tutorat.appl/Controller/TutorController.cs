﻿using DataLayer;
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
    public class TutorController
    {
        private readonly IEntityRepository<Tutor> _tutorRepository;


        public TutorController(IEntityRepository<Tutor> _repository)
        {
            _tutorRepository = _repository;
        }
        public void ListAll()
        {
            var tutorList = _tutorRepository.GetAll().ToList<Tutor>();
            var tutorVM = new List<TutorListVM>();

            foreach (Tutor tutor in tutorList)
            {
                tutorVM.Add(new TutorListVM()
                {
                    EmailAddress = tutor.EmailAddress,
                    FirstName = tutor.FirstName,
                    LastName = tutor.LastName
                });
            }
            new TutorListView(tutorVM).Display();
        }

        public void ListAllWithWorkingHoursTotal()
        {
            var tutorList = _tutorRepository.GetAll().ToList<Tutor>();
            var tutorVM = new List<WorkingHoursTutorListVM>();

            foreach (Tutor tutor in tutorList)
            {
                int TotalNbHours = 0;
                foreach (var session in tutor.Session)
                {
                    TotalNbHours += session.LengthSession;
                }

                tutorVM.Add(new WorkingHoursTutorListVM()
                {
                    EmailAddress = tutor.EmailAddress,
                    FirstName = tutor.FirstName,
                    LastName = tutor.LastName,
                    TotalHour = TotalNbHours
                });
            }
            new WorkingHoursTutorListView(tutorVM).Display();
        }

        public void ListWhenNextTutoringSession()
        {
            var tutorList = _tutorRepository.GetAll().ToList<Tutor>();
            var tutorVM = new List<TutorListVM>();
            var listWhenNextTutoringSessionVM = new List<ListWhenNextTutoringSessionVM>();

            foreach (var tutor in tutorList)
            {
                tutorVM.Clear();
                listWhenNextTutoringSessionVM.Clear();

                tutorVM.Add(new TutorListVM()
                {
                    FirstName = tutor.FirstName,
                    LastName = tutor.LastName
                });

                foreach (var session in tutor.Session)
                {
                    if (session.DateTimeSession > DateTime.Now)
                    {
                        listWhenNextTutoringSessionVM.Add(new ListWhenNextTutoringSessionVM()
                        {
                            HelpedFirstName = session.Helped.FirstName,
                            DateTimeSession = session.DateTimeSession,
                            HelpedLastName = session.Helped.LastName,
                            LengthSession = session.LengthSession
                        });
                    }
                }
                

                if (listWhenNextTutoringSessionVM.Count != 0)
                {
                    listWhenNextTutoringSessionVM.OrderBy(Tutor => Tutor.HelpedLastName).ThenBy(TutoringSession => TutoringSession.DateTimeSession);
                    new TutorListView(tutorVM).Display();
                    new ListWhenNextTutoringSessionView(listWhenNextTutoringSessionVM).Display();
                }
            }
        }

        public void ListWhenWithoutTutoringSession(DateTime _sessionDate)
        {
            var tutorList = _tutorRepository.GetAll().ToList<Tutor>();
            var tutorVM = new List<TutorListVM>();

            foreach (Tutor tutor in tutorList)
            {
                bool hasSessionOnDate = false;
                foreach (var session in tutor.Session)
                {
                    if (session.DateTimeSession.Date == _sessionDate.Date)
                    {
                        hasSessionOnDate = true;
                    }
                }
                if (!hasSessionOnDate)
                {
                    tutorVM.Add(new TutorListVM()
                    {
                        EmailAddress = tutor.EmailAddress,
                        FirstName = tutor.FirstName,
                        LastName = tutor.LastName
                    });
                }
            }
            new TutorListView(tutorVM).Display();
        }
    }
}
