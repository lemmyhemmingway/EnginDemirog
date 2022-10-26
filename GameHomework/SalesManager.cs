namespace GameHomework;

public class SalesManager
{
    public void GameSale(Customer customer, double price, Campaign campaign)
    {
        if (customer.Balance >= price)
        {
            customer.Balance -= price;
        }
    }
}