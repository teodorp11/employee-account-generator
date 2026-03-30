    namespace EmployeeAccountGenerator.Core;

    public class DesignerApplicant : IApplicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccountGenerator AccountGenerator { get; set; } = new DesignerAccountGenerator();
    }
