using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEntity.Concrete
{
    public class TblCari
    {
        [Key]
        public int CariId { get; set; } 
        public string CariKodu { get; set; } = string.Empty;
        public string CariAd { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
        public string Mail { get; set; } = string.Empty;
        public string Il  { get; set; } = string.Empty;
        public string Ilce { get; set; } = string.Empty;
        public string Adres { get; set; } = string.Empty;
        public string Acıklama { get; set; } = string.Empty;
        public string Sifre { get; set; } = string.Empty;
        public string logo { get; set; } = string.Empty;
        public string Renk { get; set; } = string.Empty;
        public string OzelKod { get; set; } = string.Empty;

    }
}
