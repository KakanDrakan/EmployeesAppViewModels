﻿namespace EmployeesApp.Web.Views.Employees
{
    public class IndexVM
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required bool ShowAsHighlighted { get; set; }
    }
}
