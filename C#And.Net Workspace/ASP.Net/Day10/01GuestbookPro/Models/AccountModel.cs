using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _01GuestbookPro.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage="UserName是必填项")]
        public string UserName { get; set; }
        [Required(ErrorMessage="Password是必填项")]
        public string Password { get; set; }
        public string Email { get; set; }
    }
}