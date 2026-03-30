namespace EmployeeAccountGenerator.Core;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public bool IsDeveloper { get; set; } = false;
    public bool IsDesigner { get; set; } = false;
    public bool IsTester { get; set; } = false;
    public bool IsManager { get; set; } = false;
    public bool IsExecutive { get; set; } = false;
}
