using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _04MVCValidateDemo.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage="*为必填项")]
        [StringLength(8, ErrorMessage="用户名长度必须<8")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "*为必填项")]
        [Range(16, 120, ErrorMessage="年龄范围是16~120")]
        [RegularExpression(@"^\d*$", ErrorMessage="年龄必须是数字")]
        public int Age { get; set; }

        [Required(ErrorMessage = "*为必填项")]
        public string UserEmail { get; set; }
    }
}