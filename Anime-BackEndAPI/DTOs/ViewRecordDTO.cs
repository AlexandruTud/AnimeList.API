using Anime_BackEndAPI.Models;

namespace Anime_BackEndAPI.DTOs
{
    public class ViewRecordDTO
    {
        public int UserID { get; set; }
        public string AnimeName { get; set; }   
        public int viewedEpisodes { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int Rating { get; set; }
    }
}
