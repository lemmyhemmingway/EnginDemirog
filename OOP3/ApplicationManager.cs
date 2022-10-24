namespace OOP3;

public class ApplicationManager
{
    public void Apply(ILoanManager loanManager, ILoggerService loggerService)
    {
        loanManager.Calculate();
        loggerService.Log();
    }

    public void MakeLoanInformation(List<ILoanManager> loanManagers, ILoggerService loggerService)
    {
        foreach (var loanManager in loanManagers)
        {
            loanManager.Calculate();
            loggerService.Log();
        }
    }

}