using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Оказион
{

    //клас за потребители
     public class User
    {
        //полета за име, списък от публикувани обяви, списък от спечелени обяви и парола
        public readonly string name;
        private List<Advertisement> advertisements;
        private List<Advertisement> wonadvertisements;
        public readonly string password;


        //конструктор
        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
            advertisements = new List<Advertisement>();
            wonadvertisements = new List<Advertisement>();
        }


        //метод за обява на артикул
        public void AddAdvertisement(Advertisement advertisement)
        {
            this.advertisements.Add(advertisement);
        }

        //метод за проверка на паролата
        public bool CheckPassword(string password)
        {
            if(this.password == password) return true;
            else return false;
        }


        //метод за визуализиране на всички обяви на потребителя, които е публикувал
        public void ShowAdvertisements()
        {
            if (advertisements.Count == 0) { Console.WriteLine("None"); return; }
            foreach (var a in advertisements) { a.ToString(); }
        }


        //метод за визуализиране на всички обяви на потребителя, които е спечелил
        public void ShowWonAdvertisements()
        {
            if (wonadvertisements.Count == 0)
            {
                Console.WriteLine("None"); return;
            }
            foreach (var a in wonadvertisements) Console.WriteLine(a.ToString());
        }

        //пренаписваме метода ToString
        public override string ToString()
        {
            return $"{name} - {password}";
        }

    }
}
