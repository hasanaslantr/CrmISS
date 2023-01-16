using CrmBusiness.Abstract;
using CrmDataAccess.Abstract;
using CrmEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBusiness.Concrete
{
    public class KategoriManger : IKategoriService
    {
        IKategori _KategoriDal;

        public KategoriManger(IKategori kategoriDal)
        {
            _KategoriDal = kategoriDal;
        }

        public void TDelete(TblKategori t) { _KategoriDal.Delete(t); }

        public TblKategori TGetById(int id) { return _KategoriDal.GetById(id); }

        public List<TblKategori> TGetList() { return _KategoriDal.GetList(); }

        public void TInsert(TblKategori t) { _KategoriDal.Insert(t); }

        public void TUpdate(TblKategori t) { _KategoriDal.Update(t); }
    }
}
