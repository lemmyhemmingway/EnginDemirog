namespace BankProjectHomework;

public class CustomerManager
{
    public List<Customer> Customers { get; set; }

    public CustomerManager()
    {
        Customers = new List<Customer>();
    }

    public void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
    }

    public void RemoveCustomer(Customer customer)
    {
        Customers.Remove(customer);
    }

    public void ListCustomers()
    {
        foreach (var customer in Customers)
        {
            Console.WriteLine(customer);
        }
    }
}