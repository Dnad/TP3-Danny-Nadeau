using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorat.appl.ViewModel
{
    class HelpedListVM
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int Id { get; set; }

       public override string ToString()
        {
             return Id.ToString() + "= " + LastName + ", " + FirstName + ", " + EmailAddress;
        }
    }
}
