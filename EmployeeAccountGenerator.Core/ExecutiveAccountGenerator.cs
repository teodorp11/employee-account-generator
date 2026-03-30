namespace EmployeeAccountGenerator.Core;

public class ExecutiveAccountGenerator : IAccountGenerator
{
    public Account Create(IApplicant applicant)
    {
        Account newEmployee = new Account();

        newEmployee.FirstName = applicant.FirstName;

        newEmployee.LastName = applicant.LastName;

        newEmployee.EmailAddress = $"{applicant.FirstName.ToLower()}.{applicant.LastName.ToLower()}@company.com";

        newEmployee.Role = EmployeeRole.Executive;

        return newEmployee;
    }
}