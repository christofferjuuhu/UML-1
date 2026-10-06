using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_26_opg3
{
    public class Customer
    {
        //classwide static counter
        private static int idCounter = 1;

        //instance fields
        private int _id;
        private string _name;
        private string _adress;
        private string _telephone;

        //properties
        public string Name { get { return _name; } }

        public string Adress { get { return _adress; } }

        public string Telephone { get { return _telephone; } }

        //constructor
        public Customer(string name, string adress, string telephone)
        { 
            _id= idCounter++;
            _name = name;
            _adress = adress;
            _telephone = telephone;
        }

        public override string ToString()
        {
            return $"Kunde: navn: {_name} : Adresse: {_adress} : Telefon: {_telephone}";
        }

    }
}
