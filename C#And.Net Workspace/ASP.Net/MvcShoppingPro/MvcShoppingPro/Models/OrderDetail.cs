using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcShoppingPro.Models
{
    [DisplayName("订单明细")]
    [DisplayColumn("Name")]
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("订单主文件")]
        [Required]
        public OrderHeader OrderHeader { get; set; }

        [DisplayName("订购商品")]
        [Required]
        public Product Product { get; set; }

        [DisplayName("商品售价")]
        [Required]
        [DataType(DataType.Currency)]
        [Description("由于商品价格随时存在变动的可能，需要保存购买时商品的价格")]
        public decimal Price { get; set; }

        [DisplayName("商品数量")]
        [Required]
        public int Amount { get; set; }
    }
}