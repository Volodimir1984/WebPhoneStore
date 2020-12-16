using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPhoneStore.Models.ProductsModels
{
    [Table("Products")]
    public class Product
    {
        public  Guid Id { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(250)")]
        public  string Name { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Slug { get; set; }
        
        [Required]
        public Category Category { get; set; }
        
        [Required]
        public Brand Brand { get; set; }
        
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        
        [Column("Percentage discount", TypeName = "smallint")]
        public int? PercentageDiscount { get; set; }
        
        [Column("Short description")]
        public string ShortDescription { get; set; }
        
        public string Description { get; set; }
        
        [Column(TypeName = "json")]
        public string Characteristic { get; set; }
        
        public List<Image> Images { get; set; } = new List<Image>();
    }
}