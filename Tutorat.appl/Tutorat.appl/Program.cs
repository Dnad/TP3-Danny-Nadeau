using DataLayer.EfEntityFramework;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorat.appl.Controller;

namespace TutoratAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            
            EfDataBaseTestHelper _dataBaseHelper = new EfDataBaseTestHelper();
            _dataBaseHelper.creationSeedTable();
            var tutorController = new TutorController(new EfEntityRepository<Tutor>());
            var helpedStudentController = new HelpedStudentController(new EfEntityRepository<HelpedStudent>());
            var sessionController = new SessionController(new EfEntityRepository<TutoringSession>());

            //Section B2
            Console.WriteLine("Section B2: ");
            //Requete 1
            Console.WriteLine("Requete 1: ");
            tutorController.ListAll();
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
            //Requete 2
            Console.WriteLine("Requete 2: ");
            helpedStudentController.ListAll();
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
            //Requete 3
            Console.WriteLine("Requete 3: ");
            sessionController.ListAll();
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();

            //Section C
            Console.WriteLine("Section C: ");
            //Requete 1
            Console.WriteLine("Requete 1: ");
            tutorController.ListAllWithWorkingHoursTotal();
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
            //Requete 2
            Console.WriteLine("Requete 2: ");
            tutorController.ListWhenNextTutoringSession();
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
            //Requete 3
            Console.WriteLine("Requete 3: ");
            helpedStudentController.ListWhenWithoutTutoringSession();
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
            //Requete 4
            Console.WriteLine("Requete 4: ");
            tutorController.ListWhenWithoutTutoringSession(new DateTime(2015, 06, 02));
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
        }
    }
}
