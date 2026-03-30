using EmployeeAccountGenerator.Core.Applicants;

namespace EmployeeAccountGenerator.Core.AccountGenerators;

public class DesignerAccountGenerator : IAccountGenerator
{
    public Account Create(IApplicant applicant)
    {
        Account newEmployee = new Account();

        newEmployee.FirstName = applicant.FirstName;

        newEmployee.LastName = applicant.LastName;

        newEmployee.EmailAddress = $"{applicant.FirstName.ToLower()}.{applicant.LastName.ToLower()}@designer.com";

        newEmployee.Role = EmployeeRole.Designer;

        return newEmployee;
    }
}