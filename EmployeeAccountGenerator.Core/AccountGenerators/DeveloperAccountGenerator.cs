using EmployeeAccountGenerator.Core.Applicants;

namespace EmployeeAccountGenerator.Core.AccountGenerators;

public class DeveloperAccountGenerator : IAccountGenerator
{
    public Account Create(IApplicant applicant)
    {
        Account newEmployee = new Account();

        newEmployee.FirstName = applicant.FirstName;

        newEmployee.LastName = applicant.LastName;

        newEmployee.EmailAddress = $"{applicant.FirstName.ToLower()}.{applicant.LastName.ToLower()}@developer.com";

        newEmployee.Role = EmployeeRole.Developer;

        return newEmployee;
    }
}