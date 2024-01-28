using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Печатни_произведения
{
    public abstract class Book : PrintedWork
    {
        public int Year;
        public string Author;
        public Book(string title, string language, int year, string author) : base(title, language)
        {
            Year = year;
            Author = author;
        }
        public override string Print()
        {
            return base.Print() + $" - {Year} - {Author}";
        }
    }
}
