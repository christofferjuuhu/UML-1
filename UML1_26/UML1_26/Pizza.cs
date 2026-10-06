using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_26
{
    public class Pizza
    {
        //instance fields
        private string _name;
        private string _description;
        private double _price;

        //properties

        public double Price { get { return _price; } }

        //methods

        public Pizza(string name, string description, double price)
        {
            _name = name;
            _description= description;
            _price = price;
        }

        public override string ToString()
        {
            return $"Pizza: {_name} : {_description} : pris: {Price} kr.";
        }

    }
}
