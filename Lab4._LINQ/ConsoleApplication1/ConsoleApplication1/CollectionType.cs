using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CollectionType<T> : IList<T>
    {
        
        List<T> objects = new List<T>();
        public CollectionType()
        {
            objects.Capacity = 10;
            if (objects.Capacity==10)
            {
                throw new Exception();
            }
        }
        
        public CollectionType(int val)
        {
            objects.Capacity = val;
        }
        public List<T> Objects
            { 
                get 
                {
                    return objects;
                }
            }
        public T this[int index]
        {
            get
            {
                return objects[index];
            }
            set
            {
                objects[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return objects.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            objects.Add(item);
        }

        public void Clear()
        {
            objects.Clear();
        }

        public bool Contains(T item)
        {
           return objects.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            objects.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return objects.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return objects.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            objects.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return objects.Remove(item);
        }

        public void RemoveAt(int index)
        {
            objects.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return objects.GetEnumerator();
        }
    }
}
