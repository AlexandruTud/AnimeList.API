namespace Anime_BackEndAPI.DTOs
{
    public class MinimalAnimeDTO
    {
        public string AnimeName { get; set; }
        public string ImageURL { get; set; }
        public string Genres { get; set; } 
        public float Score { get; set; }
    }
}