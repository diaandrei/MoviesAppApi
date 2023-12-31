﻿namespace Movies.Contracts.Responses
{
    public class MovieResponse
    {
        public required Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Slug { get; set; }
        public required int YearOfRelease { get; set; }
        public required IEnumerable<string> Genres { get; init; } = Enumerable.Empty<string>();
    }
}
