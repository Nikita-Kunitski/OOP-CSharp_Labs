using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class CCheckList : IComparable, IEnumerable
    {
        bool check;
        public bool checker
        {
            get {
                return check;
            }
            set { check = value; }
        }
        public int CompareTo(object obj)
        {
            return check.CompareTo(obj);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public CCheckList(bool val)
        { check = val; }
    }
}
