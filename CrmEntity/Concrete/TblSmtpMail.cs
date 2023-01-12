using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEntity.Concrete
{
    public class TblSmtpMail
    {
        [Key]
        public int SmtpMailId { get; set; }
        public string SmtpHost { get; set; } = string.Empty;              
        public int SmtpPort { get; set; }
        public string SmtpSecuritiy { get; set; } = string.Empty;
        public string SmtpMail { get; set; } = string.Empty;
        public string SmtpParola { get; set; } = string.Empty;
        public string SmtpBaslik { get; set; } = string.Empty;
        public string SmtpHelpLink { get; set; } = string.Empty; 

    }
}
