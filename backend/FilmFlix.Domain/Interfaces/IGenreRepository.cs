using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FilmFlix.Domain.Entities;

namespace FilmFlix.Domain.Interfaces
{
    public interface IGenreRepository
    {
        Task<Genre?> GetByIdAsync(Guid id);

        Task AddAsync(Genre genre);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<Genre>> ListAsync();

        Task<IEnumerable<Genre>> FindAsync(Expression<Func<Genre, bool>> predicate);
    }
}
