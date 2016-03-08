using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _01GuestbookPro.Models
{
    public class AccountContext:DbContext
    {
        public AccountContext() : base("Guestbook") { }
        public DbSet<AccountModel> Accounts { get; set; }
    }
}