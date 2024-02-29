using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Печатни_произведения
{

    //клас за справочник
    public class Directory:Periodical
    {

        //поле за темата на справочника
        public string Topic;


        //конструктор
        public Directory(string title, string language, int Period_Start, int Period_End, int frequency,string topic)
            : base(title, language, Period_Start, Period_End, frequency)
        {
            Topic = topic;
        }



        //пренаписваме метода Print
        public override string Print()
        {
            return base.Print()+$" - {Topic}";
        }
    }
}
