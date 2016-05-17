using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [DisplayName("CourseTitle")]
        [StringLength(40, ErrorMessage="课程名称不能超过30个字")]
        [Required(ErrorMessage="课程名称是必填项")]
        public string Title { get; set; }
        
        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}