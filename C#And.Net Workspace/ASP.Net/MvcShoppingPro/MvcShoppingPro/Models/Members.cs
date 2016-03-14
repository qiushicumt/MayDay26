using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcShoppingPro.Models
{
    [DisplayName("会员信息")]
    [DisplayColumn("Name")]
    public class Members
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("会员帐号")]
        [Description("Email为会员登录账号")]
        [Required(ErrorMessage="请输入Email地址")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("会员帐号密码")]
        [Required(ErrorMessage="请输入会员帐号密码")]
        [MaxLength(40, ErrorMessage="会员帐号密码不得超过40个字符")]
        [Description("密码将以SHA1进行哈希运算，通过哈希运算后得到的结果转为HEX表示的字符长度均为40个字符")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("会员姓名")]
        [Required(ErrorMessage="请输入会员姓名")]
        public string Name { get; set; }

        [DisplayName("会员昵称")]
        [Required(ErrorMessage="请输入会员昵称")]
        [MaxLength(20, ErrorMessage="会员昵称不得超过20个字")]
        public string NickName { get; set; }

        [DisplayName("注册时间")]
        public DateTime RegisterTime { get; set; }

        [DisplayName("会员启用认证码")]
        [MaxLength(36)]
        [Description("当AuthCode等于null，表示会员已经通过Email有效性验证")]
        public string AuthCode { get; set; }
    }
}