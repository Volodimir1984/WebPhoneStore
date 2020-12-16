using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebPhoneStore.Models.ModelsDTO.ProductsDTO;
using WebPhoneStore.Models.ProductsModels;


namespace WebPhoneStore.Controllers
{
    [ApiController]
    [Route("products/categories")]
    public class CategoriesController : ControllerBase
    {
        private ProductDataContext _db;

        public CategoriesController(ProductDataContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<CategoriesDto>> Get()
        {
            return new CategoriesDto
            {
                Categories = await _db.Categories.AsNoTracking().Select(i => new CategoryDto
                {
                    Name = i.Name,
                    Slug = i.Slug,
                    Brands = i.Brands.Select(j => new BrandDto()
                    {
                        Name = j.Name,
                        Slug = j.Slug,
                    }).ToList(),
                }).ToListAsync()
            };
        }
    }
}