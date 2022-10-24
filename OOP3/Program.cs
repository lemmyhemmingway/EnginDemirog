// See https://aka.ms/new-console-template for more information

using OOP3;

ILoanManager carLoanManager = new CarLoanManager();
ILoanManager homeLoanManager = new HomeLoanManager();
ILoanManager requirementLoanManager = new RequirementLoan();
ILoanManager companyLoanManager = new CompanyLoanManager();

ApplicationManager applicationManager = new ApplicationManager();
/*applicationManager.Apply(carLoanManager);
applicationManager.Apply(homeLoanManager);
applicationManager.Apply(requirementLoanManager);*/
ILoggerService loggerService = new DatabaseLoggerService();
ILoggerService smsLoggerService = new SMSLoggerService();



List<ILoanManager> loanManagers = new List<ILoanManager> { carLoanManager, homeLoanManager, requirementLoanManager, companyLoanManager };
applicationManager.MakeLoanInformation(loanManagers, smsLoggerService);
