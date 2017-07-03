using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            
        }
        private List<Tab> list;
        private SqlDataAdapter dataAdapter;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string sql = string.Format("Insert Into Profile" +
                   "(FullName, Date, Phone) Values(@FullName, @Date, @Phone)");

            using (SqlCommand cmd = new SqlCommand(sql, MainWindow.cn))
            {
                // Добавить параметры
                cmd.Parameters.AddWithValue("@FullName", textBox.Text);
                cmd.Parameters.AddWithValue("@Date",date.Text);
                cmd.Parameters.AddWithValue("@Phone", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Учетная запись добавлена!");
          
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            list.Clear();
            dataGrid.ItemsSource = null;
            DataTable inv = new DataTable();
            string sql = "Select * From Profile";
            SqlCommand myCommand = new SqlCommand(sql, MainWindow.cn);
            SqlDataReader dr = myCommand.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Tab((int)dr[0], dr[1].ToString(), dr[2].ToString(), dr[3].ToString()));
            }
            dataGrid.ItemsSource = list;
        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            list = new List<Tab>();
            DataTable inv = new DataTable();
            string sql = "Select * From Profile";
            SqlCommand myCommand = new SqlCommand(sql, MainWindow.cn);
            SqlDataReader dr = myCommand.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Tab((int)dr[0],dr[1].ToString(),dr[2].ToString(), dr[3].ToString()));
            }
            dataGrid.ItemsSource = list;
            dataGrid.CanUserSortColumns = true;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите элемент");
                return;
            }
            else
            {
                Tab obj = dataGrid.SelectedItem as Tab;
                
                 string sql = string.Format("Delete from Profile where ID = '{0}'", obj.ID);
                list.Remove(obj);
                using (SqlCommand cmd = new SqlCommand(sql,MainWindow.cn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Exception error = new Exception("К сожалению, эта машина заказана!", ex);
                        throw error;
                    }
                }
                MessageBox.Show("Элемент удален! Обновите список");
                
            }
        }
    }
}
