using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPhoneStore.Models.ProductsModels
{
    [Table("Images")]
    public class Image
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Slug { get; set; }
        public Product Product { get; set; }
    }
}