using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Оказион
{
     public class User
    {
        public readonly string name;
        private List<Advertisement> advertisements;
        private List<Advertisement> wonadvertisements;
        public readonly string password;
        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
            advertisements = new List<Advertisement>();
            wonadvertisements = new List<Advertisement>();
        }
        public void AddAdvertisement(Advertisement advertisement)
        {
            this.advertisements.Add(advertisement);
        }
        public bool CheckPassword(string password)
        {
            if(this.password == password) return true;
            else return false;
        }
        public void ShowAdvertisements()
        {
            if (advertisements.Count == 0) { Console.WriteLine("None"); return; }
            foreach (var a in advertisements) { a.ToString(); }
        }
        public void ShowWonAdvertisements()
        {
            if (wonadvertisements.Count == 0)
            {
                Console.WriteLine("None"); return;
            }
            foreach (var a in wonadvertisements) Console.WriteLine(a.ToString());
        }
        public override string ToString()
        {
            return $"{name} - {password}";
        }

    }
}
