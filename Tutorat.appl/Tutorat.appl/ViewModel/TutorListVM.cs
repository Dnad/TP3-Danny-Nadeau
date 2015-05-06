using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorat.appl.ViewModel
{
    class TutorListVM
    {
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return Id.ToString() + "= " + LastName + ", " + FirstName + ", " + EmailAddress;
        }
    }
}
