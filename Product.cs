using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class Product
    {
        public string Name;
        public string Description;
        public string Manufacturer;
        public int Items;
        public decimal Price;
        public decimal MonthlyInterestRate;

        public void DeductItems(int items)
        {
            if (items != 0)
            {
                Items = Items - items;
            }
            else
            {
                Items--;
            }
        }
    }
}
