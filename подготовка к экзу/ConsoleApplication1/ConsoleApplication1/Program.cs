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
            string[] names = { "Анна", "Станислав", "Ольга", "Сева" };
            IEnumerable<int> nameLen = names.Select(p => p.Length);
            foreach (var item in nameLen)
            {
                Console.WriteLine(item);
            }
        }
    }
}
