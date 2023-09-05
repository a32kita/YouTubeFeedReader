# YouTube Feed Reader
YouTube Feed Reader is a library for reading YouTube channel feeds in .NET.


## Example
The usage is very straightforward.

1. Install the library from NuGet or similar sources, and declare the namespace.
```
using YouTubeFeedReader;
```

2. Retrieves feed information for any channel.

```csharp
using (var ytService = new YouTubeFeedService())
{
    // 2 - 1. Fetches the feed for the specified channel from youtube.com
    var result = await ytService.LoadDocumentWithChannelIdAsync("UCw4J-5X7x1xUdbIcQkZ4VYA");

    // 2 - 2. Displays the channel's title
    Console.WriteLine(result.Title);
    Console.WriteLine();

    // 2 - 3. Displays information about recent streaming videos
    foreach (var entry in result.Entries)
    {
        Console.WriteLine("*** Id: {0} ***", entry.YouTubeVideoId);
        Console.WriteLine("  Title    : {0}", entry.Title);
        Console.WriteLine("  Views    : {0} views", entry.MediaGroup.Community.Statistics.Views);
        Console.WriteLine();
    }

    Console.ReadLine();
}
```


## Install
Now available on [NuGet](https://www.nuget.org/packages/YouTubeFeedReader/)

```
NuGet\Install-Package YouTubeFeedReader
```


## Platform
YouTube Feed Reader is designed for .NET Standard 2.0, making it available for a wide range of .NET applications.

Please refer to Microsoft's documentation for information on the targets that can apply .NET Standard 2.0 libraries:  
https://learn.microsoft.com/ja-jp/dotnet/standard/net-standard?tabs=net-standard-2-0#select-net-standard-version