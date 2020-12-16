using System.Collections.Generic;

namespace WebPhoneStore.Models.ModelsDTO.ProductsDTO
{
    public class CategoryDto
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public List<BrandDto> Brands { get; set; } = new List<BrandDto>();
    }
}