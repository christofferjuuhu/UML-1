
using UML1_26_opg4;
Console.WriteLine("----- Opgave 4A -----");


Customer c0 = new Customer("Poul","Gadevej 123","12341234");
Customer c1 = new Customer("Jørgen", "Vejvej 123", "77777777");

Pizza p0 = new Pizza("Classico", "Italiensk pizza med tomat, ost og skinke.", 70.0,null);
Pizza p1 = new Pizza("Spicy salami", "Pizza med tomat, ost og skinke og pepperoni.", 75.0,null);
Pizza p2 = new Pizza("Margherita", "Italiensk pizza med tomat og ost.", 80.0,"uden ost");

Order o0 = new Order(new List<OrderLine> { new OrderLine(p0) }, true, c0);

o0.AddPizzaToOrder(p2);
o0.AddPizzaToOrder(p2);
o0.AddPizzaToOrder(p2);

Order o1 = new Order(new List<OrderLine> { new OrderLine(p1) }, true, c1);
o1.AddPizzaToOrder(p0);

OrderRepository orderRep = new OrderRepository();
orderRep.AddOrder(o0);
orderRep.AddOrder(o1);


orderRep.PrintAll();




Console.WriteLine("----- Opgave 4B -----");

OrderRepositoryDictionary orderRepDict = new OrderRepositoryDictionary();
orderRepDict.AddOrder(o0);
orderRepDict.AddOrder(o1);
orderRepDict.PrintAll();
