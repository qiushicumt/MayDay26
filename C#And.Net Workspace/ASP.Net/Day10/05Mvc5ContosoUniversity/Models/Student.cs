using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace _05Mvc5ContosoUniversity.Models
{
    [DisplayName("学生信息")]
    public class Student
    {
        [Key]
        public int Id { get; set; }                 //实体类将使用命名的ID或类名ID作为主键的属性。

        [DisplayName("LastName")]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        public string LastName { get; set; }

        [DisplayName("FirstMidName")]
        [StringLength(50, ErrorMessage = "FirstMidName can not be longer than 50 characters. ")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        public string FirstMidName { get; set; }

        [DisplayName("FullName")]
        public string FullName
        {
            get { return LastName + ", " + FirstMidName; }
        }

        [DisplayName("注册时间")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]    //设置时间格式
        public DateTime EnrollmentDate { get; set; }

        //Enrollments属性是导航属性。导航属性持有此实体相关的其他实体。如果某一给定的Student行在数据库中有两个相关的Enrollment行，该Student实体Enrollments导航属性将包含这两个Enrollment实体。
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}