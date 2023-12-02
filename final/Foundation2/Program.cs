class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Customer customer1 = new Customer("Finn Martins");
        customer1.SetAddress(new Address("123 Sesame St.", "New York", "NY", "USA"));
        List<Product> o1Products = new List<Product>{
            new Product("Wool Mittens", "Mittens for your kittens.", 5.00m, 2),
            new Product("Step Ladder", "Little ladder to help you reach the top shelf.", 25.00m, 1),
            new Product("Pychic War Elephant", "Are you worthy to comand such a beast?", 5000.00m, 1)
        };

        Order order1 = new Order(customer1, o1Products);
        order1.SetShipping();
        orders.Add(order1);

        Customer customer2 = new Customer("Steven Universe");
        customer2.SetAddress(new Address("1 Temple Way", "Beach City", "United Kingdom", "UK"));
        List<Product> o2Products = new List<Product>{
            new Product("Mr. Queezy", "Fun stuff toy that talks", 10.00m, 1),
            new Product("Cookie Cat", "Icecream sandwitches shaped liek a cat face.", 0.50m, 20),
            new Product("Cheeseburger Backpack", "A backpack that looks liek a cheesburger.", 50.00m, 1)
        };

        Order order2 = new Order(customer2, o2Products);
        order2.SetShipping();
        orders.Add(order2);

        Console.Clear();
        Console.WriteLine("Welcome to Order Central");

        foreach (Order order in orders)
        {
            Console.WriteLine($"\nOrder for: {order.GetCustomer()}");
            Console.WriteLine($"Order Subtotal: ${order.GetSubTotal()}");
            Console.WriteLine($"Order Shipping: ${order.GetShippingCost()}");
            Console.WriteLine($"Order Total:    ${order.GetTotalPrice()}");

            Console.WriteLine("\nPacking List:");
            foreach (string product in order.GetPacking())
            {
                Console.WriteLine($"   {product}");
            }

            Console.WriteLine("\nShipping Label:");
            Console.WriteLine($"{order.GetShipping()}");
            Console.WriteLine("-------------------------------------------------------------------");

        }
    }
}