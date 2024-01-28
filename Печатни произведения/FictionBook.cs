using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Печатни_произведения
{
    public class FictionBook:Book
    {
        public string Jenre;
        public int NumberHeads;
        public FictionBook(string title, string language, int year, string author,string jenre,int numberheads) : base(title, language, year, author)
        {
            Jenre = jenre;
            NumberHeads = numberheads;
        }
        public override string Print()
        {
            return base.Print()+$" - {Jenre} - {NumberHeads}";
        }
    }
}
