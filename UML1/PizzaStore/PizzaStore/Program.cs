//// Pizza Store

using PizzaStore;

//creation of 3 customer instances

Customer c0 = new Customer("123123123", "gadevej 123", "Poul");
Customer c1 = new Customer("88888888", "vejgade 312", "Mikkel");
Customer c2 = new Customer("44444444", null, "Kurt og Britta nede fra hjørnet");

//creation of 3 pizza objects

Pizza p0 = new Pizza("Classico","Italiensk pizza med tomat, skinke og ost",70.0);
Pizza p1 = new Pizza("Spicy Mamma mia", "Pizza med tomat, ost, kebab og spicy jalepenos", 75.0);
Pizza p2 = new Pizza("Bianca", "Hvid pizza med kartoffel, bacon og rosmarin", 75.0);

//order objects

Order o0 = new Order(new List<Pizza> { p0}, c0, true);
Order o1 = new Order(new List<Pizza> { p1 }, c1, true);
Order o2 = new Order(new List<Pizza> { p2 }, c2, false);

//print order information

o0.PrintAllOrderInformation();
o1.PrintAllOrderInformation();
o2.PrintAllOrderInformation();