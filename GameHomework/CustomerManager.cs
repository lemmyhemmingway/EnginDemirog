namespace GameHomework;

public class CustomerManager
{
    
    
    public bool ControlEdevlet(Customer customer)
    {
        return !string.IsNullOrEmpty(customer.Name) && customer.BirthDate.Year < 2000 && !string.IsNullOrEmpty(customer.IdentityNumber);
    }

    
}