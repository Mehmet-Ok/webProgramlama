using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize(Roles ="admin")]
    public class AdminController : Controller
    {

		private readonly DatabaseContext _databaseContext;
		public AdminController(DatabaseContext databaseContext)
		{
			_databaseContext = databaseContext;
		}
		public IActionResult Index()
        {
            return View();
        }

		public IActionResult AnaBilimDaliEkle()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AnaBilimDaliEkle(AnaBilimDaliViewModel model)
		{
			if (ModelState.IsValid)
			{
				//var mı yok mu
				bool checkUser = _databaseContext.AnaBilimDalis.Any(u => u.Name.ToLower() == model.Name.ToLower());

				if (checkUser)
				{
					ModelState.AddModelError(nameof(model.Name), " Username  is already exist");
					return View(model);
				}

				//------

				AnaBilimDali anaBilimDali = new()
				{
					Name = model.Name,
				};


				_databaseContext.AnaBilimDalis.Add(anaBilimDali);
				int affectedRowCount = _databaseContext.SaveChanges();

				if (affectedRowCount == 0)
				{
					ModelState.AddModelError("", "User can not be added.");
				}
				else
				{
					return RedirectToAction("Index");
				}
				// is valid 
			}


			return View(model);
		}

		public IActionResult PoliklinikEkle()
		{
			return View();
		}

		[HttpPost]
		public IActionResult PoliklinikEkle(PoliklinikViewModel model)
		{
			if (ModelState.IsValid)
			{
				//var mı yok mu
				bool checkUser = _databaseContext.Polikliniks.Any(u => u.Name.ToLower() == model.Name.ToLower());

				if (checkUser)
				{
					ModelState.AddModelError(nameof(model.Name), " Username  is already exist");
					return View(model);
				}

				//------

				Poliklinik poliklinik = new()
				{
					AnaId=model.AnaId,
					Name = model.Name,
				};


				_databaseContext.Polikliniks.Add(poliklinik);
				int affectedRowCount = _databaseContext.SaveChanges();

				if (affectedRowCount == 0)
				{
					ModelState.AddModelError("", "User can not be added.");
				}
				else
				{
					return RedirectToAction("Index");
				}
				// is valid 
			}


			return View(model);
		}

		public IActionResult DoktorEkle()
		{
			return View();
		}

		[HttpPost]
		public IActionResult DoktorEkle(DoktorViewModel model)
		{
			if (ModelState.IsValid)
			{
				//var mı yok mu
				bool checkUser = _databaseContext.Doktors.Any(u => u.DoktorName.ToLower() == model.DoktorName.ToLower());

				if (checkUser)
				{
					ModelState.AddModelError(nameof(model.DoktorName), " Username  is already exist");
					return View(model);
				}

				//------

				Doktor doktor= new()
				{
					DoktorName = model.DoktorName,
					PoliName = model.PoliName,
				};


				_databaseContext.Doktors.Add(doktor);
				int affectedRowCount = _databaseContext.SaveChanges();

				if (affectedRowCount == 0)
				{
					ModelState.AddModelError("", "Doktor can not be added.");
				}
				else
				{
					return RedirectToAction("Index");
				}
				// is valid 
			}


			return View(model);
		}

		public IActionResult RandevuEkle()
		{
			return View();
		}

		[HttpPost]
		public IActionResult RandevuEkle(RandevuViewModel model)
		{
			if (ModelState.IsValid)
			{
				//var mı yok mu
				//bool checkUser = _databaseContext.Randevus.Any(u => u.Randevu.ToLower() == model.DoktorName.ToLower());

				//if (checkUser)
				//{
				//	ModelState.AddModelError(nameof(model.DoktorName), " Username  is already exist");
				//	return View(model);
				//}

				//------

				Randevu randevu = new()
				{
					RandevuDurum = 0,
					DoktorId = model.DoktorId,
					PoliId = model.PoliId,
					RandevuSaat = model.RandevuSaat,
					RandevuTarih = model.RandevuTarih,
				};


				_databaseContext.Randevus.Add(randevu);
				int affectedRowCount = _databaseContext.SaveChanges();

				if (affectedRowCount == 0)
				{
					ModelState.AddModelError("", "Randevu can not be added.");
				}
				else
				{
					return RedirectToAction("Index");
				}
				// is valid 
			}


			return View(model);
		}
	}
}
