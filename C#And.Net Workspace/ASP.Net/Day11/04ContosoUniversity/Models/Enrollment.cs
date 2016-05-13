using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _04ContosoUniversity.Models
{
    public enum Grade 
    { 
        A,
        B,
        C,
        D,
        F
    }

    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        [DisplayFormat(NullDisplayText="没有成绩")]             //为空时显示的内容
        public Grade? Grade { get; set; }               //属性后的问号表示这是一个可为空的属性。Null表示一个未知或没有分配的级别

        public virtual Course Course { get; set; }      //导航属性，设置为virtual
        public virtual Student Student { get; set; }    //导航属性，设置为virtual
    }
}