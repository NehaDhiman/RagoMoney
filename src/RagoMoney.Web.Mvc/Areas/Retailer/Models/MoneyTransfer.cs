using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RagoMoney.Web.Areas.Retailer.Models
{
    public class MoneyTransfer
    {
        [Required]
        public string RecipientName { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        public string IFSC { get; set; }
    }
}
