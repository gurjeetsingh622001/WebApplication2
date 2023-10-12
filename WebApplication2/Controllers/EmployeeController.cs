using Microsoft.AspNetCore.Mvc;
using WebApplication2.NewFolder;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationContext context;

        public EmployeeController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var result = context.Employees.ToList();
            return View(result);
        }
        
    }
}
