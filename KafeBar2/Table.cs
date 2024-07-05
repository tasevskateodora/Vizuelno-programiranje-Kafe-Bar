using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeBar2
{
    public class Table
    {
        public List<Order> Orders { get; set; } = new List<Order>();
        public String Name { get; set; }

        public Table(string name)
        {
            Name = name;

        }

        public int totalAmount()
        {
            int sum = 0;
            for (int i = 0; i < Orders.Count; i++)
            {
                sum += Orders[i].Price;
            }
            return sum;
        }

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
