using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Models.Models
{
    public class RegModel
    {
        public int StdId { get; set; }

        [Required(ErrorMessage = "Please Enter your name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter your Registration number")]
        public int? RegNo { get; set; }

        [Required(ErrorMessage = "Please Enter your Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter your Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Enter your valid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter your Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter your Conform Password")]
        [Compare("Password")]
        public string ConFormPassword { get; set; }

    }
}
