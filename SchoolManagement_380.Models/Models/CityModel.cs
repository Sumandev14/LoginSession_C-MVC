using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Models.Models
{
    public class CityModel
    {
        [Key]
        public int Cityid { get; set; }
        public string CityName { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
    }
}
