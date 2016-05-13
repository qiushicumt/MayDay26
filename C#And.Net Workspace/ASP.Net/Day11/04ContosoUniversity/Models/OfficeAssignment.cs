using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _04ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key]
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }

        [DisplayName("Location")]
        [StringLength(50, ErrorMessage="长度不能超过50个")]
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}