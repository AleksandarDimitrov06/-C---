using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Печатни_произведения
{
    public abstract class Periodical:PrintedWork
    {
        public string Period;
        public int Frequency;
        public Periodical(string title,string language,int Period_Start,int Period_End,int frequency):base(title, language)
        {
            Period = $"{Period_Start}/{Period_End}";
            Frequency = frequency;
        }
        public override string Print()
        {
            return base.Print() + $" - {Period} - {Frequency}";
        }
    }
}
