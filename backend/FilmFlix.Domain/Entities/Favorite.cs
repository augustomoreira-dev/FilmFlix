using System;

namespace FilmFlix.Domain.Entities
{
    public sealed class Favorite
    {
        public Guid Id { get; set; }

        public Guid MovieId { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public string Notes { get; set; } = string.Empty;

        // Regra de domínio: um filme deve ser favorito apenas uma vez por instância de usuário local.
        // Esta camada não implementa autenticação, múltiplos usuários ou sincronização remota.

        /// <summary>
        /// Helper to check duplicates in an existing favorites collection for the same local user context.
        /// This keeps the duplicate-check logic as a domain helper without enforcing persistence rules here.
        /// </summary>
        public static bool ExistsDuplicate(System.Collections.Generic.IEnumerable<Favorite>? existingFavorites, Guid movieId)
        {
            if (existingFavorites == null)
                return false;

            foreach (var f in existingFavorites)
            {
                if (f.MovieId == movieId)
                    return true;
            }

            return false;
        }
    }
}
