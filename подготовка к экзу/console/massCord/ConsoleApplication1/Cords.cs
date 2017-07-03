using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cords
    {
        private Paar[] arr;
        public Cords(Paar[] Arr)
        {
            arr = Arr;
        }
        public Paar this [int index]
        {
            get { return arr[index]; }
            set { }
        }
        public double Length(Paar obj1, Paar obj2)
        {
            double length = 0;
            length = Math.Sqrt(Math.Pow(Math.Abs(obj2.X-obj1.X),2)+ Math.Pow(Math.Abs(obj2.Y - obj1.Y), 2));
            return length;
        }
        
    }
}
