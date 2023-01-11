using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEntity.Concrete
{
    public class TblHizmetler
    {
        [Key]
        public int HizmetId { get; set; } 
        public string HizmetAd { get; set; } = string.Empty;
        public string OzelKod { get; set; } = string.Empty;
        public string Renk { get; set; } = string.Empty;

    }
}
