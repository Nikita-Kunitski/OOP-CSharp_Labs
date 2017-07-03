using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    public partial class SearchDeposite : Form
    {
        public SearchDeposite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Investore));
            Investore obj = new Investore();
            string filename = string.Empty;
            int i = 0;
            string [] list = Directory.GetFiles(@"D:\2-й курс\2-й семестр\C#\Lab7._WinForms\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug");
            foreach (var item in list)
            {
                if (item.EndsWith(string.Format($"{textBox1.Text}_Investore.xml")))
                {
                    using (FileStream fs=new FileStream($"{item}",FileMode.Open))
                    {
                        obj = (Investore)formatter.Deserialize(fs);
                        label4.Text = obj.FullName;
                        label6.Text = obj.Phone;
                        label11.Text = obj.BirthDay;
                        label13.Text = obj.obj.TypeDeposite;
                        checkBox1.Checked = obj.obj.SMSNotification;
                        checkBox2.Checked = obj.obj.InternetBanking;
                        label15.Text = obj.obj.DateOfCreate;
                        return;
                    }
                        
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            label4.Text = string.Empty;
            label6.Text = string.Empty;
            label11.Text = string.Empty;
            label13.Text = string.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            label15.Text = string.Empty;
        }
        static public List<Investore> list_ = new List<Investore>();
        private void SearchDeposite_Load(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Investore));

            string[] file_list = Directory.GetFiles(@"D:\2-й курс\2-й семестр\C#\Lab7._WinForms\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug");
            foreach (var item in file_list)
            {
                if (item.EndsWith("_Investore.xml"))
                {
                    using (FileStream fs = new FileStream($"{item}", FileMode.Open))
                    {
                        list_.Add((Investore)formatter.Deserialize(fs));
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in list_)
            {
                if (item.FullName == textBox2.Text)
                {
                    label4.Text = item.FullName;
                    label6.Text = item.Phone;
                    label11.Text = item.BirthDay;
                    label13.Text = item.obj.TypeDeposite;
                    checkBox1.Checked = item.obj.SMSNotification;
                    checkBox2.Checked = item.obj.InternetBanking;
                    label15.Text = item.obj.DateOfCreate;
                    return;
                }
            }
        }

        
    }
}
