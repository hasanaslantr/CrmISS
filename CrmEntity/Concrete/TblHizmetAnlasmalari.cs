using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEntity.Concrete
{
    public class TblHizmetAnlasmalari
    {
        [Key]
        public int HizmetAnlasmaId { get; set; }
        public int CariId { get; set; } 
        public int HizmetId { get; set; } 
        public DateTime BaslamaT { get; set; }  
        public DateTime BitisT { get; set; }   
        public string Durum { get; set; } = string.Empty;
        public string OzelKod { get; set; } = string.Empty;
        public string Renk { get; set; } = string.Empty;



    }
}
