using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FilmFlix.Domain.Entities;

namespace FilmFlix.Domain.Interfaces
{
    public interface IMovieRepository
    {
        Task<Movie?> GetByIdAsync(Guid id);

        Task AddAsync(Movie movie);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<Movie>> ListAsync();

        Task<IEnumerable<Movie>> FindAsync(Expression<Func<Movie, bool>> predicate);

        Task<(IEnumerable<Movie> Items, int Total)> ListPagedAsync(int page, int pageSize);
    }
}
