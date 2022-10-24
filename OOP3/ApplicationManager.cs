namespace OOP3;

public class ApplicationManager
{
    public void Apply(ILoanManager loanManager)
    {
        loanManager.Calculate();
    }

}