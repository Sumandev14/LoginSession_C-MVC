using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Models.Models
{
    public class CoupenModel
    {
        public int CouponICoded { get; set; }
        public string Code { get; set; }
        public int? Type { get; set; }
        public System.DateTime? Expirydate { get; set; }
        public int? UsageLimit { get; set; }
        public bool? IsActive { get; set; }
        public decimal? DiscountAmount { get; set; }
    }
}
