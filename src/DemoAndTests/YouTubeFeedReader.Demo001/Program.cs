using System.Runtime.CompilerServices;

namespace YouTubeFeedReader.Demo001
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //var sourceUrl = new Uri("https://www.youtube.com/feeds/videos.xml?channel_id=UCw4J-5X7x1xUdbIcQkZ4VYA");

            using (var ytService = new YouTubeFeedService())
            {
                // 1. Fetches the feed for the specified channel from youtube.com
                var result = await ytService.LoadDocumentWithChannelIdAsync("UCw4J-5X7x1xUdbIcQkZ4VYA");

                // 2. Displays the channel's title
                Console.WriteLine(result.Title);
                Console.WriteLine();

                // 3. Displays information about recent streaming videos
                foreach (var entry in result.Entries)
                {
                    Console.WriteLine("*** Id: {0} ***", entry.YouTubeVideoId);
                    Console.WriteLine("  Title    : {0}", entry.Title);
                    Console.WriteLine("  Views    : {0} views", entry.MediaGroup.Community.Statistics.Views);
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
        }
    }
}