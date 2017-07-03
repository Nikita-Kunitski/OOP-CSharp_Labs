using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class User : IComparable<User>
    {
        public string Login { get; set; }
        public string password { get; set; }
        public User(string log, string pass)
        {
            Login = log;
            password = pass;
        }
        public int CompareTo(User obj)
        {
            return string.Compare( Login, obj.Login);
        }
       
    }
}
