using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVCMovie.Models
{
    public class Movie
    {
        //创建一个Movie实体类
        public int ID { get; set; }
        public string MovieName { get; set; }

        //  设置ReleaseDate的显示名称、数据类型和数据格式
        [Display(Name="ReleaseDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-mm-dd}", ApplyFormatInEditMode=true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieDBContext:DbContext           //负责在数据库中处理Movie类的实体
    {
        public DbSet<Movie> Movies { get; set; }
    }
}