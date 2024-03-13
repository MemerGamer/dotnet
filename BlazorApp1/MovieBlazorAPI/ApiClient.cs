using BlazorApp1.Api;
using BlazorApp1.Models;
using System.Text.Json;

namespace MovieBlazorAPI
{
    public class ApiClient
    {
        // https://api.themoviedb.org/3/search/movie?query=Jack+Reacher&api_key=ededadad8b3dd5415641de7dd548af87

        private static string ApiKey = "a8dc995cb481ea2c7d0ea82e4a64a55d";
        private readonly string BaseUrl = "https://api.themoviedb.org/3/";

        public List<Movie> Search(string searchTerm)
        {
            //string searchUrl = $"{BaseUrl}search/movie?query={searchTerm}&api_key={ApiKey}";
            string searchUrl = $"{BaseUrl}search/movie" +
                               $"?api_key={ApiKey}" +
                               "&language=en-US&page=1&include_adult=false" +
                               $"&query={searchTerm}";

            Console.WriteLine(searchUrl);

            HttpClient client = new HttpClient();
            var apiResult = client.GetStringAsync(searchUrl).GetAwaiter().GetResult();

            SearchResult? searchResult = JsonSerializer.Deserialize<SearchResult>(apiResult);

            return SearchResultToMovies(searchResult);
        }

        private List<Movie> SearchResultToMovies(SearchResult? searchResult)
        {
            
            // Both are good and the same just written differently 
            // var movie = new List<Movie>();
            /*foreach (var result in searchResult.results)
            {
                movie.Add(new Movie
                {
                    Title = result.title,
                    Poster = result.poster_path
                });
            }

            return movie;*/

            return searchResult.results.Select(x => new Movie()
            {
                Title = x.title,
                Poster = x.poster_path
            }).ToList();
        }
    }
}