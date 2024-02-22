using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Оказион
{
    //клас за реклама
    public abstract class Advertisement
    {
        //поле за активност
        private bool active;

        //свойство за активността
        public bool Active
        {
            get { return this.active;}
            set { this.active = value; } 
        }

        //поле за дата на регистрацията
        private DateTime DateOfRegistration;

        //поле за дата на приключване
        public DateTime EndDate;

        //свойство за датата на регистрацията
        public DateTime Dateofregistration
        {
            get { return this.DateOfRegistration; }
            set
            {
               DateOfRegistration = value;                 
            }
        }

        //поле за продукт
        public readonly Item item;

        //поле за първоначален потребител
        private readonly User User;

        //поле за краен потребител
        public User FinalUser;

        //конструктор
        public Advertisement(bool active, DateTime dateofregistration, Item item, User user)
        {
            Active = active;
            Dateofregistration = dateofregistration;
            this.item = item;
            this.User = user;
        }

        //пренаписваме метода ToString
        public override string ToString()
        {
            if (Active) return $"{item} - {User} - {DateOfRegistration} - {active}";
            else return $"{item} - {User} - {DateOfRegistration} - {active} - {EndDate} - {FinalUser}";
        }

    }
}
