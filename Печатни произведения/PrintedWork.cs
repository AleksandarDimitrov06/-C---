using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Печатни_произведения
{

    //абстрактен клас за печатно произведение
    public abstract class PrintedWork
    {

        //полета за заглавие и език
        public string Title;
        public string Language;


        //конструктор
        public PrintedWork(string title, string language)
        {
            Title = title;
            Language = language;
        }

        //виртуален метод Print
        public virtual string Print()
        {
            return $"{Title} - {Language}";
        }
    }
}
