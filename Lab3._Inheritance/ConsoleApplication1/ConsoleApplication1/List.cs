using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    delegate string tostring(string var);
    partial class List : ICheckbutton
    {
        protected int list_size;
        protected static int object_counter=0;
        protected string line
        { get; set; }
        protected bool check=false;
        protected string[] list
        { get; set; }
        protected List()
        {}
        public List(int size)
        {
            object_counter++;
            if (size > 10)
                throw new System.Exception();
            else
            {
                list_size = size;
                list = new string[list_size];
            }
        }
        public List(int size,string [] arr)
        {
            object_counter++;
            if (size > 10)
                throw new System.Exception();
            else
            {
                list_size = size;
                list = new string[list_size];
                if (size > arr.Length)
                {
                    for (int i = 0; i < arr.Length; i++)
                        list[i] = arr[i];
                }
                else
                {
                    for (int i = 0; i < list_size; i++)
                        list[i] = arr[i];
                }
            }
        }
        public void WriteToFile(string text)
        {
            File.Create("data.txt");
            File.WriteAllText("data.txt",text);
        }
        public override string ToString()
        {
            tostring variable = var =>
            {
                return var;
            };

            return variable(line);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static Tuple<int, string> Corteg(int a, string line)
        {
            return Tuple.Create<int, string>(a,line);
        }
        public static List operator+(List var1,List var2)
        {
            List result = new List(var1.list_size+var2.list_size);
            for (int i = 0; i < var1.list_size; i++)
                result.list[i] = var1.list[i];
            for (int i = 0, j = var1.list_size - 1; i < var2.list_size; i++, j++)
                result.list[j] = var2.list[i];
            return result;
        }
        public static bool operator !=(List var1, List var2)
        {
            bool inspection = true;
            if (var1.list_size != var2.list_size)
                return false;
            else
            {
                for (int i = 0; i < var1.list_size; i++)
                    if (var1.list[i] != var2.list[i])
                        inspection = false;
            }
            return inspection;
        }
        public static bool operator ==(List var1, List var2)
        {
            bool inspection=true;
            if (var1.list_size != var2.list_size)
                return false;
            else {
                for (int i = 0; i < var1.list_size; i++)
                    if (var1.list[i] != var2.list[i])
                        inspection = false;
                 }
            return inspection;
        }

    }
}
