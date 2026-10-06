
using UML1_26_opg2;
Console.WriteLine("----- Opgave 2A -----");


Customer c0 = new Customer("Poul","Gadevej 123","12341234");

Pizza p0 = new Pizza("Classico", "Italiensk pizza med tomat, ost og skinke.", 70.0);
Pizza p1 = new Pizza("Spicy salami", "Pizza med tomat, ost og skinke og pepperoni.", 75.0);
Pizza p2 = new Pizza("Margherita", "Italiensk pizza med tomat og ost.", 80.0);

Console.WriteLine(c0);

Order o0 = new Order(new List<Pizza> { p0, p1 }, true, c0);

o0.AddPizzaToOrder(p2);
o0.RemovePizzaFromOrder(p0);

Console.WriteLine(o0);

