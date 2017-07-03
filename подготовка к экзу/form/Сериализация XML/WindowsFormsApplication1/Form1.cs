using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            using (Lab10Entities db = new Lab10Entities())
            {
                var table = db.Profiles;
                foreach (var item in table)
                {
                    textBox1.Text += item.ID + " " + item.FullName+'\n';
                }
                Profile[] arr = table.ToArray();
                XmlSerializer formatter = new XmlSerializer(typeof(Profile[]));
                using (FileStream fs = new FileStream("profile.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs,arr);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=UEDECK\SQLEXPRESS;Initial Catalog=Lab10;Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection(str);
            sqlconnection.Open();
            SqlCommand comm = new SqlCommand();
            comm.Connection = sqlconnection;
            comm.CommandText = "SELECT * FROM Profile";

            SqlDataReader res = comm.ExecuteReader();
            while (res.Read())
            {
                textBox1.Text += res[0].ToString() +" "+ res[1].ToString() + "\n";
            }
            sqlconnection.Close();
        }
    }
}
