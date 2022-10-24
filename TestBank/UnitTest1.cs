using BankProjectHomework;

namespace TestBank;

public class Tests
{
    public CustomerManager CustomerManager { get; set; }

    [SetUp]
    public void Setup()
    {
        CustomerManager = new CustomerManager();
    }

    [Test]
    public void CustomerManagerShouldHaveEmptyList()
    {
    }
}