using System;

namespace FilmFlix.Domain.Entities
{
    /// <summary>
    /// Entidade de domínio que representa uma categoria de filmes.
    /// </summary>
    public sealed class Genre
    {
        /// <summary>
        /// Identificador interno da categoria.
        /// </summary>
        public Guid Id { get; init; }

        /// <summary>
        /// Identificador externo opcional de origem.
        /// </summary>
        public string ExternalId { get; init; } = string.Empty;

        /// <summary>
        /// Nome da categoria.
        /// </summary>
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Slug amigável para frontend.
        /// </summary>
        public string Slug { get; init; } = string.Empty;
    }
}
