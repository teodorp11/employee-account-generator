using EmployeeAccountGenerator.Core;
using EmployeeAccountGenerator.Core.Applicants;

namespace EmployeeAccountGenerator.ConsoleUI;

class Program
{
    static void Main(string[] args)
    {
        List<IApplicant> applicants = new List<IApplicant>
        {
            new DeveloperApplicant { FirstName = "Ada", LastName = "Lovelace" },
            new DeveloperApplicant { FirstName = "Alan", LastName = "Turing" },
            new DeveloperApplicant { FirstName = "Grace", LastName = "Hopper" },
            new DesignerApplicant { FirstName = "Margaret", LastName = "Hamilton" },
            new ExecutiveApplicant { FirstName = "Charles", LastName = "Babbage" },
            new ManagerApplicant { FirstName = "Claude", LastName = "Shannon" },
            new TesterApplicant { FirstName = "Katherine", LastName = "Johnson" }
        };

        List<Account> employees = new List<Account>();

        foreach (var applicant in applicants)
        {
            employees.Add(applicant.AccountGenerator.Create(applicant));
        }

        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress}");
            Console.WriteLine($"Role: {employee.Role}\n");
        }

        Console.ReadLine();
    }
}
