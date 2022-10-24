namespace BankProjectHomework;

public class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerLastName { get; set; }
    public decimal CustomerBalance { get; set; }
    public CustomerStatus CustomerStatus { get; set; }

    public override string ToString()
    {
        return $"{CustomerId} {CustomerName} {CustomerLastName} {CustomerBalance} {CustomerStatus}";
    }
}