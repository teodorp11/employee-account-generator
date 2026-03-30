namespace EmployeeAccountGenerator.Core;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public EmployeeRole Role { get; set; } = EmployeeRole.Developer;
}
