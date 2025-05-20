namespace EmployeesApp.Web.Views.Employees
{
    public class DetailsVM
    {
        public required int Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public required string Email { get; set; } = string.Empty;
    }
}
