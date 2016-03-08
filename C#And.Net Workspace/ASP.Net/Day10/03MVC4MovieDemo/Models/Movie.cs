using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _03MVC4MovieDemo.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage="电影名称是必填项")]
        [DisplayName("MovieName")]
        public string Name { get; set; }

        [Required(ErrorMessage="ReleaseDate是必填项")]
        [DisplayName("ReleaseDate")]
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:yyyy-MM-dd}")]
        public DateTime ReleaseTime { get; set; }

        [Required(ErrorMessage="电影类型是必填项")]
        [DisplayName("MovieGenre")]
        public string Genre { get; set; }

        [Required(ErrorMessage="电影价格是必填项")]
        [DisplayName("Price")]
        public decimal Price { get; set; }
    }

    public class MovieContext : DbContext
    {
        public MovieContext() : base("Movies") { }
        public DbSet<Movie> Movies { get; set; }
    }
}