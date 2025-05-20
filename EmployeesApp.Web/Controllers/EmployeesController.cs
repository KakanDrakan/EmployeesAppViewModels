using EmployeesApp.Web.Models;
using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using EmployeesApp.Web.Views.Employees;

namespace EmployeesApp.Web.Controllers
{
    public class EmployeesController : Controller
    {
        static EmployeeService service = new EmployeeService();

        [HttpGet("")]
        public IActionResult Index()
        {
            var viewModel=service.GetAllIndexViewModels();

            return View(viewModel);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(CreateVM viewModel)
        {
            if (!ModelState.IsValid)
                return View();
            
            var employee = new Employee()
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
            };

            service.Add(employee);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            var viewModel = service.GetDetailsViewModel(id);

            return View(viewModel);
        }
    }
}
