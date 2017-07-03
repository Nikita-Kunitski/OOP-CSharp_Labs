using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{//паттерн сингл
    class Line_List : List
    {
       private string line;
        public string gs_line
        {
            get { return line; }
            set { line = value; }
        }
        public Line_List()
        { line = "New text"; }
        private Line_List(string val)
        { line = val; }
       
    }
}
