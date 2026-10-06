using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_26_opg2
{
    public class Order
    {
        //classwide static fields
        private static int idCounter=1;
        //constants
        private const double VAT_FACTOR = 1.25;
        private const double DELIVERY_FEE = 40.0;

        //instance fields
        private List<Pizza> _pizzas;
        private bool _forDelivery;

        private Customer _customer;
        private int _id;

        public Order(List<Pizza> pizzas, bool forDelivery, Customer customer)
        {
            _id = idCounter++;
            _pizzas = pizzas;
            _forDelivery = forDelivery;
            _customer   = customer;
        
        }


        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (Pizza p in _pizzas)
            {
                totalPrice += p.Price;
            }

            totalPrice *= VAT_FACTOR;

            if (_forDelivery)
            {
                totalPrice += DELIVERY_FEE;
            }
            return totalPrice;
        }



        public override string ToString()
        {
            string pizzasInfo = "";
            foreach (Pizza p in _pizzas)
            {
                pizzasInfo += p.ToString() + "\n";
            }
            string deliveryInfo = _forDelivery ? $"Til levering: ja, pris {DELIVERY_FEE} kr.": $"Til levering: nej";
            return $"Ordre: {_id} \n {_customer.ToString()} \n {pizzasInfo} \n {deliveryInfo} \n pris i alt (inklusiv moms): {CalculateTotalPrice()}";
        }

        public void AddPizzaToOrder(Pizza pizza)
        {
            _pizzas.Add(pizza);
        }

        public void RemovePizzaFromOrder(Pizza pizza)
        {
            _pizzas.Remove(pizza);
        }
    }
}
