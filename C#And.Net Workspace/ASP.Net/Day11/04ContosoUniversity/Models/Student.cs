using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _04ContosoUniversity.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [DisplayName("LastName")]
        [StringLength(50, ErrorMessage="名字的长度不能超过50")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required(ErrorMessage="姓不能为空")]
        public string LastName { get; set; }

        [DisplayName("FirstMidName")]
        [StringLength(50, ErrorMessage="名字的长度不能超过50")]
        [Required(ErrorMessage="名字不能为空")]
        [Column("FirstName")]
        public string FirstMidName { get; set; }

        [DisplayName("EnrollmentDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime EnrollmentDate { get; set; }
        
        [DisplayName("FullName")]
        public string FullName { get { return LastName + ", " + FirstMidName; } }

        //Enrollments为导航属性，被设置为virtual
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}