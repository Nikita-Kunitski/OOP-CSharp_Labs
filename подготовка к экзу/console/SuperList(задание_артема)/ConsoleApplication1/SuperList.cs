using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SuperList<T>:List<T>
    {
        T obj;
        public SuperList(T obj_)
        {
            obj = obj_;
        }
        public SuperList()
        {
        }
        public static SuperList<T> operator -(SuperList<T> list)
        {
            if (list.Count >= 1)
            {
                list.RemoveAt(list.Count - 1);
                return list;
            }
            else {
                throw new IndexOutOfRangeException();
                
            }
        }
    }
}
