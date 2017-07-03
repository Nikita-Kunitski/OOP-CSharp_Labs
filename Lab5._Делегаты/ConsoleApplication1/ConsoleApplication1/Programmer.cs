using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Programmer
    {
        static int counter = 0;
        string information;
        public int get_count
        {
            get { return counter; }
            
        }
        public string get_set_inf
        {
            get { return information; }
            set { information = value; }
        }
        public Programmer()
        {
            information = "Programmer is alive " + Convert.ToString(counter);
            counter++;
        }
        public void Mutation()
        {
            information = "Programmer is mutation";
        }
        public void Information()
        {
            Console.WriteLine(information);
        }
        public void bolean(bool a)
        { }
    }   
}
