namespace Anime_BackEndAPI.Models
{
    public class Anime
    {
        public string AnimeID { get; set; } 
        public string AnimeName { get; set; }
        public string Description { get; set; }
        public int numberOfEpisodes { get; set; }
        public string Genre { get; set; }
        public string Studio { get; set; }
        public string ImageURL { get; set; }
    }
}
