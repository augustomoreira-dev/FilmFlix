using System;

namespace FilmFlix.Domain.Entities
{
    public sealed class WatchHistory
    {
        public Guid Id { get; set; }

        public Guid MovieId { get; set; }

        // When multi-user support is added, UserId can be reintroduced.
        // public Guid UserId { get; set; }

        public DateTimeOffset WatchedAt { get; set; }

        private int _progressPercent;

        /// <summary>
        /// Progress percent from 0 to 100. Setter enforces the invariant.
        /// </summary>
        public int ProgressPercent
        {
            get => _progressPercent;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(ProgressPercent), "ProgressPercent must be between 0 and 100.");
                _progressPercent = value;
            }
        }

        // Last known position within the media (TimeSpan), optional.
        public TimeSpan? LastPosition { get; set; }

        // This class remains a pure domain model without persistence or infra details.
    }
}
