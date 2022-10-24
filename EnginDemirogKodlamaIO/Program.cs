// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using EnginDemirogKodlamaIO;

var product1 = new Product
{
    Adi = "Elma", 
    Aciklama = "aunaeuh", 
    Fiyati = 531351,
    Id = 1
};

var product2 = new Product
{
    Adi = "Armut",
    Aciklama = "Armut",
    Fiyati = 466,
    Id = 2
};

/*
var products = new[] { product1, product2 };
*/

/*
foreach (var product in products)
{
    Console.WriteLine(product.Adi);
}
*/

var s = new SepetManager();
s.Add(product1);
s.Add(product2);
/*
Console.WriteLine(s.SepetSayisi());
*/
/*Console.WriteLine("Hello, World!");*/
s.SepetIcerikleriniGoster();