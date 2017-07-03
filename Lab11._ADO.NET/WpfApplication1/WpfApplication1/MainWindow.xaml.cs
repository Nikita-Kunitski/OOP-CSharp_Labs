using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowsNavigationUI = false;
        }
        static public SqlConnection cn = new SqlConnection();
        private void NavigationWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
            cn.ConnectionString = @"Data Source=UEDECK\SQLEXPRESS;Initial Catalog=Lab10;" +
          "Integrated Security=SSPI;Pooling=False";
            cn.Open();
            
               
        }

        private void NavigationWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            cn.Close();
        }
    }
}
