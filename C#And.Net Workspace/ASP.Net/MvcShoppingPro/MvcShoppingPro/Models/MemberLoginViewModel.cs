using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcShoppingPro.Models
{
    public class MemberLoginViewModel
    {
        [DisplayName("会员帐号")]
        [DataType(DataType.EmailAddress, ErrorMessage="请输入正确的Email地址")]
        [Required(ErrorMessage="请输入{0}")]
        public string Email { get; set; }

        [DisplayName("会员帐号密码")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage="请输入{0}")]
        public string Password { get; set; }
    }
}