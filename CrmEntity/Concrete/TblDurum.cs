using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEntity.Concrete
{
    public class TblDurum
    {
        [Key]
        public int DurumId { get; set; }
        public string DurumAd { get; set; } = string.Empty;
        public string OzelKod { get; set; } = string.Empty;
        public string Renk { get; set; } = string.Empty;

    }
}
