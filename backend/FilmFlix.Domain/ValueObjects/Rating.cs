using System;

namespace FilmFlix.Domain.ValueObjects
{
    /// <summary>
    /// Value object representing a film rating (0.0 to 10.0).
    /// Immutable and validates its invariant on construction.
    /// </summary>
    public sealed class Rating
    {
        public decimal Value { get; }

        public Rating(decimal value)
        {
            if (value < 0m || value > 10m)
                throw new ArgumentOutOfRangeException(nameof(value), "Rating must be between 0 and 10.");

            Value = Math.Round(value, 1);
        }

        public override string ToString() => Value.ToString("0.0");
    }
}
