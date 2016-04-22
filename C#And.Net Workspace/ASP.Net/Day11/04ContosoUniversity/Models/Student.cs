using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _04ContosoUniversity.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [DisplayName("LastName")]
        public string LastName { get; set; }

        [DisplayName("FirstMidName")]
        public string FirstMidName { get; set; }

        [DisplayName("EnrollmentDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime EnrollmentDate { get; set; }
        //Enrollments为导航属性，被设置为virtual
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}