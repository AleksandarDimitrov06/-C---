using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Печатни_произведения
{

    //клас за вестници
    public class Newspaper:Periodical
    {
        //списък от възможни теми на списанието
        public enum Types
        {
            News,
            Sport,
            Yellow,
        }


        //поле за типа на списанието 
        public Types Type;


        //поле за това дали има цветен печат
        public bool ColorPrint;


        //конструктор
        public Newspaper(string title,string language, int Start_Period,int End_Period, int frequency,Types type,bool colorprint) :base(title, language, Start_Period,End_Period, frequency)
        {
            Type = type;
            ColorPrint = colorprint;
        }



        //пренаписваме метода Print
        public override string Print()
        {
            string Has_Color_Print;
            if (ColorPrint) Has_Color_Print = "Yes";
            else Has_Color_Print = "No";
            return base.Print()+$" - {Type} - Color Print: {Has_Color_Print}";
        }
    }
}
