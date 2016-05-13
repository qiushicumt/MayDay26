using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _04ContosoUniversity.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }

        [DisplayName("DepartmentName")]
        [Required(ErrorMessage="必填项")]
        [StringLength(50, MinimumLength=3, ErrorMessage="长度不超过50，不能低于3")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Column("money")]
        public decimal Budget { get; set; }

        [DisplayName("StartDate")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:yyyy-MM-dd}")]
        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; }

        public virtual Instructor Administrator { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}