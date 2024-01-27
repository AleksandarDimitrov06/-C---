using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Адресна_книга
{
    public class AddressEntry
    {
        private string name;
        private string address;
        private int number;
        public AddressEntry(string name, string address, int number)
        {
            this.name = name;
            this.address = address;
            this.number = number;
        }
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
        public override string ToString()
        {
            return $"{Name} - {Address} - {Number}";
        }
        
    }
}
