global using static YouTubeFeedReader.YouTubeFeedDocument;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using YouTubeFeedReader.Entities;

namespace YouTubeFeedReader
{
    public class YouTubeFeedDocument
    {
        public Uri ChannelLink
        {
            get;
            set;
        }

        public string Title
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

        public EntryCollection Entries
        {
            get;
            set;
        }


        public static async Task<YouTubeFeedDocument> LoadAsync(Stream stream)
            => await LoadAsync(new StreamReader(stream));

        public static async Task<YouTubeFeedDocument> LoadAsync(TextReader reader)
        {
            var document = new YouTubeFeedDocument();

            await Task.Run(() =>
            {
                var rootElem = XElement.Load(reader);
                document.ChannelLink = AttributeToUri(rootElem.Element(XmlNsAtom + "link")?.Attribute("href"));
                document.Title = rootElem.Element(XmlNsAtom + "title")?.Value;
                document.Author = Author.LoadFromXElement(rootElem.Element(XmlNsAtom + "author"));
                document.Published = ElementToDateTimeOffset(rootElem.Element(XmlNsAtom + "published"));

                document.Entries = new EntryCollection();
                foreach (var ent in rootElem.Elements(XmlNsAtom + "entry"))
                {
                    document.Entries.Add(Entry.LoadFromXElement(ent));
                }
            });

            return document;
        }
    }
}
