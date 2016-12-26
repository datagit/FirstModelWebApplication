using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace FirstModelWebApplication.Models {
    public class Movie {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }
                
        //default required for validation for data type is DateTime
        public DateTime? ReleaseDate { get; set; }
        public string Genre { get; set; }

        //default required for validation for data type is Number
        public decimal? Price { get; set; }
    }

    public class MovieDBContext : DbContext {
        public DbSet<Movie> Movies { get; set; }
    }
}