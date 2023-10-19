using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.NewFolder;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {


        private readonly ApplicationContext context;

        public AccountController(ApplicationContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register(User model)
        {
            try
            {
                var result = new User
                {
                    Id = model.Id,
                    Name = model.Name,

                };
                context.Users.Add(result);
                //context.users.update(result);
                //context.savechanges();
                //tempdata["message"] = "employee edited";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public IActionResult Login()
        {
            return View();
        }
    }
}
