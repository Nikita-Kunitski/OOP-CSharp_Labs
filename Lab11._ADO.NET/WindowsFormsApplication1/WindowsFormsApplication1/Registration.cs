using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace WindowsFormsApplication1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void OpenDeposite_Click(object sender, EventArgs e)
        {
            string type=string.Empty;
            if (NameBox.Text == string.Empty &&
               PhoneBox.Text == string.Empty &&
               SerialBox.Text == string.Empty &&
               NumberBox.Text == string.Empty &&
               NumberDepositeBox.Text == string.Empty &&
                (radioButton1.Checked == false ||
                radioButton2.Checked == false ||
                radioButton3.Checked == false ||
                radioButton4.Checked == false))
            {
                MessageBox.Show("Проверьте все поля!");
                return;
            }
            else
            {
                if (NameBox.Text == string.Empty)
                {
                    MessageBox.Show("Заполните поле ФИО!");
                    return;
                }
                if (PhoneBox.Text == string.Empty)
                {
                    MessageBox.Show("Заполните поле Телефон!");
                    return;
                }
                if (SerialBox.Text == string.Empty)
                {
                    MessageBox.Show("Заполните поле Серия паспорта!");
                    return;
                }
                if (NumberBox.Text == string.Empty)
                {
                    MessageBox.Show("Заполните поле Номер паспорта!");
                    return;
                }
                if (NumberDepositeBox.Text == string.Empty)
                {
                    MessageBox.Show("Заполните поле Номер счета!");
                    return;
                }
                if ((radioButton1.Checked == false &&
                        radioButton2.Checked == false &&
                        radioButton3.Checked == false &&
                        radioButton4.Checked == false))
                {
                    MessageBox.Show("Выберите тип депозита");
                    return;
                }

            }
            if (radioButton1.Checked == true)
                type = Convert.ToString(radioButton1.Text);
            if (radioButton2.Checked == true)
                type = Convert.ToString(radioButton2.Text);
            if (radioButton3.Checked == true)
                type = Convert.ToString(radioButton3.Text);
            if (radioButton4.Checked == true)
                type = Convert.ToString(radioButton4.Text);

            Deposite DepositeObject = new Deposite(NumberDepositeBox.Text,Convert.ToString(DateCreateDeposite.Text),type,checkBox1.Checked,checkBox2.Checked);
            Investore InvestoreObject = new Investore(NameBox.Text,PhoneBox.Text, Convert.ToString(BirthDayBox.Text),DepositeObject);
            XmlSerializer formatter = new XmlSerializer(typeof(Investore));
            using (FileStream fs = new FileStream($"{NumberDepositeBox.Text}_Investore.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, InvestoreObject);
                fs.Close();
            }

                MessageBox.Show("Счет открыт!");
            
        }
    }
}
