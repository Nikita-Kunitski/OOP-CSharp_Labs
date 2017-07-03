using System;
using System.IO;
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
            CollectionType<CCheckList> obj_1 = new CollectionType<CCheckList>(5);
            try
            {
                CCheckList object_1 = new CCheckList(true);
                CCheckList object_2 = new CCheckList(true);
                CCheckList object_3 = new CCheckList(false);
                CCheckList object_4 = new CCheckList(true);
                CCheckList object_5 = new CCheckList(true);
            
            obj_1.Add(object_1);
            obj_1.Add(object_2);
            obj_1.Add(object_3);
            obj_1.Add(object_4);
            obj_1.Add(object_5);
            }
            finally
            {
                Console.WriteLine("Исключение через finally");
            }
            string fileadress = @"D:\2-й курс\2-й семестр\C#\Lab4._LINQ\ConsoleApplication1\ConsoleApplication1\file.txt";
            using (StreamWriter sw = new StreamWriter(fileadress, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < obj_1.Count; i++)
                {
                    sw.WriteLine(obj_1[i].checker);
                }
            }

            CollectionType<int> object_int = new CollectionType<int>(5);
            object_int.Add(5);
            object_int.Add(540);
            object_int.Add(-44);
            object_int.Add(32);
            object_int.Add(95);
            var sort = from obj in object_int
                       orderby obj
                       select obj;

            foreach (var item in sort)
            {
                Console.WriteLine(item);
            }
            var zapros_1 = from obj in object_int
                           where obj < 0
                           select obj;
            Console.WriteLine();
            foreach (var item in zapros_1)
            {
                Console.WriteLine(item);
            }

            var zapros_2 = object_int.Take(3);
            Console.WriteLine();
            Console.WriteLine("Выборка 3 элементов:");
            foreach (var item in zapros_2)
            {
                Console.WriteLine(item);
            }

            var dict = new Dictionary<int,string>(5);
            string val;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите строку №{0}",i+1);
                val=Console.ReadLine();
                dict.Add(i, val);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Выведем Dictionary:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Строка №{0} {1}", i + 1,dict[i]);
            }
            Console.WriteLine("Введите длину строки по которой будет строится запрос");
            int len;
            len = Convert.ToInt32(Console.ReadLine());
            var zapr_dict = dict.Count(t => t.Value.Length == len);
            Console.WriteLine("Всего совпадений:{0}", zapr_dict);
            Console.WriteLine("\nСортировка:");
            var dict_sort = from obj in dict
                            orderby obj.Value.Length
                            select obj.Value;
            foreach (var item in dict_sort)
            {
                Console.WriteLine(item);
            }
                          }
    }
}
