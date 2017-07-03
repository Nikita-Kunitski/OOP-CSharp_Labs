using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApplication1
{
    class Program
    {
        static public void delete(List<Programmer> obj)//удаление с конца
        {
            int count = 0;
            foreach (var item in obj)
            {
                count++;
            }
            obj.RemoveAt(count-1);
        }

        static public void mutation(List<Programmer> obj)
        {
            int count = 0;
            foreach (var item in obj)
            {
                count++;
            }
            int i = count - 1;
            if (!Equals(obj[i].get_set_inf, "Programmer is mutation"))
                obj[i].Mutation();
            else
            {
                while (Equals(obj[i].get_set_inf, "Programmer is mutation"))
                {
                    i--;
                }
                if (i >= 0)
                    obj[i].Mutation();
            }
        }

        delegate void Delete(List<Programmer> variable);
        delegate void Mutation(List<Programmer> variable);
        static void Main(string[] args)
        {
            List<Programmer> programmers=new List<Programmer>();
            Delete del = new Delete(delete);
            Mutation mut = new Mutation(mutation);

            Programmer programmer_1 = new Programmer();
            Programmer programmer_2 = new Programmer();
            Programmer programmer_3 = new Programmer();
            Programmer programmer_4 = new Programmer();
            Programmer programmer_5 = new Programmer();
                programmers.Add(programmer_1);
                programmers.Add(programmer_2);
                programmers.Add(programmer_3);
                programmers.Add(programmer_4);
                programmers.Add(programmer_5);
            Console.WriteLine("Выведем список программистов:");
            foreach (var item in programmers)
            {
                item.Information();
            }
           
            Console.WriteLine("Выполним событие удаления\n");
            del.Invoke(programmers);
            Console.WriteLine("Выведем список заново:");
            foreach (var item in programmers)
            {
                item.Information();
            }

            Console.WriteLine("Теперь запустим событие мутации\n");
            mut.Invoke(programmers);
            mut.Invoke(programmers);
            Console.WriteLine("Выведем список заново");

            foreach (var item in programmers)
            {
                item.Information();
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Рефлексия:");
            /*   Console.WriteLine("2 задание");
               Reflector refl = new Reflector();
               List<FieldInfo> a = new List<FieldInfo>();
              */
            Reflector refl = new Reflector();
            Console.WriteLine("2 задание:");
            refl.Write_to_file(typeof(Programmer).ToString());
        }
    }
}
