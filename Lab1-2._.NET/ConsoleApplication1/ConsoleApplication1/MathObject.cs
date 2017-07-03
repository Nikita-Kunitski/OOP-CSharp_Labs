using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MathObject
    {
        public int Perimetr(ref int edge, ref int val)
        {
           int perimetr = edge * val;
            return perimetr;
        }
        public int Area(ref int edge, ref int val)
        {
            int area = (edge * val) / 2;
            return area;
        }

        public void box(ref int size_box_length, ref int size_box_height, ref int size_obj)
        {
            if (size_box_length >= size_obj && size_box_height >= size_obj)
                Console.WriteLine("The figure is placed in box");
            else
                Console.WriteLine("The figure is not placed in box");
        }
    }
}
