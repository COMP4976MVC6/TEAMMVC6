using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamMVC6.Models
{
    public class Option
    {
        public int OptionId { get; set; }

        [Required]
        [MaxLength(50), MinLength(3)]
        public string Title { get; set; }

        public bool IsActive { get; set; }
    }
}
