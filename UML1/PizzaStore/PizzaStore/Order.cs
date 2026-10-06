using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Order
    {
        //constants
        public const double VAT_FACTOR = 1.25;
        public const double DELIVERY_FEE = 40.0;

        //Instance fields
        private List<Pizza> _pizzas = new List<Pizza>();
        private bool _forDelivery;
        private Customer _customer;

        public Order(List<Pizza> pizzas, Customer customer, bool forDelivery)
        {
            _pizzas = pizzas;
            _customer = customer;
            _forDelivery = forDelivery;
            if (customer.Adress == null && forDelivery)
            {
                throw (new Exception("Error: creating an order for delivery, but no adress is specified in the customer"));
            }
        }


        public void AddPizza(Pizza pizza)
        {
            _pizzas.Add(pizza);
        }

        public void RemovePizza(Pizza pizza)
        {
            _pizzas.Remove(pizza);
        }

        public double CalculateTotalPrice()
        {
            if (_pizzas.Count == 0)
            {
                //there is nothing in the order
                return 0.0;
            }

            double totalPrice = 0;
            foreach (Pizza p in _pizzas)
            {
                totalPrice += p.Price;
            }
            // VAT
            totalPrice *= VAT_FACTOR;
            
            //delivery fee
            if (_forDelivery)
            {
                totalPrice += DELIVERY_FEE;
            }
            return totalPrice;
        }

        public void SetDeliveryType(bool newDeliveryType)
        {
            //only allow delivery, if we have an adress
            if (newDeliveryType && _customer.Adress != null)
            {
                _forDelivery = newDeliveryType;
                return;
            }


            if (!newDeliveryType)
            {
                _forDelivery = newDeliveryType;
            }
        }

       
        public void PrintAllOrderInformation()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Odre: ");
            foreach(Pizza p in _pizzas)
            {
                Console.WriteLine(p.ToString());
            }
            
            Console.WriteLine(_customer.ToString());
            if (_forDelivery)
                {
                Console.WriteLine($"til levering: ja, pris: {DELIVERY_FEE} kr");
                }
                else
                {
                Console.WriteLine("til levering: nej");
                }
            Console.WriteLine($"I alt: {CalculateTotalPrice()} kr.");


        }
    }
}
