using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

using Domain.Interfaces;

namespace Domain.Interfaces
{
    public interface IEventRepository : IRepositoryBase<Event>
    {
        Task<List<Event>> GetEventsAsync(string? titulo = null, CancellationToken cancellationToken = default);
        Task<List<Event>> GetByFechaAsync(DateTime fecha, CancellationToken cancellationToken = default);
        Task<List<Event>> GetUpcomingAsync(int? limit = null, CancellationToken cancellationToken = default);
    }
}