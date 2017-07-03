using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        static public int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index++;
            if (index % 2 != 0)
            {
                toolStripMenuItem1.Text = "Menu";
                открытьToolStripMenuItem.Text = "Open";
                закрытьToolStripMenuItem.Text = "Close";
                button1.Text = "Language";
            }
            else {
                toolStripMenuItem1.Text = "Меню";
                открытьToolStripMenuItem.Text = "Открыть";
                закрытьToolStripMenuItem.Text = "Закрыть";
                button1.Text = "Язык";
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog()
            { Filter = "Текстовые файлы(*.txt)|*.txt" };
            if (ofd.ShowDialog() == DialogResult.OK)
                filename = ofd.FileName;
            textBox1.Text+=filename;
        }
    }
}
