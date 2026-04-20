using EmployeeAccountGenerator.Core.Applicants;

namespace EmployeeAccountGenerator.Core.AccountGenerators;

public class TrainerAccountGenerator : IAccountGenerator
{
    public Account Create(IApplicant applicant)
    {
        var newAccount = new Account();

        newAccount.FirstName = applicant.FirstName;
        newAccount.LastName = applicant.LastName;

        newAccount.EmailAddress = $"{applicant.FirstName.ToLower()}.{applicant.LastName.ToLower()}@trainer.com";

        newAccount.Role = EmployeeRole.Trainer;

        return newAccount;
    }
}
