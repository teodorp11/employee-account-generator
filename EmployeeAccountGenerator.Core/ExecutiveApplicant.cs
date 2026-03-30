namespace EmployeeAccountGenerator.Core;

public class ExecutiveApplicant : IApplicant
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IAccountGenerator AccountGenerator { get; set; } = new ExecutiveAccountGenerator();
}
