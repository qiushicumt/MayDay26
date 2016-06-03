using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversityDemo.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [DisplayName("LastName")]
        [Required(ErrorMessage = "姓氏是必填项")]
        [StringLength(30, ErrorMessage = "姓氏的最大长度不能超过30")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string LastName { get; set; }

        [DisplayName("FirstName")]
        [Required(ErrorMessage = "名字是必填项")]
        [StringLength(30, ErrorMessage = "名字的最大长度不能超过30")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string FirstMidName { get; set; }

        [DisplayName("EnrollmentDate")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime EnrollmentDate { get; set; }

        [DisplayName("FullName")]
        public string FullName 
        {
            get { return LastName + ", " + FirstMidName; }
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}