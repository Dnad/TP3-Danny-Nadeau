using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorat.appl.ViewModel;

namespace Tutorat.appl.View
{
    class SessionListView
    {
        private IEnumerable<SessionListVM> sessionList;

        public SessionListView(IEnumerable<SessionListVM> _sessionList)
        {
            sessionList = _sessionList;
        }

        public void Display()
        {
            foreach (SessionListVM sessionListVM in sessionList)
            {
                Console.WriteLine(sessionListVM.ToString());
            }
        }
    }
}
