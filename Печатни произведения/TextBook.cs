using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Печатни_произведения
{

    //клас за учебници
    public class TextBook:Book
    {

        //поле за предмета, по който е учебника
        public string Subject;

        //поле за клас
        public int Grade;



        //конструктор
        public TextBook(string title, string language, int year, string author,string subject,int grade) : base(title, language, year, author)
        {
            Subject = subject;
            Grade = grade;
        }


        //пренаписваме метода Print
        public override string Print()
        {
            return base.Print() + $" - {Subject} - {Grade}";
        }
    }
}
