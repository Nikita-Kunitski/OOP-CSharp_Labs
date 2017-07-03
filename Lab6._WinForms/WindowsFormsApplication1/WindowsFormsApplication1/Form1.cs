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
    public partial class Calculate : Form
    {
        public Calculate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String_1.Text.ToString() == string.Empty && String_2.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                if (Equals(String_1.Text.ToString(), String_2.Text.ToString()))
                    MessageBox.Show("Строки эквивалентны!");
                else
                {
                    if (String_1.TextLength > String_2.TextLength)
                        MessageBox.Show("Строка №1 больше Строка №2");
                    if(String_1.TextLength < String_2.TextLength)
                        MessageBox.Show("Строка №2 больше Строка №1");
                }
            }
        }

        private void ShiftToRight(object sender, EventArgs e)
        {
            if (String_.Text == string.Empty)
                MessageBox.Show("Введите значение!");

                    else
                    {
                        Int64 shift_to_right = Convert.ToInt64(String_.Text);
                        String_result.Text = Convert.ToString(shift_to_right >> 1);
                    }
        }

        private void ShiftToLeft(object sender, EventArgs e)
        {
            if (String_.Text == string.Empty)
                MessageBox.Show("Введите значение!");
            else
            {
                Int64 shift_to_left = Convert.ToInt64(String_.Text);
                String_result.Text = Convert.ToString(shift_to_left << 1);
            }
        }

        private void ClearComparison(object sender, EventArgs e)
        {
            String_1.Clear();
            String_2.Clear();
        }

        private void ClearShift(object sender, EventArgs e)
        {
            String_.Clear();
            String_result.Clear();
        }

        private void ClearAll(object sender, EventArgs e)
        {
            String_1.Clear();
            String_2.Clear();
            String_.Clear();
            String_result.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LINQ form = new LINQ();
            form.Show();
            
        }
    }
}
