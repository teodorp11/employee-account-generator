namespace EmployeeAccountGenerator.Core;

public class Account
{
    public Employee Create(Person person)
    {
        Employee newEmployee = new Employee();

        newEmployee.FirstName = person.FirstName;
        
        newEmployee.LastName = person.LastName;
        
        newEmployee.EmailAddress = $"{person.FirstName.ToLower()}.{person.LastName.ToLower()}@company.com";

        switch (person.Role)
        {
            case EmployeeRole.Developer:
                newEmployee.IsDeveloper = true;
                break;
            case EmployeeRole.Designer:
                newEmployee.IsDesigner = true;
                break;
            case EmployeeRole.Tester:
                newEmployee.IsTester = true;
                break;
            case EmployeeRole.Manager:
                newEmployee.IsManager = true;
                break;
            case EmployeeRole.Executive:
                newEmployee.IsExecutive = true;
                break;
            default:
                break;
        }

        return newEmployee;
    }
}