using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MvcShoppingPro.Models
{
    #region 商品实体类

    [DisplayName("商品信息")]
    [DisplayColumn("Name")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("商品名称")]
        [Required(ErrorMessage="请输入商品名称")]
        [MaxLength(60, ErrorMessage="商品名称不得超过60个字")]
        public string Name { get; set; }

        [DisplayName("商品类别")]
        [Required(ErrorMessage="请选择商品类别")]
        public ProductCategory Category { get; set; }

        [DisplayName("商品简介")]
        [Required(ErrorMessage="请输入商品简介")]
        [MaxLength(300, ErrorMessage="商品简介不得超过300个字")]
        public string Description { get; set; }

        [DisplayName("商品颜色")]
        [Required(ErrorMessage="请选择商品颜色")]
        public Color ProductColor { get; set; }

        [DisplayName("商品售价")]
        [Required(ErrorMessage="请输入商品售价")]
        public decimal Price { get; set; }

        [DisplayName("商品上架时间")]
        [Description("如果不设置上架时间，则代表此商品永不上架")]
        public DateTime PublishOn { get; set; }

    }

    #endregion
    
    #region 商品类别实体类

    [DisplayName("商品类别")]
    [DisplayColumn("Name")]
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("商品类别名称")]
        [Required(ErrorMessage = "请输入商品类别名称")]
        [MaxLength(20, ErrorMessage = "商品类别名称不得超过20个字")]
        public string Name { get; set; }

    }

    #endregion  
}