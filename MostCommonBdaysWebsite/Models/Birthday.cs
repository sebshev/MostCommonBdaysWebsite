using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MostCommonBdaysWebsite.Models
{
    public class Birthday
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public int Uniqueness { get; set; }
    }
}
