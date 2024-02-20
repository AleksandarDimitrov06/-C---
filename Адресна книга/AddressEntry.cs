using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Адресна_книга
{
    //създаваме клас на име AddressEntry
    public class AddressEntry
    {
        //създаваме полета име,адрес и номер
        private string name;
        private string address;
        private int number;

        //правим конструктор
        public AddressEntry(string name, string address, int number)
        {
            this.name = name;
            this.address = address;
            this.number = number;
        }

        //правим свойства за трите полета
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        //пренаписваме метода ToString
        public override string ToString()
        {
            return $"{Name} - {Address} - {Number}";
        }
        
    }
}
