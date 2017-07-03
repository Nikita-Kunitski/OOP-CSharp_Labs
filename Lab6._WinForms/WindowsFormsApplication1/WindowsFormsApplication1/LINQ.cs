using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication1;

namespace WindowsFormsApplication1
{
    delegate void Comparator(object sender, EventArgs e);
    public partial class LINQ : Form
    {
        public LINQ()
        {
            InitializeComponent();
        }

        private void GenereationCollectionInt(object sender, EventArgs e)
        {
            if (Values.Text == string.Empty )
            {
                MessageBox.Show("Проверьте поле!");
            }
            else
            {
                if (Convert.ToInt32(Values.Text) > 5 || Convert.ToInt32(Values.Text) < 0)
                {
                    MessageBox.Show("Вы ввели неверное значение!");
                }
                else
                {
                    listBox1.Items.Clear();
                    CollectionType<int> object_int = new CollectionType<int>(5);
                    object_int.Add(5);
                    object_int.Add(540);
                    object_int.Add(-44);
                    object_int.Add(32);
                    object_int.Add(95);
                    for (int i = 0; i < Convert.ToInt32(Values.Text); i++)
                    {
                        listBox1.Items.Add(object_int[i]);
                    }
                }
            }
        }

        private void GenerationCollectionCCheckList(object sender, EventArgs e)
        {
            if (Values.Text == string.Empty)
            {
                MessageBox.Show("Проверьте поле!");
            }
            else
            {
                if (Convert.ToInt32(Values.Text) > 5 || Convert.ToInt32(Values.Text) < 0 )
                {
                    MessageBox.Show("Вы ввели неверное значение!");
                }
                else
                {
                    listBox1.Items.Clear();
                    CollectionType<CCheckList> obj_1 = new CollectionType<CCheckList>(5);
                    CCheckList object_1 = new CCheckList(true);
                    CCheckList object_2 = new CCheckList(true);
                    CCheckList object_3 = new CCheckList(false);
                    CCheckList object_4 = new CCheckList(true);
                    CCheckList object_5 = new CCheckList(true);
                    obj_1.Add(object_1);
                    obj_1.Add(object_2);
                    obj_1.Add(object_3);
                    obj_1.Add(object_4);
                    obj_1.Add(object_5);
                    for (int i = 0; i < Convert.ToInt32(Values.Text); i++)
                    {
                        listBox1.Items.Add(obj_1[i].checker);
                    }
                }
            }
        }

        
    
    }
}
