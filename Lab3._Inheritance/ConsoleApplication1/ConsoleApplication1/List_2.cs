using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    partial class List
    {
        public virtual void Checked()
        {
            if (check == true)
                throw new Exeption_bool();
            check = true;
            Console.WriteLine("Cheking ", object_counter);
        }
        public virtual void Unchecked()
        {
            if (check == false)
                throw new Exeption_bool();
            check = false;
            Console.WriteLine("Unchecking");
        }
        public bool checking {
        get { return check;}
            set { check = value; }
        }
        public Memento Saved_check()
        {
            Console.WriteLine("Saved check");
            return new Memento(this);
        }
        public void Restore_check(Memento memento)
        {
            Console.WriteLine("Restore check");
            check = memento.inspection;
        }
    }
}
