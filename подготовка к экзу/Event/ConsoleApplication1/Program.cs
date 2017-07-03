using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class counter
    {
        public delegate void MethodContainer();
        public event MethodContainer onCount;
        public void count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 71)
                {
                    if (onCount != null)
                        onCount();
                }
            }
        }
    }
    class h1
    {
        public void Message()
        {
            Console.WriteLine("Пора действовать, уже 71");
        }
    }
    class h2
    {
        public void Message()
        {
            Console.WriteLine("Точно, 71");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            counter count = new counter();
            h1 h1_ = new h1();
            h2 h2_ = new h2();
            count.onCount += h2_.Message;
            count.onCount += h1_.Message;
            count.count();
        }
    }
}
