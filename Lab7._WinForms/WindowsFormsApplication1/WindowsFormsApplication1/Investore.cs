using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace WindowsFormsApplication1
{
    [Serializable]
    public class Investore
    {
        [XmlElement("FullName")]
        public string FullName { get; set; }
        [XmlElement("Phone")]
        public string Phone { get; set; }
        [XmlElement("BirthDay")]
        public string BirthDay { get; set; }
        [XmlElement("obj")]
        public Deposite obj { get; set; }
        public Investore(string Name, string NumberPhone, string Birth, Deposite obj_)
        {
            FullName = Name;
            Phone = NumberPhone;
            BirthDay = Birth;
            obj = obj_;
        }
        public Investore(Deposite obj_)
        {
            FullName = string.Empty;
            Phone = string.Empty;
            BirthDay = string.Empty;
            obj = obj_;
        }
        public Investore()
        {
         
        }
    }
}
