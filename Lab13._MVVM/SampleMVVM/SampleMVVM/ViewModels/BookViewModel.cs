using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SampleMVVM.Models;
using SampleMVVM.Commands;
using System.Windows.Input;

namespace SampleMVVM.ViewModels
{
    class BookViewModel : ViewModelBase
    {
        // модель Book
        public Book Book;

        // конструктор объекта класса BookViewModel ОБЯЗАН принимать в качестве аргумента книгу 
        public BookViewModel(Book book)
        {
            this.Book = book;
        }

        // свойства bookviewmodel передают аргументы в объект класса book
        public string Title
        {
            get { return Book.Title; }
            set 
            {
                Book.Title = value;
                // OnPropertyChanged("Title") - функция, которая принимает в качестве аргумента название изменяемого поля
                // в объекте КНИГА
                OnPropertyChanged("Title");
            }
        }

        public string Author
        {
            get { return Book.Author; }
            set
            {
                Book.Author = value;
                OnPropertyChanged("Author");
            }
        }

        public int Count
        {
            get { return Book.Count; }
            set
            {
                Book.Count = value;
                OnPropertyChanged("Count");
            }
        }

        // #region - инструкция для разбиения кода на фрагменты, которые можно сворачивать минусиком слева
        // то, что написано после региона - название, которое будет написано в свёрнутом виде
        // #endregion - каждый region каждый регион должен им заканчиваться,это конец сворачиваемого проекта
        #region Commands

        #region Забрать

        private DelegateCommand getItemCommand;

        public ICommand GetItemCommand
        {
            get
            {
                if (getItemCommand == null)
                {
                    getItemCommand = new DelegateCommand(GetItem);
                }
                return getItemCommand;
            }
        }

        private void GetItem()
        {
            Count++;
        }

        #endregion

        #region Выдать

        private DelegateCommand giveItemCommand;

        public ICommand GiveItemCommand
        {
            get
            {
                if (giveItemCommand == null)
                {
                    giveItemCommand = new DelegateCommand(GiveItem, CanGiveItem);
                }
                return giveItemCommand;
            }
        }

        private void GiveItem()
        {
            Count--;
        }

        private bool CanGiveItem()
        {
            return Count > 0;
        }

        #endregion

        #endregion
    }
}
