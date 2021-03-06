using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TruongTooo.Models
{
    public class Course
    {
      
            public int Id{ get; set; }

            public ApplicationUser Lecture { get; set; }
            [Required]
            public string LectureId { get; set; }
            [Required]
            [StringLength(250)]
            public string Place { get; set; }
            public DateTime DateTime { get; set; }

            public Category Category { get; set; }
            [Required]
            public byte CategoryId { get; set; }
        }


}