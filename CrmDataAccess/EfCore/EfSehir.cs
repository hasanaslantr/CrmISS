using CrmDataAccess.Abstract;
using CrmDataAccess.Repository;
using CrmEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmDataAccess.EfCore
{
    public class EfSehir: GenericRepository<TblSehir>,ISehir
    {
    }
}
