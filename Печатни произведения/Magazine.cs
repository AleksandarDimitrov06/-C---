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
        public Magazine(string title, string language, int period, int frequency,string about) : base(title, language, period, frequency)
        {
            About = about;
        }
        public override string Print()
        {
            return base.Print()+$" - {About}";
        }
    }
}
