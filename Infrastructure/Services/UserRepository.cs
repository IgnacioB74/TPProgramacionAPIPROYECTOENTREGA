using AuthApi.Data;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _UserRepository;
        public UserRepository(AppDbContext UserRepository)
        {
            _UserRepository = UserRepository;

        }

        public Task<bool> ExistsByMailAsync(string mail, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByUsernameAsync(string username, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByMailAsync(string mail, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> GetByUsernameAsync(string username)
        {
            return await _UserRepository.Users
                .FirstOrDefaultAsync(u => u.Username == username);
        }

        public Task<User?> GetByUsernameAsync(string username, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<User>> GetActivosAsync()
        {
            return await _UserRepository.Users
                .Where(u => u.Estado == Domain.Enums.Estado.Activo)
                .ToListAsync();
        }
    }
}
