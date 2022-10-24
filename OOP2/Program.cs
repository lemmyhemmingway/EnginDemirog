// See https://aka.ms/new-console-template for more information

using OOP2;

var customer = new IndividualCustomer
{
    Id = 3,
    CustomerNo = "333",
    IdentityNo = "44444",
    LastName = "Customer 1",
    Name = "Customer 1"
};

var customer2 = new CorporateCustomer
{
    Id = 4,
    CompanyName = "Company Name",
    CustomerNo = "22222",
    TaxNo = "44444444444",
};

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer);

