//Classer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using checkpiont_2_004;



namespace checkpiont_2_004
{
    internal class Inventory
    {
        // Properties of the Product class

        public string Category { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Inventory(string category, string name, double price)
        {
            Category = category;
            Name = name;
            Price = price;
        }

    }
}
