using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEntity.Concrete
{
    public class TblSehir
    {
        [Key]
        public int SehirId { get; set; }
        public string SehirAd { get; set; } = string.Empty;

    }
}
