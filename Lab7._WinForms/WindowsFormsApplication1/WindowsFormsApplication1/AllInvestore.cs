using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AllInvestore : Form
    {
        public AllInvestore()
        {
            InitializeComponent();
        }
        static public List<Investore> list_ = new List<Investore>();
        private void AllInvestore_Load(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Investore));
            
            string[] file_list = Directory.GetFiles(@"D:\2-й курс\2-й семестр\C#\Lab7._WinForms\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug");
            foreach (var item in file_list)
            {
                if (item.EndsWith("_Investore.xml"))
                {
                    using (FileStream fs = new FileStream($"{item}",FileMode.Open))
                    {
                        list_.Add((Investore)formatter.Deserialize(fs));
                        listBox1.Items.Add(list_.Last().FullName);
                    }
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            list_.Sort(delegate(Investore inv1, Investore inv2)
            { return inv1.FullName.CompareTo(inv2.FullName); });
            
            foreach (var item in list_)
            {
                listBox1.Items.Add(item.FullName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            list_.Sort(delegate (Investore inv1, Investore inv2)
            { return inv1.obj.DateOfCreate.CompareTo(inv2.obj.DateOfCreate); });

            foreach (var item in list_)
            {
                listBox1.Items.Add(item.FullName);
            }
        }
    }
}
