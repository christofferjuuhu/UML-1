using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_26_opg4
{
    public class OrderRepository
    {
        private List<Order> _orders = new List<Order>();

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public Order? SearchOrder(int id)
        {
            foreach (Order o in _orders)
            {
                if (o.Id == id)
                {
                    return o;
                }
            }
            return null;
        }

        public void DeleteOrder(int id)
        {
            Order? order = SearchOrder(id);
            if (order != null)
            {
                _orders.Remove(order);
            }
        }

        public void UpdateOrder(int id, Order updatedOrder)
        {
            Order? existingOrder = SearchOrder(id);
            if (existingOrder == null)
            {
                AddOrder(updatedOrder);
            }
            else {
                DeleteOrder(existingOrder.Id);
                AddOrder(updatedOrder);
            }
        }

        public void PrintAll()
        {
            Console.WriteLine("-----Order Repository: -----");
            foreach (Order o in _orders)
            {
                Console.WriteLine(o.ToString());
            }
        }
    }
}
