using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    sealed class CCheckList
    {
        bool check
        { get; set; }
        public CCheckList(bool val)
        { check = val; }
    }
}
