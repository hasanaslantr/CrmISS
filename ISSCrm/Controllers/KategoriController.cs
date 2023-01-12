using CrmBusiness.Concrete;
using CrmDataAccess.Concrete;
using CrmDataAccess.EfCore;
using CrmEntity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ISSCrm.Controllers
{
    public class KategoriController : Controller
    {
        KategoriManger KategoriManger = new KategoriManger(new EfKategori());
        public IActionResult Index()
        {
            CrmDbContext db = new();
            var kategoriler = db.Kategori.ToList();
            return View(kategoriler);
        }


        [HttpGet]
        public IActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KategoriEkle(TblKategori p)
        {
            KategoriManger.TInsert(p);
            return RedirectToAction("Index");
        }
    }
}
