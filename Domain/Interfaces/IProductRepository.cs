using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

using Domain.Interfaces;

namespace Domain.Interfaces
{
    public interface IProductRepository 
    {
        Task<Product?> GetByDescripcionAsync(string descripcion, CancellationToken cancellationToken = default);
        Task<Product?> GetByStockAsync(string Stock, CancellationToken cancellationToken = default);
        Task<bool> ExistsByUsernameAsync(string username, CancellationToken cancellationToken = default);
        Task<bool> ExistsByMailAsync(string mail, CancellationToken cancellationToken = default);
        Task<List<Product>> GetByCategoriaAsync(int categoriaId, CancellationToken cancellationToken = default);
        Task<List<Product>> SearchAsync(string? query, int? categoriaId, CancellationToken cancellationToken = default);
    }
}