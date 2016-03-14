using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcShoppingPro.Models
{
    [DisplayName("订单主文件")]
    [DisplayColumn("DisplayName")]
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("订购会员")]
        [Required]
        public Members Member { get; set; }

        [DisplayName("收件人姓名")]
        [Required(ErrorMessage="请输入收件人姓名")]
        [Description("订购人与收件人有可能不一致")]
        [MaxLength(40, ErrorMessage="收件人姓名不能超过40个字符")]
        public string Name { get; set; }

        [DisplayName("联系电话")]
        [Required(ErrorMessage="请输入联系电话")]
        [MaxLength(25, ErrorMessage="联系电话最长不超过25个字符")]
        public string PhoneNum { get; set; }

        [DisplayName("快递地址")]
        [Required(ErrorMessage="请输入快递地址")]
        public string Address { get; set; }

        [DisplayName("订单金额")]
        [Required]
        [Description("由于订单金额会受到配送以及折扣的影响，所以，必须保留购买当下算出来的金额")]
        [DataType(DataType.Currency)]
        public decimal TotalPrice { get; set; }

        [DisplayName("订购时间")]
        public DateTime OrderTime { get; set; }

        [DisplayName("订单备注")]
        [DataType(DataType.MultilineText)]
        public string Memo { get; set; }

        [NotMapped]
        public string DisplayName { get { return this.Member.Name + "于" + this.OrderTime + "订购的商品"; } }
    }
}