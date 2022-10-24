namespace OOP1;

public class ProductManager
{
    public List<Product> Products { get; set; }

    public ProductManager()
    {
        Products = new List<Product>();
    }
    public void Add(Product product)
    {
        Products.Add(product);
    }

    public Product? FindProduct(int productId)
    {
        return Products.Find(s => s.Id == productId);
    }
    
}