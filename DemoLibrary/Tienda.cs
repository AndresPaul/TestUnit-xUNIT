using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    public class Product
    {
        private string _name;
        private double _price;
        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }
        public string GetName()
        {
            return _name;
        }

        public double GetPrice()
        {
            return _price;
        }

        public double GetTotal(double cantidad)
        {
            return _price * cantidad;
        }
    }

}
