using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

using SampleMVVM.Commands;
using System.Collections.ObjectModel;
using SampleMVVM.Models;

// SampleMVVM.ViewModels - до точки внешнее пространство имён (SampleMVVM), после точки внутреннее пространство имён (ViewModels)
// чтобы выбирать данные из необходимого пространства имён в проекте должна быть указана ссылка на соответствующую библиотеку,
// которая указывается в references
namespace SampleMVVM.ViewModels
{
    class MainViewModel
    {
        public ObservableCollection<BookViewModel> BooksList { get; set; } 

        #region Constructor

        public MainViewModel(List<Book> books)
        {
            BooksList = new ObservableCollection<BookViewModel>(books.Select(b => new BookViewModel(b)));
        }

        #endregion
    }
}
