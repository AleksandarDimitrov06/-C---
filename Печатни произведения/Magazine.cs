using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Печатни_произведения
{
    public class Magazine:Periodical
    {
        public string About;
        public Magazine(string title, string language, int Start_Period,int End_Period, int frequency,string about) : base(title, language, Start_Period,End_Period, frequency)
        {
            About = about;
        }
        public override string Print()
        {
            return base.Print()+$" - {About}";
        }
    }
}
