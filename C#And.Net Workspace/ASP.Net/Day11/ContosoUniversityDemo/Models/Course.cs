using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversityDemo.Models
{
    public class Course
    {
        /*
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [DisplayName("CourseTitle")]
        [StringLength(40, ErrorMessage = "课程名称不能超过30个字")]
        [Required(ErrorMessage = "课程名称是必填项")]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        */

        //DatabaseGenerated特性，该特性指明主键值将由用户提供，而不是由数据库自动生成
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("编号")]
        [Required(ErrorMessage="课程编号是必填项")]
        public int CourseID { get; set; }

        [DisplayName("CourseTitle")]
        [StringLength(30, ErrorMessage = "课程名称不能超过30个字")]
        [Required(ErrorMessage="课程名称是必填项")]
        public string Title { get; set; }

        [Range(0, 5)]
        [DisplayName("Credit")]
        [Required(ErrorMessage="学分是必填项")]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        [DisplayName("Department")]
        public virtual Department Department { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}