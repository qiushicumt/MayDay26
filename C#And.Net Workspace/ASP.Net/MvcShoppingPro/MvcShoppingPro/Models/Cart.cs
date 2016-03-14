using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcShoppingPro.Models
{
    [DisplayName("购物车")]
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("选购商品")]
        [Required]
        public Product Product { get; set; }

        [DisplayName("商品数量")]
        [Required]
        public int Amount { get; set; }

    }
}