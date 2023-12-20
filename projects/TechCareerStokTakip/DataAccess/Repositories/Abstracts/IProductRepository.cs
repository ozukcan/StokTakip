using Core.Persistence.EntityBaseModel.Repositories;
using Models.Dtos.ResponseDto;
using Models.Entities;

namespace DataAccess.Repositories.Abstracts;

public interface IProductRepository : IEntityRepository<Product, Guid>
{
    List<ProductDetailDto> GetAllDetails();
    List<ProductDetailDto> GetDetailsByCategoryId(int categoryId);

    ProductDetailDto GetProductDetail(Guid id);
}
