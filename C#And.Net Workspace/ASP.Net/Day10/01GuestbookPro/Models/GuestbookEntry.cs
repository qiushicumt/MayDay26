using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _01GuestbookPro.Models
{
    public class GuestbookEntry
    {
        public int Id { get; set; }

        [Required(ErrorMessage="用户名是必填项")]
        public string Name { get; set; }

        [Required(ErrorMessage="留言是必填项")]
        public string Message { get; set; }

        public DateTime DateAdded { get; set; }
    }
}