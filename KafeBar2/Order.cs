using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeBar2
{
    public class Order
    {
        public String Name { get; set; }
        public bool Sugar { get; set; }
        public bool NoSugar { get; set; }
        public bool Large { get; set; }
        public bool NotLarge { get; set; }
        public bool Hot { get; set; }
        public bool NotHot { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public Order(string name, bool sugar, bool nosugar, bool large, bool notlarge, bool hot, bool nothot, int quantity, int price)
        {
            Name = name;
            Sugar = sugar;
            NoSugar = nosugar;
            Large = large;
            NotLarge = notlarge;
            Hot = hot;
            NotHot = nothot;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {

            return string.Format("{0}- {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}",
                     Name,
                     Sugar ? "Со шеќер" : "",
                     NoSugar ? "Без шеќер" : "",
                     Large ? "Големо" : "",
                     NotLarge ? "Мало" : "",
                     Hot ? "Топло" : "",
                     NotHot ? "Ладно" : "",
                     "Количина:", Quantity.ToString(), "Цена:"
                     , Price.ToString(),
                     "");


        }
    }
}
