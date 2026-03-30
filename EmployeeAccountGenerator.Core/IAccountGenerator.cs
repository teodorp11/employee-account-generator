namespace EmployeeAccountGenerator.Core;

public interface IAccountGenerator
{
    Account Create(IApplicant applicant);
}