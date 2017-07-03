using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class VariableEmployee:employee
    {
        public VariableEmployee(int sal) : base(sal)
        { }
        public override void Rate()
        {
            rate = 20 * 8 * salary;
            Console.WriteLine("Ставка равняется по формуле: 20*8*salary={0}\n",rate);
        }
    }
}
