using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace YouTubeFeedReader.Entities
{
    public class Entry
    {
        public string Id
        {
            get;
            set;
        }

        public string YouTubeVideoId
        {
            get;
            set;
        }

        public string YouTubeChannelId
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public Uri Link
        {
            get;
            set;
        }

        public Author Author
        {
            get;
            set;
        }

        public DateTimeOffset Published
        {
            get;
            set;
        }

        public DateTimeOffset Updated
        {
            get;
            set;
        }

        public MediaGroup MediaGroup
        {
            get;
            set;
        }

        public static Entry LoadFromXElement(XElement element)
        {
            var entry = new Entry();
            entry.Id = element.Element(XmlNsAtom + "id")?.Value;
            entry.YouTubeVideoId = element.Element(XmlNsYt + "videoId")?.Value;
            entry.YouTubeChannelId = element.Element(XmlNsYt + "channelId")?.Value;
            entry.Title = element.Element(XmlNsAtom + "title")?.Value;
            entry.Link = AttributeToUri(element.Element(XmlNsAtom + "link")?.Attribute("href"));
            entry.Author = Author.LoadFromXElement(element.Element(XmlNsAtom + "author"));
            entry.Published = ElementToDateTimeOffset(element.Element(XmlNsAtom + "published"));
            entry.Updated = ElementToDateTimeOffset(element.Element(XmlNsAtom + "updated"));
            entry.MediaGroup = MediaGroup.LoadFromXElement(element.Element(XmlNsMedia + "group"));

            return entry;
        }
    }
}
