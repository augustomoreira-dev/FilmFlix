using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FilmFlix.Domain.Entities;

namespace FilmFlix.Domain.Interfaces
{
    public interface IWatchHistoryRepository
    {
        Task<WatchHistory?> GetByIdAsync(Guid id);

        Task AddAsync(WatchHistory history);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<WatchHistory>> ListAsync();

        Task<IEnumerable<WatchHistory>> FindAsync(Expression<Func<WatchHistory, bool>> predicate);
    }
}
