using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Оказион
{
    //клас за търг
    public class AuctionAdvertisement:Advertisement   //наследява Advertsment 
    {
        //полета за начална цена,крайна цена и дата на приключване
        public readonly double start_price;
        public readonly double end_price;
        public readonly DateTime end_date;


        //конструктор
        public AuctionAdvertisement
            (bool active, DateTime dateofregistration, Item item, User user,double start_price,double end_price,DateTime end_date)
            :base(active, dateofregistration, item, user)
        {
            this.start_price = start_price;
            this.end_price = end_price;
            this.end_date = end_date;
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            return base.ToString()+$" - {start_price} - {end_price} - {end_date}";
        }
    }
}
