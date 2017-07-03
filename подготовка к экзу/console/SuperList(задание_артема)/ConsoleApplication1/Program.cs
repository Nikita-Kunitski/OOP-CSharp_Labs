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
            SuperList<string> list = new SuperList<string>();
            
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Удаление элемента");
            SuperList<string> list_2 = new SuperList<string>();
                try
                {
                    list_2 = -list;
                }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Выход за предел");
                    }
            foreach (var item in list_2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
