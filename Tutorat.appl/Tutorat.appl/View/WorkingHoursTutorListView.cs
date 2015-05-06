using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorat.appl.ViewModel;

namespace Tutorat.appl.View
{
    class WorkingHoursTutorListView
    {
         private readonly IEnumerable<WorkingHoursTutorListVM> tutorList;

         public WorkingHoursTutorListView(IEnumerable<WorkingHoursTutorListVM> _tutorList)
        {
            tutorList = _tutorList;
        }

        public void Display()
        {
            foreach (var tutor in tutorList)
            {
                Console.WriteLine(tutor.ToString());
            }
        }
    }
}
