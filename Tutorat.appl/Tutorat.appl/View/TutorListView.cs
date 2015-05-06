using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorat.appl.ViewModel;

namespace Tutorat.appl.View
{
    class TutorListView
    {
        private IEnumerable<TutorListVM> tutorList;

        public TutorListView(IEnumerable<TutorListVM> _tutorList)
        {
            tutorList = _tutorList;
        }

        public void Display()
        {
            foreach (TutorListVM tutorListVM in tutorList)
            {
                Console.WriteLine(tutorListVM.ToString());
                Console.WriteLine("");
            }
        }

    }
}
