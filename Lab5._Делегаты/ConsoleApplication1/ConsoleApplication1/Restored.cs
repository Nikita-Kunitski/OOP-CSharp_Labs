using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Restored
    {
        public Stack<Memento> History { get; private set; }
        public Restored()
        {
            History = new Stack<Memento>();
        }
    }
}
