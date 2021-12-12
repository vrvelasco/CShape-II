using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolleeApp
{
    interface IPaysTuition
    {
        double TuitionRate { get; }
        double Tuition { get; }
        string FullName { get; }


    }
}
