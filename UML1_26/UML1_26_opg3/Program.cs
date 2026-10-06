
using UML1_26_opg3;
Console.WriteLine("----- Opgave 3A -----");


Customer c0 = new Customer("Poul","Gadevej 123","12341234");

Pizza p0 = new Pizza("Classico", "Italiensk pizza med tomat, ost og skinke.", 70.0,null);
Pizza p1 = new Pizza("Spicy salami", "Pizza med tomat, ost og skinke og pepperoni.", 75.0,null);
Pizza p2 = new Pizza("Margherita", "Italiensk pizza med tomat og ost.", 80.0,"uden ost");

Order o0 = new Order(new List<OrderLine> { new OrderLine(p0) }, true, c0);

o0.AddPizzaToOrder(p2);
o0.AddPizzaToOrder(p2);
o0.AddPizzaToOrder(p2);
o0.RemovePizzaFromOrder(p0);

Console.WriteLine("--- Extra toppings test ---");
Console.WriteLine("before adding topping");
Pizza p4 = new Pizza("Spicy salami", "Pizza med tomat, ost og skinke og pepperoni.", 75.0, null);
Console.WriteLine(p4);
p4.AddTopping(new Topping("Bacon", 5.0));
Console.WriteLine("after adding topping");
Console.WriteLine(p4);



Console.WriteLine("--- Order with multiple of the same pizzas, with comments ---");
Console.WriteLine(o0);

