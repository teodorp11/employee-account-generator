using EmployeeAccountGenerator.Core.AccountGenerators;

namespace EmployeeAccountGenerator.Core.Applicants;

public interface IApplicant
{
    string FirstName { get; set; }
    string LastName { get; set; }
    IAccountGenerator AccountGenerator { get; set; }
}