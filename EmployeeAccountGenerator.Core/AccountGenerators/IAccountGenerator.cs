using EmployeeAccountGenerator.Core.Applicants;

namespace EmployeeAccountGenerator.Core.AccountGenerators;

public interface IAccountGenerator
{
    Account Create(IApplicant applicant);
}