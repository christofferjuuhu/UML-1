using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_26_opg3
{
    public class Order
    {
        //classwide static fields
        private static int idCounter=1;
        //constants
        private const double VAT_FACTOR = 1.25;
        private const double DELIVERY_FEE = 40.0;

        //instance fields
        private List<OrderLine> _orderItems;
        private bool _forDelivery;

        private Customer _customer;
        private int _id;

        public Order(List<OrderLine> orderitems, bool forDelivery, Customer customer)
        {
            _id = idCounter++;
            _orderItems = orderitems;
            _forDelivery = forDelivery;
            _customer   = customer;
        
        }


        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (OrderLine o in _orderItems)
            {
                totalPrice += o.Item.Price*o.Count;
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
            foreach (OrderLine o in _orderItems)
            {
                pizzasInfo += o.ToString() + "\n";
            }
            string deliveryInfo = _forDelivery ? $"Til levering: ja, pris {DELIVERY_FEE} kr.": $"Til levering: nej";
            return $"Ordre: {_id} \n {_customer.ToString()} \n {pizzasInfo} \n {deliveryInfo} \n pris i alt (inklusiv moms): {CalculateTotalPrice()}";
        }

        public void AddPizzaToOrder(Pizza pizza)
        {
            foreach (OrderLine o in _orderItems)
            {
                if (o.Item == pizza)
                {
                    o.Count++;
                    return;
                }
            }
            OrderLine newOrderLine = new OrderLine(pizza);
            _orderItems.Add(newOrderLine);
        }

        public void RemovePizzaFromOrder(Pizza pizza)
        {
            for(int i=0;i< _orderItems.Count;i++)
            {
                if (_orderItems[i].Item == pizza)
                {
                    if (_orderItems[i].Count > 1)
                    {
                        _orderItems[i].Count -= 1;
                        return;
                    }
                    else {
                        _orderItems.Remove(_orderItems[i]);
                        return;
                    
                    }
                }
            }
        }
    }
}
