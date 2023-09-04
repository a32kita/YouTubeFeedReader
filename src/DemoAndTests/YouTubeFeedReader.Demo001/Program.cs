namespace YouTubeFeedReader.Demo001
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var sourceUrl = new Uri("https://www.youtube.com/feeds/videos.xml?channel_id=UCw4J-5X7x1xUdbIcQkZ4VYA");

            using (var ytService = new YouTubeFeedService())
            {
                var result = await ytService.LoadDocumentAsync(sourceUrl);

                // 下の行にブレークポイントを設置して、デバッガで値の正常性を確認する
                Console.WriteLine(result.Title);
            }
        }
    }
}