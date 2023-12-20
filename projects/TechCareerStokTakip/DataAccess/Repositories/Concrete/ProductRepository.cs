using Core.Persistence.EntityBaseModel.Repositories;
using DataAccess.Context;
using DataAccess.Repositories.Abstracts;
using Models.Dtos.ResponseDto;
using Models.Entities;

namespace DataAccess.Repositories.Concrete;

public class ProductRepository : EfRepositoryBase<BaseDbContext, Product, Guid>, IProductRepository
{
    public ProductRepository(BaseDbContext context) : base(context)
    {

    }

    public List<ProductDetailDto> GetAllDetails()
    {
        var details = Context.Products.Join(
            Context.Categories,
            p => p.CategoryId,
            c => c.Id,
            (product, category) => new ProductDetailDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock,
                CategoryName = category.Name
            }
        ).ToList();

        return details;
    }

    public List<ProductDetailDto> GetDetailsByCategoryId(int categoryId)
    {
        var details = Context.Products.Where(x => x.CategoryId == categoryId).Join(
            Context.Categories,
            p => p.CategoryId,
            c => c.Id,
            (product, category) => new ProductDetailDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock,
                CategoryName = category.Name
            }
            ).ToList();

        return details;
    }

    public ProductDetailDto GetProductDetail(Guid id)
    {
        var details = Context.Products.Join(
            Context.Categories,
            p => p.CategoryId,
            c => c.Id,
            (product, category) => new ProductDetailDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock,
                CategoryName = category.Name
            }
            ).SingleOrDefault(x => x.Id == id);

        return details;
    }
}
