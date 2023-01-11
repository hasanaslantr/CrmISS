using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEntity.Concrete
{
    public class TblDestekDetayHizmet
    {
        [Key]
        public int DetayHizmetId { get; set; } 
        public int DestekId { get; set; }
        public int PersonelId { get; set; } 
        public string HizmetAdi { get; set; } = string.Empty;
        public double Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Tutar { get; set; } 
        public int Tarih { get; set; } 
    }
}
