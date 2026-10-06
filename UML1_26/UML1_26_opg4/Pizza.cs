using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_26_opg4
{
    public class Pizza
    {
        //instance fields
        private string _name;
        private string _description;
        private double _price;
        private string? _comment;

        private List<Topping> _extraToppings = new List<Topping>();

        //properties

        public double Price { get {
                
                if (_extraToppings.Count > 0)
                {
                    double toppingsPrice = 0;
                    foreach (Topping topping in _extraToppings)
                    { 
                    toppingsPrice+= topping.Price;
                    }
                    return _price + toppingsPrice;
                }
                return _price;
            
            } }


        //methods

        public Pizza(string name, string description, double price, string? comment)
        {
            _name = name;
            _description= description;
            _price = price;
            _comment = comment;
        }

        public override string ToString()
        {
            string commentLine = "";
            if (_comment != null)
            {
                commentLine = "kommentar: "+ _comment;
            }

            if (_extraToppings.Count > 0)
            {
                string extraToppingsText = "";
                foreach (Topping topping in _extraToppings)
                {
                    extraToppingsText += topping.ToString() + " : ";
                     
                }
                return $"Pizza: {_name} : {_description} : extra toppings: {extraToppingsText} : pris: {Price} kr. + {commentLine}";
            }
            return $"Pizza: {_name} : {_description} : pris: {Price} kr. {commentLine}";
        }


        public void AddTopping(Topping topping)
        { 
        _extraToppings.Add(topping);
        }

        public void RemoveTopping(Topping topping)
        {
            _extraToppings.Remove(topping);
        }

    }
}
