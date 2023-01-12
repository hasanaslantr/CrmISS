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
        IKategori _Kategori;
        public KategoriManger(IKategori KategoriDal)
        {
            _Kategori = KategoriDal;
        }

        public void TDelete(TblKategori t)
        {
            _Kategori.Delete(t);
        }

        public TblKategori TGetById(int id)
        {
            return _Kategori.GetById(id);
        }

        public List<TblKategori> TGetList()
        {
           // return _Kategori.GetList();
           throw new NotImplementedException();
        }

       

        public void TInsert(TblKategori t)
        {
            _Kategori.Insert(t);
        }

        public void TUpdate(TblKategori t)
        {
            _Kategori.Update(t);
        }
    }
}
