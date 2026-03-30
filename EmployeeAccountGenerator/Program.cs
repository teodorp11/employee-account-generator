using EmployeeAccountGenerator.Core;

namespace EmployeeAccountGenerator.ConsoleUI;

class Program
{
    static void Main(string[] args)
    {
        List<Person> applicants = new List<Person>
        {
            new Person { FirstName = "Ada", LastName = "Lovelace" },
            new Person { FirstName = "Alan", LastName = "Turing" },
            new Person { FirstName = "Grace", LastName = "Hopper" },
            new Person { FirstName = "Charles", LastName = "Babbage" },
            new Person { FirstName = "Margaret", LastName = "Hamilton" },
            new Person { FirstName = "Claude", LastName = "Shannon" },
            new Person { FirstName = "Katherine", LastName = "Johnson" }
        };

        List<Employee> employees = new List<Employee>();

        Account accountProcessor = new Account();

        foreach (var person in applicants)
        {
            employees.Add(accountProcessor.Create(person));
        }

        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress}");
            Console.WriteLine($"IsManager: { emp.IsManager}");
            Console.WriteLine($"IsExecutive: { emp.IsExecutive}\n");
        }

        Console.ReadLine();
    }
}
