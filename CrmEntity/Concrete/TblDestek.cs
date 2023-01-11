using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEntity.Concrete
{
    public class TblDestek
    {
        [Key]
        public int DestekId { get; set; }
        public int KategoriId { get; set; }
        public int CariId { get; set; }
        public int YetkiliId { get; set; }
        public int PersonelId { get; set; }
        public string Konu { get; set; } = string.Empty;
        public string Icerik { get; set; } = string.Empty;
        public string DurumId { get; set; } = string.Empty;
        public DateTime BaslamaT { get; set; }
        public DateTime BaslamaS { get; set; }
        public DateTime KapanisT { get; set; }
        public DateTime KapanisS { get; set; }
        public DateTime PlanlamaT { get; set; }
        public DateTime PlanlamaS { get; set; }
        public string IcerikDetay { get; set; } = string.Empty;
        public string HarcananSure { get; set; } = string.Empty;
        public string SorumluPersonelId { get; set; } = string.Empty;
        public string Zaman { get; set; } = string.Empty; // ACİL YÜKSEK DÜŞÜK 

    }
}
