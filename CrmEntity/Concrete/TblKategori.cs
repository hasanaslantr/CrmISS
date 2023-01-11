using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEntity.Concrete
{
    public class TblKategori
    {
        [Key]
        public int KategoriId { get; set; }  
        public string KategoriAd { get; set; } = string.Empty;
        public string OzelKod { get; set; } = string.Empty;
        public string Renk { get; set; } = string.Empty;
    }
}
