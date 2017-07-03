using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class employee
    {
        public employee(int sal)
        {
            salary = sal;
        }
        public int salary { get; set; }
        public int rate { get; set; }
        public virtual void Rate()
        {
        }
    }
}
