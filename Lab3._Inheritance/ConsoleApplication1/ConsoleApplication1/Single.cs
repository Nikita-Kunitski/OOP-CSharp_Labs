using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Single
    {
        public bool inspection
        { get; set; }
        private static Single instance;
        private Single(bool checker)
        {
            inspection = checker;
        }
        public static Single getobj(bool checker)
        {
            if (instance == null)
                instance = new Single(checker);
            return instance;
        }
    }
}
