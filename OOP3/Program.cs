// See https://aka.ms/new-console-template for more information

using OOP3;

ILoanManager carLoanManager = new CarLoanManager();
ILoanManager homeLoanManager = new HomeLoanManager();
ILoanManager requirementLoanManager = new RequirementLoan();

ApplicationManager applicationManager = new ApplicationManager();
applicationManager.Apply(carLoanManager);
applicationManager.Apply(homeLoanManager);
applicationManager.Apply(requirementLoanManager);

