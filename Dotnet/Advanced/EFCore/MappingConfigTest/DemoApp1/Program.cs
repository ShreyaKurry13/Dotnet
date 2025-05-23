﻿using DemoApp.Shopping.Data;
using Microsoft.EntityFrameworkCore;

using var shop = new ShopDbContext();
if(args.Length == 0)
{
    var orders = shop.Orders;
    foreach(var customer in shop.Customers)
        Console.WriteLine("{0}\t {1}",customer.Id,customer.Credit);
}
else if(args[0] == "orders")
{
    foreach (var data in shop.Orders)
    {
         Console.WriteLine("{0}\t{1}\t{2:yyyy:MM:dd}",data.ProductId,data.Quantity,data.OrderDate);
    }
}
else 
{
    var customer = shop.Customers
        .Where(c => c.Id == args[0])
        .Include(c => c.Orders)
        .FirstOrDefault();
    if(customer != null)
    {
        foreach (var order in customer.Orders)
        {
            Console.WriteLine("{0}\t{1}\t{2:yyyy:MM:dd}",order.ProductId,order.Quantity,order.OrderDate);
        }
    }
    else
        Console.WriteLine("No such Customer!!");

}


