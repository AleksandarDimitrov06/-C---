using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Печатни_произведения
{
    public class Newspaper:Periodical
    {
        public enum Types
        {
            News,
            Sport,
            Yellow,
        }
        public Types Type;
        public bool ColorPrint;
        public Newspaper(string title,string language, int period, int frequency,Types type,bool colorprint) :base(title, language, period, frequency)
        {
            Type = type;
            ColorPrint = colorprint;
        }
        public override string Print()
        {
            string a;
            if (ColorPrint) a = "Yes";
            else a = "No";
            return base.Print()+$" - {Type} - Color Print: {a}";
        }
    }
}
