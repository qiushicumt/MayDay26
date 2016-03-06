using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _02PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage="Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage="Please enter your email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage="Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage="Please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage="Please specify your choose")]
        public bool? WillAttend { get; set; }       //bool?表示WillAttend属性是可以为空的bool类型
    }
}