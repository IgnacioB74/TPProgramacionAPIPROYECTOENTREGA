using Application.Interfaces;
using Domain.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;


namespace Application.Services
{

    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        //LISTA USUARIOS
        public async Task<IEnumerable<DTOUser>> GetAllAsync()
        {
            var usuarios = await _userRepository.GetAllAsync();

            return usuarios.Select(u => new DTOUser
            {
                Id = u.Id,
                Nombre = u.Nombre,
                Apellido = u.Apellido,
                Estado = u.Estado.ToString(),
                Rol = u.Rol.ToString()
            });
        }

        //LISTA USUARIOS POR ID
        public async Task<DTOUser?> GetByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null) return null;

            return new DTOUser
            {
                Id = user.Id,
                Nombre = user.Nombre,
                Apellido = user.Apellido,
                Estado = user.Estado.ToString(),
                Rol = user.Rol.ToString()
            };
        }

        //CREACION

        public async Task<DTOUser> CreateAsync(DTOCreateUser dto)
        {
            var user = new User
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Username = dto.NombreUsuario,
                Password = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                Estado = Enum.Parse<EstadoEmpleado>(dto.Estado),
                Rol = Enum.Parse<Rol>(dto.Rol)
            };

            await _userRepository.AddAsync(user);

            return new DTOUser
            {
                Id = user.Id,
                Nombre = user.Nombre,
                Apellido = user.Apellido,
                Estado = user.Estado.ToString(),
                Rol = user.Rol.ToString()
            };
        }

        //MODIFICACION

        public async Task UpdateAsync(int id, UserCreateDTO dto)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
                throw new KeyNotFoundException("Usuario no encontrado");

            user.Nombre = dto.Nombre;
            user.Apellido = dto.Apellido;
            user.Dni = dto.Dni;
            user.Direccion = dto.Direccion;
            user.Telefono = dto.Telefono;
            user.FechaIngreso = dto.FechaIngreso;
            user.NombreUsuario = dto.NombreUsuario;
            user.Estado = Enum.Parse<EstadoEmpleado>(dto.Estado);
            user.Rol = Enum.Parse<Rol>(dto.Rol);

            if (!string.IsNullOrWhiteSpace(dto.Password))
            {
                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password);
            }

            await _userRepository.UpdateAsync(user);
        }

        //ELEMINAR
        public async Task DeleteAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
                throw new KeyNotFoundException("Usuario no encontrado");

            user.Estado = EstadoEmpleado.Inactivo;
            await _userRepository.UpdateAsync(user);
        }

        Task<IEnumerable<DTOUser>> IUserService.GetActivosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        Task<DTOUser> IUserService.CreateAsync(DTOCreateUser dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, DTOCreateUser dto)
        {
            throw new NotImplementedException();
        }
    }
}
