using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversityDemo.Models
{
    public class OfficeAssignment
    {
        [Key]
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        
        [DisplayName("办公地址")]
        [StringLength(50, ErrorMessage="最大长度不超过50")]
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}