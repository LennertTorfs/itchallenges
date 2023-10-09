using itchallenges.models;
using System;
using System.Net.Http.Json;
using System.Numerics;
using System.Text.Json;
using static System.Collections.Specialized.BitVector32;


namespace itchallenges.Pages
{
    public partial class Movies
    {


        private string searchTerm;
        private List<Movie> movies;
        private string message;

        private async Task SearchMovies()
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                message = "Please enter a search term.";
                return;
            }
            using var Http = new HttpClient();
            var apiKey = "9aa2196e";
            var response = await Http.GetFromJsonAsync<OMDBResponse>($"https://www.omdbapi.com/?s={searchTerm}&type=movie&apikey={apiKey}");

            if (response == null)
            {
                message = "Error in fetching data from the OMDB API.";
                return;
            }

            if (response.Response == "True")
            {
                movies = response.Search;
                message = $"Aantal gevonden: {response.TotalResults}";
            }
            else
            {
                message = response.Error;
                movies = null;
            }
        }

    }

}
