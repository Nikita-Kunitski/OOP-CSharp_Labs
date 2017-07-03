using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            Registration obj = new Registration();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchDeposite obj = new SearchDeposite();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllInvestore obj = new AllInvestore();
            obj.Show();
        }
    }
}
