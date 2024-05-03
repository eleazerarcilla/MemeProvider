namespace MemeProvider.Interfaces
{
    public interface IMemeProvider
    {
        public string GetMeme(string type);
        public string GetDefaultMemeFolderPath();
        public string GetMemeByType(string type);
        public int GetMemeFileNumber(int max);
    }
}
