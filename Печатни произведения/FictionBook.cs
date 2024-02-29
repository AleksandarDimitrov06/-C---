using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Печатни_произведения
{
    //клас за художествени книги
    public class FictionBook:Book
    {

        //полета за жанра на книгата и броя на главите в нея
        public string Jenre;
        public int NumberHeads;


        //конструктор
        public FictionBook(string title, string language, int year, string author,string jenre,int numberheads) : base(title, language, year, author)
        {
            Jenre = jenre;
            NumberHeads = numberheads;
        }


        //пренаписваме метода Print
        public override string Print()
        {
            return base.Print()+$" - {Jenre} - {NumberHeads}";
        }
    }
}
