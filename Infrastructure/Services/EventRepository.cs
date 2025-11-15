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
    public class EventRepository : IEventRepository
    {
        private readonly AppDbContext _eventRepository;
        public EventRepository(AppDbContext eventRepository)
        {
            _eventRepository = eventRepository;

        }

        public Task<List<Event>> GetByFechaAsync(DateTime fecha, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<Event>> GetEventsAsync(string? titulo = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<Event>> GetUpcomingAsync(int? limit = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
