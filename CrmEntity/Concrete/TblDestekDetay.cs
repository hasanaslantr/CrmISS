using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEntity.Concrete
{
    public class TblDestekDetay
    {
        public int DetayId { get; set; } 
        public int DestekId { get; set; }
        public int PersonelId { get; set; }
        public DateTime Tarih { get; set; }
        public string DetayIcerik { get; set; } = string.Empty;
    }
}
