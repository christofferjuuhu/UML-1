using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_26_opg3
{
    public class Topping
    {
        //instance fields
        private string _name;
        private double _price;

        public string Name {  get { return _name; } }
        public double Price { get { return _price; } }

        public Topping(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public override string ToString()
        {
            return $"{_name} ({_price} kr.)";
        }
    }
}
