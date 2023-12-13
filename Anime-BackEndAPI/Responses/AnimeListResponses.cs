namespace Anime_BackEndAPI.Responses
{
    public class AnimeListResponses
    {
        public string AnimeName { get; set; }
        public string ImageURL { get; set; }
        public List<string> Genres { get; set; } = new List<string>();
    }
}
