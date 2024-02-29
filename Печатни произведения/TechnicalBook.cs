using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Печатни_произведения
{

    //клас за технически книги
    public class TechnicalBook:Book
    {
        //поле за техническата сфера на книгата
        public string TechnicalField;

        //списък от нива
        public enum Levels
        {
            Begginer,
            Advanced,
            Expert
        }


        //поле за ниво
        public Levels Level;


        //конструктор
        public TechnicalBook(string title, string language, int year, string author,string technicalfield,Levels level):base(title, language, year, author)
        {
            this.TechnicalField = title;
            this.Level = level;
        }



        //пренаписваме метода Print
        public override string Print()
        {
            return base.Print()+$" - {TechnicalField} - {Level}";
        }
    }
}
