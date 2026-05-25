using System;

namespace FilmFlix.Domain.ValueObjects
{
    /// <summary>
    /// Value object representing a validated image URL.
    /// Immutable and enforces http/https absolute URI.
    /// </summary>
    public sealed class ImageUrl
    {
        public string Url { get; }
        public Uri Uri { get; }

        public ImageUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentException("Image URL cannot be empty.", nameof(url));

            if (!Uri.TryCreate(url, UriKind.Absolute, out var uri) ||
                (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps))
            {
                throw new ArgumentException("Image URL must be an absolute http/https URI.", nameof(url));
            }

            Url = url;
            Uri = uri;
        }

        public override string ToString() => Url;
    }
}
