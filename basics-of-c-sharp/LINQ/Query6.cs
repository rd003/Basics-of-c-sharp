using Microsoft.VisualBasic;

public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
}

public class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
}
public class Query6
{
    static List<Customer> customers = new List<Customer>
    {
            new Customer {CustomerId=1,CustomerName="Alice" },
            new Customer { CustomerId = 2, CustomerName = "Bob" },
            new Customer { CustomerId = 3, CustomerName = "Charlie" }
    };

    static List<Order> orders = new List<Order>
    {
            new Order { OrderId = 1, CustomerId = 1, OrderDate = DateTime.Parse("2024-04-15"), TotalAmount = 100.50m },
            new Order { OrderId = 2, CustomerId = 2, OrderDate = DateTime.Parse("2024-04-20"), TotalAmount = 150.75m },
            new Order { OrderId = 3, CustomerId = 1, OrderDate = DateTime.Parse("2024-05-01"), TotalAmount = 75.25m },
            new Order { OrderId = 4, CustomerId = 2, OrderDate = DateTime.Parse("2024-05-05"), TotalAmount = 200.00m },
            new Order { OrderId = 5, CustomerId = 3, OrderDate = DateTime.Parse("2024-05-10"), TotalAmount = 300.00m }
    };

    // Get the top 3 customers who spent the most in the past month
    public static void Execute()
    {
        var data = (from customer in customers
                    join order in orders
                    on customer.CustomerId equals order.OrderId
                    where order.OrderDate == DateTime.Now.AddMonths(-1)
                    group order by order.CustomerId into groupedOrder
                    select new
                    {
                        Key = groupedOrder.Key,
                        TotalSpent = groupedOrder.Sum(g => g.TotalAmount)
                    }).OrderByDescending(a => a.TotalSpent);
        foreach (var customer in data)
        {
            Console.WriteLine($"{customer.Key}: {customer.TotalSpent}");
        }

    }

}