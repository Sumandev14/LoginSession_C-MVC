using SchoolManagement_380.Models.DbContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Models.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage ="select Item")]
        public int? ProductId { get; set; }

        [Required(ErrorMessage ="please give Quantity")] 
        public int? Quantityt { get; set; }
        public int? Total { get; set; }
        public int? UserId { get; set; }
        public int? Price { get; set; }

        public virtual Items Items { get; set; }
        public virtual UserName UserName { get; set; }
      
        
    }
}
