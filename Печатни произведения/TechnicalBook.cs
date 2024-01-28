using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Печатни_произведения
{
    public class TechnicalBook:Book
    {
        public string TechnicalField;
        public enum Levels
        {
            Begginer,
            Advanced,
            Expert
        }
        public Levels Level;
        public TechnicalBook(string title, string language, int year, string author,string technicalfield,Levels level):base(title, language, year, author)
        {
            this.TechnicalField = title;
            this.Level = level;
        }
        public override string Print()
        {
            return base.Print()+$" - {TechnicalField} - {Level}";
        }
    }
}
