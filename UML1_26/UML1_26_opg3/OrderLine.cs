using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_26_opg3
{
    public class OrderLine
    {

        public Pizza Item{ get; set; }
        public int Count { get; set; }
        public OrderLine(Pizza pizza, int count)
        { 
            Item = pizza;
            Count = count;
        }

        //constructor for default 1 pizza
        public OrderLine(Pizza pizza)
        {
            Item = pizza;
            Count = 1;
        }

        public override string ToString()
        {
            return $"{Item.ToString()} : antal: {Count}";
        }

    }
}
