using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Views.Employees
{
    public class CreateVM
    {
        public required string Name { get; set; } = string.Empty;
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Invalid e-mail address")]
        public required string Email { get; set; } = string.Empty;
        [Display(Name = "What is 2+2?")]
        [Range(4, 4, ErrorMessage = "You are a bot")]
        public required int BotCheck { get; set; }
    }
}
