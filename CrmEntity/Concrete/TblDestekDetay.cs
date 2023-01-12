using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEntity.Concrete
{
    public class TblDestekDetay
    {
        [Key]
        public int DetayId { get; set; } 
        public int DestekId { get; set; }
        public int PersonelId { get; set; }
        public DateTime Tarih { get; set; }
        public string DetayIcerik { get; set; } = string.Empty;
    }
}
