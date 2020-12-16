using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPhoneStore.Models.ProductsModels
{
    [Table("Brands")]
    public class Brand
    {
        public int Id { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string Name { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string Slug { get; set; }
        
        public  List<Category> Categories { get; set; } = new List<Category>();
        
        public List<Product> Products { get; set; } = new List<Product>();
    }
}