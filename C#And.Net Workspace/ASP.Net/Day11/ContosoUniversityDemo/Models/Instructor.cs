using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversityDemo.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorID { get; set; }

        [DisplayName("LastName")]
        [Required(ErrorMessage="LastName是必填选项!")]
        [StringLength(30, ErrorMessage="最大长度不能超过30")]
        public string LastName { get; set; }

        [DisplayName("FirstName")]
        [Required(ErrorMessage="FirstName是必填项")]
        [StringLength(30, ErrorMessage="最大长度不能超过30")]
        public string FirstMidName { get; set; }

        [DisplayName("HireDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:yyyy-MM-dd}")]        
        public DateTime HireDate { get; set; }

        [DisplayName("FullName")]
        public string FullName 
        {
            get { return LastName + ", " + FirstMidName; }
        }

        //  如果一个导航属性可以容纳多个实体，则它的类型必须实现ICollection<T>接口，例如List<T>，但不能是IEnumerable<T>，因为它不实现Add
        public virtual ICollection<Course> Courses { get; set; }        
        public virtual OfficeAssignment OfficeAssignment { get; set; }
    }
}