// See https://aka.ms/new-console-template for more information

using OOP1;

var p1 = new Product
{
    Id = 1,
    CategoryId = 1,
    Name = "First Product",
    UnitPrice = 11.22,
    UnitsInStock = 44,
};

var p2 = new Product
{
    Id = 4,
    CategoryId = 44,
    Name = "Another Product",
    UnitPrice = 77.7,
    UnitsInStock = 44
};

var productManager = new ProductManager();
productManager.Add(p2);

var anotherProduct = productManager.FindProduct(66);
if (anotherProduct == null)
{
    Console.WriteLine("Havagi");
}
Console.WriteLine(anotherProduct);
