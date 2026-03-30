using EmployeeAccountGenerator.Core.AccountGenerators;

namespace EmployeeAccountGenerator.Core.Applicants;

public class Applicant : IApplicant
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IAccountGenerator AccountGenerator { get; set; } = new AccountGenerator();
}