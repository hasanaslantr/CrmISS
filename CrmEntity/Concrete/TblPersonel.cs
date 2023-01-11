using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEntity.Concrete
{
    public class TblPersonel
    {
        public int PersonelId { get; set; }
        public string PersonelKodu { get; set; } = string.Empty;
        public string PersonelAd { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
        public string Mail { get; set; } = string.Empty;
        public string Sifre { get; set; } = string.Empty;
        public string Resim { get; set; } = string.Empty;
        public string Departman { get; set; } = string.Empty;
    }
}
