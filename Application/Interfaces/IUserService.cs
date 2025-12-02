using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<DTOUser>> GetAllAsync();
        Task<IEnumerable<DTOUser>> GetActivosAsync();
        Task<DTOUser?> GetByIdAsync(int id);
        Task<User?> GetByUsernameAsync(string username);
        Task<DTOUser> CreateAsync(DTOCreateUser dto);
        Task UpdateAsync(int id, DTOCreateUser dto);
        Task DeleteAsync(int id);
        Task<bool> UpdateAsync(int id, DTOUpdateUser dto);
    }
}
