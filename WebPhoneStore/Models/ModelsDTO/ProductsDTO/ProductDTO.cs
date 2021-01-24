using System.Collections.Generic;

namespace WebPhoneStore.Models.ModelsDTO.ProductsDTO
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Image { get; set; }
        public decimal? Price { get; set; }
        public string ShortDescription { get; set; }
    }
}