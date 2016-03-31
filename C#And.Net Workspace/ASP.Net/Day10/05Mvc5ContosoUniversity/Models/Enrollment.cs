using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _05Mvc5ContosoUniversity.Models
{
    public enum Grade
    {
        A,
        B,
        C,
        D,
        F
    }

    [DisplayName("注册信息")]
    public class Enrollment
    {
        [Key]
        public int EnrollId { get; set; }

        public int CourseId { get; set; }
        public int StudentId { get; set; }

        [DisplayFormat(NullDisplayText="No grade")]
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}