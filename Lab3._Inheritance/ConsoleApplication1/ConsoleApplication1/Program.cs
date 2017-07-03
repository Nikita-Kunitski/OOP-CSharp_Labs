using System;
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
            try
            {
                List object_1_ = new List(3);
                object_1_.Checked();
                List object_2 = new List(20);
            }
            catch (Exeption_bool)
            {
                Console.WriteLine("Переменная чек уже находится в этом состоянии");
            }
            catch (Exception)
            {
                Console.WriteLine("Слишком большое значение! должно быть меньше 10 строк");
            }
            string[] arr_1 = { "A", "B", "C", "D", "F" };
            string[] arr_2 = { "Adfg", "sdB", "dsfC", "Dasf", "Fsdfc" };
            List object_1 = new List(5,arr_1);
            var A= List.Corteg(25,"sjkhgkj");
            Console.WriteLine("{0}\t:\t{1}",A.Item1,A.Item2);
            //////////////////////////////////////////////////////////////////////////////

            Single obj = Single.getobj(true);
            Single obj_2 = Single.getobj(false);
            Console.WriteLine("Работа с паттерным принципом Singleton");
            Console.WriteLine("obj и obj_2 имеют поля: {0} и {1}",obj.inspection,obj_2.inspection);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\nCheck for object_1:{0}",object_1.checking);
            Restored restore = new Restored();
            restore.History.Push(object_1.Saved_check());
            object_1.checking = true;
            Console.WriteLine("\nNew Check for object_1:{0}", object_1.checking);
            object_1.Restore_check(restore.History.Pop());
            Console.WriteLine("\nRestore Check for object_1:{0}", object_1.checking);
        }
    }
}
