using Anime_BackEndAPI.Models;

namespace Anime_BackEndAPI.DTOs
{
    public class ViewRecordDTO
    {
        public string AnimeName { get; set; }   
        public int viewedEpisodes { get; set; }
        public Date StartDate { get; set; }
        public Date EndDate { get; set; }
        public int Raiting { get; set; }
    }
}
