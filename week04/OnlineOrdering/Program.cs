using System;

class Program
{
    static void Main()
    {
        // ----- ORDER 1 -----
        Address a1 = new Address("123 Maple St", "Denver", "CO", "USA");
        Customer c1 = new Customer("John Smith", a1);
        Order order1 = new Order(c1);

        order1.AddProduct(new Product("Laptop", "LT100", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MS200", 25.50, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
        Console.WriteLine("----------------------------------");

        // ----- ORDER 2 -----
        Address a2 = new Address("88 West Ave", "Toronto", "ON", "Canada");
        Customer c2 = new Customer("Maria Fernandez", a2);
        Order order2 = new Order(c2);

        order2.AddProduct(new Product("Desk Lamp", "DL300", 40.00, 1));
        order2.AddProduct(new Product("Notebook", "NB110", 5.99, 3));
        order2.AddProduct(new Product("Pen Set", "PN550", 12.49, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
    }
}
