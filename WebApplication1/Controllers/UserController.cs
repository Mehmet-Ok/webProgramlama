using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using WebApplication1.Entities;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        DatabaseContext db;

        
        public IActionResult Index()
        {

            return View();
        }
    }
}
