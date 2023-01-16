using CrmBusiness.Concrete;
using CrmBusiness.FluentValidation;
using CrmDataAccess.Concrete;
using CrmDataAccess.EfCore;
using CrmEntity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ISSCrm.Controllers
{
    public class KategoriController : Controller
    {
        KategoriManger _KategoriManger = new KategoriManger(new EfKategori());
        public IActionResult Index()
        {
            var values = _KategoriManger.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KategoriEkle(TblKategori p)
        {
            KategoriValidator validationrules = new KategoriValidator();
            ValidationResult result = validationrules.Validate(p);
            if (result.IsValid)
            {
                _KategoriManger.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult KategoriSil(int id)
        {
            var values = _KategoriManger.TGetById(id);
            _KategoriManger.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult KategoriGuncelle(int id)
        {
            var values = _KategoriManger.TGetById(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult KategoriGuncelle(TblKategori p)
        { 
            KategoriValidator validationrules = new KategoriValidator();
            ValidationResult result = validationrules.Validate(p);
            if (result.IsValid)
            {
                _KategoriManger.TUpdate(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
