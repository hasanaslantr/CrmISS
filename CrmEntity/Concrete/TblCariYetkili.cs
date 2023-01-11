using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEntity.Concrete
{
    public class TblCariYetkili
    {
        public int YetkiliId { get; set; }
        public int CariId { get; set; }
        public string YetkiliAd { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
        public string Mail { get; set; } = string.Empty;
    }
}
