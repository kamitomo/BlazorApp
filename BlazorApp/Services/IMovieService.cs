using BlazorApp.Models;

namespace BlazorApp.Services
{
    public interface IMovieService
    {
        public Task<Movie[]> GetMoviesAsync(bool watchedMovies);

        public Task PostMovieAsync(Movie movie);

        public Task PutMovieAsync(long id, Movie movie);

        public Task DeleteMovieAsync(long id);
    }
}
