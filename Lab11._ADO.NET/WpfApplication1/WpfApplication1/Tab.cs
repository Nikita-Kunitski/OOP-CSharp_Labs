using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Tab
    {
        
        public Tab()
        {
                
        }
        public Tab(int id, string name,string date,string phone)
        {
            ID = id;
            FullName = name;
            Date = date;
            Phone = phone;
        }
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Date { get; set; }
        public string Phone { get; set; }
    }
}
