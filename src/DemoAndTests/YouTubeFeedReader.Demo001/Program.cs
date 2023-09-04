namespace YouTubeFeedReader.Demo001
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var sourceUrl = new Uri("https://www.youtube.com/feeds/videos.xml?channel_id=UCP5xQ9HIcget8kMHHqgyP0Q");

            var ytService = new YouTubeFeedService();
            var result = await ytService.LoadDocumentAsync(sourceUrl);

            Console.WriteLine(result.Title);
        }
    }
}