using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;

public class RandevuController : Controller
{
    private readonly DatabaseContext _context;

    public RandevuController(DatabaseContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var productList = _context.Randevus.ToList();
        return View(productList);
    }
    [HttpPost]
    public IActionResult HandleSelection(List<int> selectedProducts)
    {
        // selectedProducts listesi, seçilen ürünlerin Id'lerini içerecektir.
        // İşlemlerinizi burada gerçekleştirin.

        return RedirectToAction("Index"); // veya başka bir sayfaya yönlendirme yapabilirsiniz.
    }
}
