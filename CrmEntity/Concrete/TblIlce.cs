using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEntity.Concrete
{
    public class TblIlce
    {
        [Key]
        public int IlceId { get; set; } 
        public int SehirID { get; set; } 
        public string IlceAd { get; set; }  = string.Empty;

    }
}
