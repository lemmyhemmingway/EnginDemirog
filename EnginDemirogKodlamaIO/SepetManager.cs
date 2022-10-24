namespace EnginDemirogKodlamaIO;

public class SepetManager
{
    public SepetManager()
    {
        Products = new List<Product>();
    }

    private List<Product> Products { get; set; }
    public void Add(Product product)
    {
        Products.Add(product);
    }

    public int SepetSayisi()
    {
        return Products.Count();
    }

    public void SepetIcerikleriniGoster()
    {
        foreach (var product in Products)
        {
            Console.WriteLine(product);
        }
    }
}