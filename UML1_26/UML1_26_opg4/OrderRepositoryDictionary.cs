using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_26_opg4
{
    public class OrderRepositoryDictionary
    {
        private Dictionary<int,Order> _orders = new Dictionary<int,Order>();

        public void AddOrder(Order order)
        {
            _orders.Add(order.Id,order);
        }

        public Order? SearchOrder(int id)
        {
            if (_orders.ContainsKey(id))
            {
                return _orders[id];
            }
            return null;
        }

        public void DeleteOrder(int id)
        {
            if (_orders.ContainsKey(id))
            {
                _orders.Remove(id);
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
            Console.WriteLine("----- Order Repository (with dictionary): -----");
            foreach (KeyValuePair<int,Order> kvp in _orders)
            {
                Console.WriteLine(kvp.Value.ToString());
            }
        }
    }
}
