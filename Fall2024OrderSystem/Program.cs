using Fall2024OrderSystem.Data;
using Fall2024OrderSystem.Models;

using StoreContext context = new StoreContext();

//Product meatLovers = new Product()
//{
//    Name = "Meat Lover's Pizza",
//    Price = 9.99M
//};

//context.Products.Add(meatLovers);
//context.SaveChanges();



var products = (from p in context.Products
                select new { ProductName = p.Name }).ToList();

foreach (var p in products)
{
    Console.WriteLine(p.ProductName);
}