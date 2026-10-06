using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Customer
    {
        //Instance fields
        private string _phoneNumber;
        private string? _adress;

        private string _name;

        //Properties
        public string Adress { get { return _adress; } }


        //Methods

        public Customer(string phoneNumber, string? adress, string name)
        { 
            _adress = adress;
            _phoneNumber = phoneNumber;
            _name = name;
        }

        public override string ToString()
        {
            if (_adress != null)
            {
                return $"Kunde: {_name} :  Telefon: {_phoneNumber} : Adresse: {_adress}";
            }
            return $"Kunde: {_name} : Telefon {_phoneNumber}";
        }
    }
}
