namespace EmployeeAccountGenerator.Core;

public class Account
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }

    public EmployeeRole Role { get; set; }
}
