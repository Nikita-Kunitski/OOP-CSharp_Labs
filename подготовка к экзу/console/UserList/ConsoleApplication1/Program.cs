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
            User user_1 = new User("123","qwerty");
            User user_2 = new User("qwerty", "123");
            User user_3 = new User("567", "yuiop");
            List<User> list = new List<User>();
            list.Add(user_1);
            list.Add(user_2);
            list.Add(user_3);
            Console.WriteLine("Выведем список пользователей");
            foreach (var item in list)
            {
                Console.WriteLine(item.Login+" "+item.password);
            }
            list.Sort();
            Console.WriteLine("Выведем список отсортированных пользователей");
            foreach (var item in list)
            {
                Console.WriteLine(item.Login+" "+item.password);
            }
        }
    }
}
