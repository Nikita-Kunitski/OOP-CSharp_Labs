using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace WindowsFormsApplication1
{
    [Serializable]
    public class Deposite
    {
        [XmlElement("NumberDeposite")]
        public string NumberDeposite { get; set; }
        [XmlElement("DateOfCreate")]
        public string DateOfCreate { get; set; }
        [XmlElement("TypeDeposite")]
        public string TypeDeposite { get; set; }
        [XmlElement("SMSNotification")]
        public bool SMSNotification { get; set; }
        [XmlElement("InternetBanking")]
        public bool InternetBanking { get; set; }
        public Deposite(string Number, string Date, string Type, bool SMS, bool Internet)
        {
            NumberDeposite = Number;
            DateOfCreate = Date;
            TypeDeposite = Type;
            SMSNotification = SMS;
            InternetBanking = Internet;
        }
        public Deposite()
        {
            NumberDeposite = string.Empty;
            DateOfCreate = string.Empty;
            TypeDeposite = string.Empty;
        }
    }
}
