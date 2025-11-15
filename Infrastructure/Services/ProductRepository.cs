using AuthApi.Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _ProductRepository;
        public ProductRepository(AppDbContext ProductRepository)
        {
            _ProductRepository = ProductRepository;

        }

        public Task<bool> ExistsByMailAsync(string mail, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByUsernameAsync(string username, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetByCategoriaAsync(int categoriaId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetByDescripcionAsync(string descripcion, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetByStockAsync(string Stock, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> SearchAsync(string? query, int? categoriaId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
