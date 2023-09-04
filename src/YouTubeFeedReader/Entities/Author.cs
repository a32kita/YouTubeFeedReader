using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace YouTubeFeedReader.Entities
{
    public class Author
    {
        public string Name
        {
            get;
            set;
        }

        public Uri Uri
        {
            get;
            set;
        }


        public static Author LoadFromXElement(XElement element)
        {
            if (element == null)
                return null;

            var author = new Author();
            author.Name = element.Element(XmlNsAtom + "name").Value;
            author.Uri = new Uri(element.Element(XmlNsAtom + "uri").Value);

            return author;
        }
    }
}
