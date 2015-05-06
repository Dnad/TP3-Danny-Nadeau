using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorat.appl.ViewModel;

namespace Tutorat.appl.View
{
    class HelpedListView
    {
        private IEnumerable<HelpedListVM> helpedList;

        public HelpedListView(IEnumerable<HelpedListVM> _helpedList)
        {
            helpedList = _helpedList;
        }

        public void Display()
        {
            foreach (HelpedListVM helpedListVM in helpedList)
            {
                Console.WriteLine(helpedListVM.ToString());
            }
        }
    }
}
