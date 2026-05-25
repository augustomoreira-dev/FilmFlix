using System;
using System.Collections.Generic;
using FilmFlix.Domain.Enums;

namespace FilmFlix.Domain.Entities
{
    /// <summary>
    /// Entidade de domínio que representa um filme no modelo interno do FilmFlix.
    /// </summary>
    public sealed class Movie
    {
        /// <summary>
        /// Identificador interno do filme.
        /// </summary>
        public Guid Id { get; init; }

        /// <summary>
        /// Identificador externo (p. ex. TMDB ou outra origem), mas sem depender da API.
        /// </summary>
        public string ExternalId { get; init; } = string.Empty;

        /// <summary>
        /// Título principal do filme.
        /// </summary>
        public string Title { get; init; } = string.Empty;

        /// <summary>
        /// Título original do filme.
        /// </summary>
        public string OriginalTitle { get; init; } = string.Empty;

        /// <summary>
        /// Descrição ou sinopse do filme.
        /// </summary>
        public string Overview { get; init; } = string.Empty;

        /// <summary>
        /// URL do pôster do filme.
        /// </summary>
        public string PosterUrl { get; init; } = string.Empty;

        /// <summary>
        /// URL da imagem de fundo do filme.
        /// </summary>
        public string BackdropUrl { get; init; } = string.Empty;

        /// <summary>
        /// Data de lançamento do filme.
        /// </summary>
        public DateTime ReleaseDate { get; init; }

        /// <summary>
        /// Duração do filme.
        /// </summary>
        public TimeSpan Runtime { get; init; }

        /// <summary>
        /// Avaliação média do filme.
        /// </summary>
        public double Rating { get; init; }

        /// <summary>
        /// Total de votos recebidos.
        /// </summary>
        public int VoteCount { get; init; }

        /// <summary>
        /// Popularidade calculada ou fornecida pela origem de dados.
        /// </summary>
        public double Popularity { get; init; }

        /// <summary>
        /// Idioma principal do filme.
        /// </summary>
        public string Language { get; init; } = string.Empty;

        /// <summary>
        /// Identificadores de gêneros associados ao filme.
        /// </summary>
        public IReadOnlyCollection<Guid> Genres { get; init; } = Array.Empty<Guid>();

        /// <summary>
        /// URL do trailer do filme.
        /// </summary>
        public string TrailerUrl { get; init; } = string.Empty;

        /// <summary>
        /// Indica se o conteúdo é adulto.
        /// </summary>
        public bool IsAdultContent { get; init; }

        /// <summary>
        /// Status do filme no domínio (evita strings mágicas; usa enum `MovieStatus`).
        /// </summary>
        public MovieStatus Status { get; init; } = MovieStatus.Released;

        /// <summary>
        /// Data de criação do registro de domínio.
        /// </summary>
        public DateTime CreatedAt { get; init; }

        /// <summary>
        /// Data da última atualização do registro de domínio.
        /// </summary>
        public DateTime UpdatedAt { get; init; }
    }
}
