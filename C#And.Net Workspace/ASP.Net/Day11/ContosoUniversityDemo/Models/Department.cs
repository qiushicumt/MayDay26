using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversityDemo.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [Required(ErrorMessage="名称是必填项")]
        [StringLength(30, ErrorMessage="名称长度不能超过30")]
        public string Name { get; set; }

        [Column(TypeName="money")]
        [DataType(DataType.Currency)]
        public Decimal Budget { get; set; }

        [DisplayName("StartDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:yyyy-MM-dd}")]
        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; }

        public virtual Instructor Administrator { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}