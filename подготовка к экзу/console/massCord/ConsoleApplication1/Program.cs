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
            Paar[] x_y = new Paar[] { new Paar(100,20),
                                      new Paar(50, 200),
                                      new Paar(400,75),
                                      new Paar(100,20)};
            Cords obj = new Cords(x_y);
            //проверка на переопределение
            if(obj[0] == obj[3])
                Console.WriteLine("Равны");
            double lenght=obj.Length(obj[1],obj[3]);
            Console.WriteLine("Расстояние между 1 и 3 равно {0}",lenght);

        }
    }
}
