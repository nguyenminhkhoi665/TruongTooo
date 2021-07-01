using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TruongTooo.Models
{
    public class Category
    {
        
            public byte Id { get; set; }
            [Required]
            [StringLength(251)]
            public string Name { get; set; }

        }
    }
