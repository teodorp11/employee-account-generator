namespace EmployeeAccountGenerator.Core;

public class Account
{
    public Employee Create(Person person)
    {
        Employee newEmployee = new Employee();

        newEmployee.FirstName = person.FirstName;
        newEmployee.LastName = person.LastName;
        newEmployee.EmailAddress = $"{person.FirstName.ToLower()}.{person.LastName.ToLower()}@company.com";

        return newEmployee;
    }
}