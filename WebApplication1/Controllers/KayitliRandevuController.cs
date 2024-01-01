using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize(Roles = "user")]
    public class KayitliRandevuController : Controller
    {
        private readonly DatabaseContext _context;
        public IActionResult Index()
        {
            return View();
        }
        public KayitliRandevuController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult RandevuKayit()
        {
            var productList = _context.Randevus.ToList();

            return View(productList);
        }
        [HttpPost]
        public IActionResult RandevuKayitEkle(Randevu model) {

            // return model.RandevuId.ToString();
            if (ModelState.IsValid)
            {
             

                var userIdClaim = User.FindFirst("Id");
                int _userId = userIdClaim != null ? Convert.ToInt32(userIdClaim.Value) : 0; // veya başka bir varsayılan değer

                //------

                KayitliRandevu kayitliRandevu = new()
                {
                    RandevuId = model.RandevuId,
                    UserId = _userId,
                };


                _context.KayitliRandevus.Add(kayitliRandevu);
                int affectedRowCount = _context.SaveChanges();

                if (affectedRowCount == 0)
                {
                    ModelState.AddModelError("", "User can not be added.");
                }
                else
                {
                    return RedirectToAction("Index");
                }
                 
            }

            return RedirectToAction("RandevuKayit");
        }



        public string deneme(int id)
        {

            return User.FindFirst("Username").Value;
        }
    }
}
