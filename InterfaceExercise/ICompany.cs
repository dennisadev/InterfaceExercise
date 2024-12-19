using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface ICompany
    {
        //* Create 2 members that are specific to each every company
        public  string CompanyName { get; set; }
        public string CompanyLogo { get; set; }
    }
}
