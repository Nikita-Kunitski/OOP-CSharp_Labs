using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fixedemployee rab_1 = new Fixedemployee(200);
            VariableEmployee rab_2 = new VariableEmployee(100);
            rab_1.Rate();
            rab_2.Rate();
        }
    }
}
