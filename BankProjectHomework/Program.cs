// See https://aka.ms/new-console-template for more information

using BankProjectHomework;

Console.WriteLine("Hello, World!");
Customer c1 = new Customer
{
    CustomerId = 1, CustomerName = "AAA", CustomerLastName = "BBB", CustomerBalance = 4444,
    CustomerStatus = CustomerStatus.Active
};
Customer c2 = new Customer
{
    CustomerId = 2,
    CustomerName = "BBBBB",
    CustomerLastName = "CCCC",
    CustomerBalance = 4444444,
    CustomerStatus = CustomerStatus.Inactive
};
CustomerManager customerManager = new CustomerManager();
customerManager.AddCustomer(c1);
customerManager.AddCustomer(c2);
customerManager.ListCustomers();