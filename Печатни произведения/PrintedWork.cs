using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Печатни_произведения
{
    public abstract class PrintedWork
    {
        public string Title;
        public string Language;
        public PrintedWork(string title, string language)
        {
            Title = title;
            Language = language;
        }
        public virtual string Print()
        {
            return $"{Title} - {Language}";
        }
    }
}
