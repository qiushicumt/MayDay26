using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _04ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]       //设置主键为可编辑
        [DisplayName("CourseID")]
        public int CourseId { get; set; }

        [DisplayName("Title")]
        [MaxLength(50, ErrorMessage="长度不能超过50"), MinLength(3, ErrorMessage="长度最小为3")]
        [Required(ErrorMessage="必填项")]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}