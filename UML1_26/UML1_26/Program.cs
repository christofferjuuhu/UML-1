
using UML1_26;
Console.WriteLine("----- Opgave 1A -----");


Customer c0 = new Customer("Poul","Gadevej 123","12341234");
Customer c1 = new Customer("Peter", "Månen, asteroidevej 23", "zq 55521 A");
Customer c2 = new Customer("Britta", "Vejvej 27", "99999999");

Pizza p0 = new Pizza("Classico", "Italiensk pizza med tomat, ost og skinke.", 70.0);
Pizza p1 = new Pizza("Spicy salami", "Pizza med tomat, ost og skinke og pepperoni.", 75.0);
Pizza p2 = new Pizza("Margherita", "Italiensk pizza med tomat og ost.", 80.0);

Console.WriteLine(c0);
Console.WriteLine(c1);
Console.WriteLine(c2);


Console.WriteLine(p0);
Console.WriteLine(p1);
Console.WriteLine(p2);

Console.WriteLine("----- Opgave 1B -----");

Order o0 = new Order(new List<Pizza> { p0 }, true, c0);
Order o1 = new Order(new List<Pizza> { p1 }, false, c1);
Console.WriteLine(o0);
Console.WriteLine(o1);

Console.WriteLine("----- Opgave 1C, 1D : se pdf -----");



