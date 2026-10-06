using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Pizza
    {
        //Instance fields
        private string _name;
        private string _description;
        private double _price;

        //properties
        public double Price { get { return _price; } }

        //constructor
        public Pizza(string name, string description, double price)
        {
            _name = name;
            _description = description;
            _price = price;
        }

        //ToString method
        public override string ToString()
        {
            return $"{_name} : {_description} : Pris (før moms): {Price} kr.";
        }
    }
}
