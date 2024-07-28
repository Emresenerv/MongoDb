using MongoDb.Dtos.ProductDtos;

namespace MongoDb.Services.ProductService
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto ProductDto);
        Task UpdateProductAsync(UpdateProductDto ProductDto);
        Task DeleteProductAsync(string id);
        Task<GetByIdProductDto> GetByIdProductAsync(string id);
    }
}
