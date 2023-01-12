using CrmDataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CrmISS.Controls
{
    public class KategoriController : Controller
    {
        public IActionResult Index()
        {
            CrmDbContext db = new();
            var kategoriler = db.Kategori.ToList();
            return View(kategoriler);
        }
    }
}
