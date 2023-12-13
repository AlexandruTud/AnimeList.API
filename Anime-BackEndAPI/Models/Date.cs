namespace Anime_BackEndAPI.Models
{
    public class Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public string CreateDate()
        {
            return $"{Year}-{Month}-{Day}";
        }
    }
}
