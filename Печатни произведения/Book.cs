using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Печатни_произведения
{

    //абстрактен клас за книга
    public abstract class Book : PrintedWork
    {

        //полета за година на издаване и автор
        public int Year;
        public string Author;


        //конструктор
        public Book(string title, string language, int year, string author) : base(title, language)
        {
            Year = year;
            Author = author;
        }


        //пренаписваме метода Print
        public override string Print()
        {
            return base.Print() + $" - {Year} - {Author}";
        }
    }
}
