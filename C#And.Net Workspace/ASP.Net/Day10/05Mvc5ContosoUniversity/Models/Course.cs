using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace _05Mvc5ContosoUniversity.Models
{
    [DisplayName("课程信息")]
    public class Course
    {
        //由DatabaseGenerated属性修饰的主键值都是由用户指定的
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Display(Name="Number")]
        public int CourseId { get; set; }

        [DisplayName("课程名称")]
        [StringLength(50, MinimumLength=3)]
        public string Title { get; set; }

        [Range(0,5)]
        public int Credits { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
