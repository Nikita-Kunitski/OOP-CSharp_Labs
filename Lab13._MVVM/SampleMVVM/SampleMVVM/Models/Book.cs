using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Шаблон MVVM имеет три основных компонента: модель, которая представляет бизнес-логику приложения,
  представление пользовательского интерфейса XAML, и представление-модель, в котором содержится вся логика
  построения графического интерфейса и ссылка на модель, поэтому он выступает в качестве модели для представления.*/

// специальный класс книга который используется для хранения данных !!! в ходе выполнения программы !!!
// то есть мы их используем именно при запуске программы, то есть они из базы загрузятся сюда

namespace SampleMVVM.Models
{
    class Book
    {
        public string Title { get; set; }  // МЫ вызываем это для биндинга, get и set должны обязательно быть!!!
        public string Author { get; set; }
        public int Count { get; set; }

        public Book(string title, string author, int count)
        {
            this.Title = title;
            this.Author = author;
            this.Count = count;
        }
    }
}
