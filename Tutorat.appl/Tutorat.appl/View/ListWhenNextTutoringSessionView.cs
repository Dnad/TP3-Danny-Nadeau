using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorat.appl.ViewModel;

namespace Tutorat.appl.View
{
    class ListWhenNextTutoringSessionView
    {
        private IEnumerable<ListWhenNextTutoringSessionVM> tutorringSessionList;

        public ListWhenNextTutoringSessionView(IEnumerable<ListWhenNextTutoringSessionVM> _tutorringSessionList)
        {
            tutorringSessionList = _tutorringSessionList;
        }

        public void Display()
        {
            foreach (ListWhenNextTutoringSessionVM tutoringSessionVM in tutorringSessionList)
            {
                Console.WriteLine(tutoringSessionVM.ToString());
                Console.WriteLine("");
            }
        }
    }
}
