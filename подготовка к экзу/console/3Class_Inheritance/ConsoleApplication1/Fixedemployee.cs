using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fixedemployee : employee
    {
        public Fixedemployee(int sal) : base(sal)
        { }
        public override void Rate()
        {
            rate = salary;
            Console.WriteLine("Ставка равна зарплате: salare={0}, rate={1}",salary,rate);
        }
    }
}
