using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _05Mvc5ContosoUniversity.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }

        [DisplayName("LastName")]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        public string LastName { get; set; }

        [DisplayName("FirstName")]
        [StringLength(50, ErrorMessage="FirstName can not be longer than 50 characters.")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        public string FirstMidName { get; set; }

        [DisplayName("Hire Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime HireDate { get; set; }

        [DisplayName("Full Name")]
        public string FullName 
        {
            get { return LastName + ", " + FirstMidName; }
        }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual OfficeAssignment OfficeAssignment { get; set; }
    }
}