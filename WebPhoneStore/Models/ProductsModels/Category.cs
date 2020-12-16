using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPhoneStore.Models.ProductsModels
{
    [Table("Categories")]
    public class Category
    {
        public int Id { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string Name { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string Slug { get; set; }
        
        public List<Brand> Brands { get; set; } = new List<Brand>();
        
        public List<Product> Products { get; set; } = new List<Product>();
    }
}