using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Печатни_произведения
{

    //клас за периодични издания
    public abstract class Periodical:PrintedWork
    {

        //полета за период на издаване и честота на издаването
        public string Period;
        public int Frequency;


        //конструктор
        public Periodical(string title,string language,int Period_Start,int Period_End,int frequency):base(title, language)
        {
            Period = $"{Period_Start}/{Period_End}";
            Frequency = frequency;
        }



        //пренаписваме метода Print
        public override string Print()
        {
            return base.Print() + $" - {Period} - {Frequency}";
        }
    }
}
