using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Paar
    {
       public int X { get; set; }
        public int Y { get; set; }
        public Paar(int x, int y)
        {
            X = x;
            Y = y;
        }
        public static bool operator !=(Paar a, Paar b)
        {
            if (a.X != b.X || a.Y != b.Y)
                return true;
            else
                return false;
        }
        public static bool operator ==(Paar a, Paar b)
        {
            if (a.X == b.X && a.Y == b.Y)
                return true;
            else return false;

        }
    }
}
