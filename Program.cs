using ProductOrderApp.Model;

Product product1 = new Product(1, "Product 1", 10, 10);
Product product2 = new Product(2, "Product 2", 20, 20);

// Order 1 line items
LineItem lineItem1 = new LineItem(1, 2, product1);
LineItem lineItem2 = new LineItem(2, 1, product2);

List<LineItem> order1Items = new List<LineItem>();
order1Items.Add(lineItem1);
order1Items.Add(lineItem2);

Order order1 = new Order(1, DateTime.Now, order1Items);

// Order 2 line items 
LineItem lineItem3 = new LineItem(3, 3, product1);
LineItem lineItem4 = new LineItem(4, 2, product2);

List<LineItem> order2Items = new List<LineItem>();
order2Items.Add(lineItem3);
order2Items.Add(lineItem4);

Order order2 = new Order(2, DateTime.Now, order2Items);

// Add orders to customer
List<Order> orders = new List<Order>();
orders.Add(order1);
orders.Add(order2);

Customer customer = new Customer(1, "Shree", orders);

// Print orders
Console.WriteLine("Customer Id: {0}", customer.Id);
Console.WriteLine("Customer Name: {0}", customer.Name);

Console.WriteLine("Order Count: {0}", customer.Orders.Count);

for (int i = 0; i < customer.Orders.Count; i++)
{
    Order order = customer.Orders[i];

    // Print order details
    Console.WriteLine("Order No: {0}", i + 1);
    Console.WriteLine("Order Id: {0}", order.Id);
    Console.WriteLine("Order Date: {0}", order.Date);
    Console.WriteLine("================================================");

    // Print line items
    foreach (LineItem lineItem in order.Items)
    {
        double discountedPrice = lineItem.Product.CalculateDiscountedPrice();

        Console.WriteLine("Line Item Id: {0}", lineItem.Id);
        Console.WriteLine("Product Id: {0}", lineItem.Product.Id);
        Console.WriteLine("Product Name: {0}", lineItem.Product.Name);
        Console.WriteLine("Quantity: {0}", lineItem.Quantity);
        Console.WriteLine("Unit Price: {0}", lineItem.Product.Price);
        Console.WriteLine("Discount %: {0}", lineItem.Product.DiscountPercent);
        Console.WriteLine("Unit Cost After Discount: {0}", discountedPrice);
        Console.WriteLine("Total Line Item Cost: {0}", lineItem.CalculateLineItemCost());
       
    }

    Console.WriteLine("Order Cost: {0}", order.CalculateOrderPrice());
    Console.WriteLine("================================================");
}
