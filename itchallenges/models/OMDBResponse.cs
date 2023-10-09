namespace itchallenges.models
{
    public class OMDBResponse
    {
        public List<Movie> Search { get; set; }
        public string Response { get; set; }
        public string Error { get; set; }
        public string? TotalResults { get; set; }
    }
}
