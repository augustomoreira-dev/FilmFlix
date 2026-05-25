using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FilmFlix.Domain.Entities;

namespace FilmFlix.Domain.Interfaces
{
    public interface IFavoriteRepository
    {
        Task<Favorite?> GetByIdAsync(Guid id);

        Task AddAsync(Favorite favorite);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<Favorite>> ListAsync();

        Task<IEnumerable<Favorite>> FindAsync(Expression<Func<Favorite, bool>> predicate);
    }
}
