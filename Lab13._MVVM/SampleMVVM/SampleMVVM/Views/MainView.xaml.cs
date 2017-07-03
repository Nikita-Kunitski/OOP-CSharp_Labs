using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleMVVM.Views
{
    // БИНДИНГ- связывание каких-то переменных и объектов с нашими полями на форме
    // здесь в xaml прописаны все биндинги
    // вот пример <TextBox Text="{Binding Title, UpdateSourceTrigger=PropertyChanged}" Margin="0,0,0,10"/>
    // Title - свойство
    // свойство синтаксический сахарок, то есть это набор из двух функций get и set для установки и чтения значения поля
    // чтобы связать модель книг с представлением используется класс ViewModel или Controller (так называют его по-другому)
    // смотри в папке ViewModels в проекте
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

    }
}
