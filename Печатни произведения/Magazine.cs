using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Печатни_произведения
{
    //клас за списания
    public class Magazine:Periodical
    {
        //поле за целевата аудитория на списанието (за какво е)
        public string About;



        //конструктор
        public Magazine(string title, string language, int Start_Period,int End_Period, int frequency,string about) : base(title, language, Start_Period,End_Period, frequency)
        {
            About = about;
        }


        //пренаписваме метода Print
        public override string Print()
        {
            return base.Print()+$" - {About}";
        }
    }
}
