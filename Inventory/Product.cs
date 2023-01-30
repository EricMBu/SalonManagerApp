using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Product
    {
        public string _name { get; protected set; }
        public string _description { get; protected  set; }
        public double _price { get; protected set; }

        public Product(string name, string description, double price)
        {
            _name = name;
            _description = description;
            _price = price;
        }

        public void SetName(string name)
        {
            _name = name;
        }
        public void SetDescription(string description)
        {
            _description = description;
        }
        public void SetPrice(double price)
        {
            _price = price;
        }
    }
}
