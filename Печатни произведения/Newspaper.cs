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
        public Newspaper(string title,string language, int Start_Period,int End_Period, int frequency,Types type,bool colorprint) :base(title, language, Start_Period,End_Period, frequency)
        {
            Type = type;
            ColorPrint = colorprint;
        }
        public override string Print()
        {
            string Has_Color_Print;
            if (ColorPrint) Has_Color_Print = "Yes";
            else Has_Color_Print = "No";
            return base.Print()+$" - {Type} - Color Print: {Has_Color_Print}";
        }
    }
}
