using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEntity.Concrete
{
    public class TblDestekDokuman
    {
        [Key]
        public int DestekDokumanId { get; set; }
        public int DestekId { get; set; }
        public string DokumanYol  { get; set; } =string.Empty;
        public string DokumanTur { get; set; } = string.Empty;
        public DateTime Tarih { get; set; }
    }
}
