using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EfEntityFramework
{
    public class EfDataBaseTestHelper
    {
        private EfEntityRepository<Tutor> _tutorRepository;
        private EfEntityRepository<HelpedStudent> _helpedStudentRepository;
        private EfEntityRepository<TutoringSession> _tutoringSessionRepository;


        public EfDataBaseTestHelper()
        {
            _tutorRepository = new EfEntityRepository<Tutor>();
            _helpedStudentRepository = new EfEntityRepository<HelpedStudent>();
            _tutoringSessionRepository = new EfEntityRepository<TutoringSession>();
        }
        public void creationSeedTable()
        {
            _tutorRepository.DeleteAll();
            _helpedStudentRepository.DeleteAll();
            _tutoringSessionRepository.DeleteAll();


            Tutor tutor1 = new Tutor() { LastName = "Bilodeau", FirstName = "Gary", EmailAddress = "bgary@hotmail.com" };
            Tutor tutor2 = new Tutor() { LastName = "Gagnon", FirstName = "Samuel", EmailAddress = "samPP92@hotmail.com" };
            Tutor tutor3 = new Tutor() { LastName = "Gingras", FirstName = "Simon", EmailAddress = "ptitguy22@bell.net" };
            Tutor tutor4 = new Tutor() { LastName = "Roy", FirstName = "Eric", EmailAddress = "eroy231@videotron.ca" };
            Tutor tutor5 = new Tutor() { LastName = "Veilleux", FirstName = "Caroline", EmailAddress = "caro.koko@hotmail.com" };
            Tutor tutor6 = new Tutor() { LastName = "Tremblay", FirstName = "Karine", EmailAddress = "kar.tremblay@gmail.com" };
            Tutor tutor7 = new Tutor() { LastName = "Vezina", FirstName = "Louis", EmailAddress = "vl410Bd@gmail.com" };
            _tutorRepository.Add(tutor1);
            _tutorRepository.Add(tutor2);
            _tutorRepository.Add(tutor3);
            _tutorRepository.Add(tutor4);
            _tutorRepository.Add(tutor5);
            _tutorRepository.Add(tutor6);
            _tutorRepository.Add(tutor7);

            HelpedStudent hS1 = new HelpedStudent() { LastName = "Arsenault", FirstName = "Marc", EmailAddress = "marco.arso@hotmail.com" };
            HelpedStudent hS2 = new HelpedStudent() { LastName = "Boilard", FirstName = "Eric", EmailAddress = "eric.r.boilard2@coop.com" };
            HelpedStudent hS3 = new HelpedStudent() { LastName = "Couture", FirstName = "Jean-Christophe", EmailAddress = "jc.couture.wilde@hotmail.com" };
            HelpedStudent hS4 = new HelpedStudent() { LastName = "Desrosiers", FirstName = "Julianne", EmailAddress = "galypo13@hotmail.com" };
            HelpedStudent hS5 = new HelpedStudent() { LastName = "Gregoire-Allen", FirstName = "Leo", EmailAddress = "leoga@hotmail.com" };
            HelpedStudent hS6 = new HelpedStudent() { LastName = "Hamel", FirstName = "Francois", EmailAddress = "fran.ham@hotmail.com" };
            HelpedStudent hS7 = new HelpedStudent() { LastName = "Lepage", FirstName = "Jeremy", EmailAddress = "jer.lep@hotmail.com" };
            HelpedStudent hS8 = new HelpedStudent() { LastName = "Poitras", FirstName = "Nicolas", EmailAddress = "nic.poi@hotmail.com" };
            HelpedStudent hS9 = new HelpedStudent() { LastName = "Roy-Gagnon", FirstName = "Samuel", EmailAddress = "sam.roy@hotmail.com" };
            HelpedStudent hS10 = new HelpedStudent() { LastName = "Simard", FirstName = "Benjamin", EmailAddress = "ben.sim@hotmail.com" };
            HelpedStudent hS11 = new HelpedStudent() { LastName = "Vachon", FirstName = "Samuel", EmailAddress = "sam.vac@hotmail.com" };
            _helpedStudentRepository.Add(hS1);
            _helpedStudentRepository.Add(hS2);
            _helpedStudentRepository.Add(hS3);
            _helpedStudentRepository.Add(hS4);
            _helpedStudentRepository.Add(hS5);
            _helpedStudentRepository.Add(hS6);
            _helpedStudentRepository.Add(hS7);
            _helpedStudentRepository.Add(hS8);
            _helpedStudentRepository.Add(hS9);
            _helpedStudentRepository.Add(hS10);
            _helpedStudentRepository.Add(hS11);

            TutoringSession tS1 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16,13, 00, 00), LengthSession = 2, HelpedStudentID = hS5.Id, TutorID = tutor5.Id };
            TutoringSession tS2 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 24, 10, 00, 00), LengthSession = 1, HelpedStudentID = hS5.Id, TutorID = tutor1.Id };
            TutoringSession tS3 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 25, 13, 00, 00), LengthSession = 1, HelpedStudentID = hS2.Id, TutorID = tutor4.Id };
            TutoringSession tS4 = new TutoringSession() { DateTimeSession = new DateTime(2015, 04, 01, 12, 00, 00), LengthSession = 2, HelpedStudentID = hS1.Id, TutorID = tutor5.Id };
            TutoringSession tS5 = new TutoringSession() { DateTimeSession = new DateTime(2015, 04, 01, 13, 00, 00), LengthSession = 1, HelpedStudentID = hS2.Id, TutorID = tutor3.Id };
            TutoringSession tS6 = new TutoringSession() { DateTimeSession = new DateTime(2015, 04, 06, 16, 00, 00), LengthSession = 1, HelpedStudentID = hS1.Id, TutorID = tutor4.Id };
            TutoringSession tS7 = new TutoringSession() { DateTimeSession = new DateTime(2015, 04, 08, 10, 00, 00), LengthSession = 1, HelpedStudentID = hS6.Id, TutorID = tutor4.Id };
            TutoringSession tS8 = new TutoringSession() { DateTimeSession = new DateTime(2015, 04, 10, 10, 00, 00), LengthSession = 2, HelpedStudentID = hS1.Id, TutorID = tutor4.Id };
            TutoringSession tS9 = new TutoringSession() { DateTimeSession = new DateTime(2015, 04, 29, 12, 00, 00), LengthSession = 1, HelpedStudentID = hS9.Id, TutorID = tutor5.Id };
            TutoringSession tS10 = new TutoringSession() { DateTimeSession = new DateTime(2015, 05, 25, 13, 00, 00), LengthSession = 1, HelpedStudentID = hS10.Id, TutorID = tutor7.Id };
            TutoringSession tS11 = new TutoringSession() { DateTimeSession = new DateTime(2015, 05, 27, 12, 00, 00), LengthSession = 2, HelpedStudentID = hS10.Id, TutorID = tutor5.Id };
            TutoringSession tS12 = new TutoringSession() { DateTimeSession = new DateTime(2015, 05, 27, 13, 00, 00), LengthSession = 1, HelpedStudentID = hS2.Id, TutorID = tutor3.Id };
            TutoringSession tS13 = new TutoringSession() { DateTimeSession = new DateTime(2015, 06, 01, 09, 00, 00), LengthSession = 1, HelpedStudentID = hS7.Id, TutorID = tutor7.Id };
            TutoringSession tS14 = new TutoringSession() { DateTimeSession = new DateTime(2015, 06, 02, 09, 00, 00), LengthSession = 1, HelpedStudentID = hS11.Id, TutorID = tutor7.Id };
            TutoringSession tS15 = new TutoringSession() { DateTimeSession = new DateTime(2015, 06, 02, 11, 00, 00), LengthSession = 1, HelpedStudentID = hS2.Id, TutorID = tutor7.Id };
            TutoringSession tS16 = new TutoringSession() { DateTimeSession = new DateTime(2015, 06, 02, 13, 00, 00), LengthSession = 1, HelpedStudentID = hS5.Id, TutorID = tutor1.Id };
            TutoringSession tS17 = new TutoringSession() { DateTimeSession = new DateTime(2015, 06, 02, 15, 00, 00), LengthSession = 1, HelpedStudentID = hS9.Id, TutorID = tutor4.Id };
            TutoringSession tS18 = new TutoringSession() { DateTimeSession = new DateTime(2015, 06, 03,13, 00, 00), LengthSession = 2, HelpedStudentID = hS7.Id, TutorID = tutor3.Id };
            _tutoringSessionRepository.Add(tS1);
            _tutoringSessionRepository.Add(tS2);
            _tutoringSessionRepository.Add(tS3);
            _tutoringSessionRepository.Add(tS4);
            _tutoringSessionRepository.Add(tS5);
            _tutoringSessionRepository.Add(tS6);
            _tutoringSessionRepository.Add(tS7);
            _tutoringSessionRepository.Add(tS8);
            _tutoringSessionRepository.Add(tS9);
            _tutoringSessionRepository.Add(tS10);
            _tutoringSessionRepository.Add(tS11);
            _tutoringSessionRepository.Add(tS12);
            _tutoringSessionRepository.Add(tS13);
            _tutoringSessionRepository.Add(tS14);
            _tutoringSessionRepository.Add(tS15);
            _tutoringSessionRepository.Add(tS16);
            _tutoringSessionRepository.Add(tS17);
            _tutoringSessionRepository.Add(tS18);
        }
    }
}
