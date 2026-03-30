using EmployeeAccountGenerator.Core;

namespace EmployeeAccountGenerator.ConsoleUI;

class Program
{
    static void Main(string[] args)
    {
        List<Person> applicants = new List<Person>
        {
            new Person { FirstName = "Ada", LastName = "Lovelace", Role = EmployeeRole.Developer },
            new Person { FirstName = "Alan", LastName = "Turing", Role = EmployeeRole.Developer },
            new Person { FirstName = "Grace", LastName = "Hopper", Role = EmployeeRole.Developer },
            new Person { FirstName = "Margaret", LastName = "Hamilton", Role = EmployeeRole.Manager },
            new Person { FirstName = "Charles", LastName = "Babbage", Role = EmployeeRole.Executive },
            new Person { FirstName = "Claude", LastName = "Shannon", Role = EmployeeRole.Designer },
            new Person { FirstName = "Katherine", LastName = "Johnson", Role = EmployeeRole.Tester }
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
            Console.WriteLine($"IsDeveloper: {emp.IsDeveloper}");
            Console.WriteLine($"IsDesigner: {emp.IsDesigner}");
            Console.WriteLine($"IsTester: {emp.IsTester}");
            Console.WriteLine($"IsManager: {emp.IsManager}");
            Console.WriteLine($"IsExecutive: {emp.IsExecutive}\n");
        }

        Console.ReadLine();
    }
}
