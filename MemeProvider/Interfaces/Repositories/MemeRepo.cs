namespace MemeProvider.Interfaces.Repositories
{
    public class MemeRepo : IMemeProvider
    {
        public string GetMeme(string type) => GetMemeByType(type);
        public string GetMemeByType(string type) => type == "default" ? GetDefaultMemeFolderPath() : GetMemeFolderPathByType(type);
        public string GetDefaultMemeFolderPath()
        {
            string filePath = $"generic/generic-{GetMemeFileNumber(11)}.png";

            DateTime dateUTC = DateTime.UtcNow;
            string sgTimeZoneString = "Singapore Standard Time";
            TimeZoneInfo sgTimeZone = TimeZoneInfo.FindSystemTimeZoneById(sgTimeZoneString);

            DateTime sgTime = TimeZoneInfo.ConvertTimeFromUtc(dateUTC, sgTimeZone);

            if (sgTime.Hour <= 05 && sgTime.Hour >= 00)
            {
                filePath = $"midnight/midnight-{GetMemeFileNumber(3)}.png";
            }
            if (sgTime.Hour <= 19 && sgTime.Hour >= 17)
            {
                filePath = $"tgif/tgif-{GetMemeFileNumber(1)}.png";
            }
            return $"images/{filePath}";
        }
        public string GetMemeFolderPathByType(string type)
        {
            return $"images/medu/medu-{GetMemeFileNumber(9)}.png";
        }
        public int GetMemeFileNumber(int max) => new Random().Next(1, max);
    }
}
