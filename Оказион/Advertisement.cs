using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Оказион
{
    public abstract class Advertisement
    {
        private bool active;
        public bool Active
        {
            get { return this.active;}
            set { this.active = value; } 
        }
        private DateTime DateOfRegistration;
        public DateTime EndDate;
        public DateTime Dateofregistration
        {
            get { return this.DateOfRegistration; }
            set
            {
               DateOfRegistration = value;                 
            }
        }
        public readonly Item item;
        private readonly User User;
        public User FinalUser;
        public Advertisement(bool active, DateTime dateofregistration, Item item, User user)
        {
            Active = active;
            Dateofregistration = dateofregistration;
            this.item = item;
            this.User = user;
        }
        public override string ToString()
        {
            if (Active) return $"{item} - {User} - {DateOfRegistration} - {active}";
            else return $"{item} - {User} - {DateOfRegistration} - {active} - {EndDate} - {FinalUser}";
        }

    }
}
