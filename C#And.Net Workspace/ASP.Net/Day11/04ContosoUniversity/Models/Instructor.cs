using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _04ContosoUniversity.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorID { get; set; }

        [DisplayName("LastName")]
        [Required(ErrorMessage="姓是必填项")]
        [StringLength(20, ErrorMessage="姓的长度不能超过20个")]
        public string LastName { get; set; }

        [DisplayName("FirstName")]
        [StringLength(20, ErrorMessage="名字的长度不能超过20个")]
        public string FirstName { get; set; }

        [DisplayName("HireTime")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:yyyy-MM-dd}")]
        public DateTime HireTime { get; set; }

        [DisplayName("FullName")]
        public string FullName {
            get {
                return LastName + ", " + FirstName;
            }
        }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual OfficeAssignment OfficeAssignment { get; set; }
    }
}