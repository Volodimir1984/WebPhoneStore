﻿using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebPhoneStore.Models.ModelsDTO.ProductsDTO;
using WebPhoneStore.Models.ProductsModels;

namespace WebPhoneStore.Controllers
{
    [ApiController]
    [Route("products")]
    public class GetProductController: ControllerBase
    {
        private ProductDataContext _db;

        public GetProductController(ProductDataContext db)
        {
            _db = db;
        }
        
        [HttpGet("{category}")]
        public async Task<ActionResult<ProductsDTO>> Get(string category)
        {
            if (_db.Categories.Any(i => i.Slug.Contains(category)))
            {
                return new ProductsDTO
                {
                    Products = await _db.Products.AsNoTracking().Include(i => i.Category)
                        .Where(i => i.Category.Slug.Contains(category))
                        .Select(i => new ProductDTO
                        {
                            Name = i.Name,
                            Slug = i.Slug,
                            Image = i.Images.FirstOrDefault().Slug,
                            Price = i.Price,
                            ShortDescription = i.ShortDescription,
                        }).ToListAsync(),
                };
            }

            return new ProductsDTO();
        }

        [HttpGet("{category}/{brand}")]
        public async Task<ActionResult<ProductsDTO>> Get(string category, string brand)
        {
            if (_db.Categories.Any(i => i.Slug.Contains(category)) && _db.Brands.Any(i => i.Slug.Contains(brand)))
            {
                return new ProductsDTO
                {
                    Products = await _db.Products.AsNoTracking().Include(i => i.Category)
                        .ThenInclude(i => i.Brands)
                        .Where(i => i.Category.Slug.Contains(category) && i.Brand.Slug.Contains(brand))
                        .Select(i => new ProductDTO
                        {
                            Name = i.Name,
                            Slug = i.Slug,
                            Image = i.Images.FirstOrDefault().Slug,
                            Price = i.Price,
                            ShortDescription = i.ShortDescription,
                        }).ToListAsync(),
                };
            }

            return new ProductsDTO();
        }
    }
}