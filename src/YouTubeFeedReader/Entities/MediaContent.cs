using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace YouTubeFeedReader.Entities
{
    public class MediaContent
    {
        public Uri Url
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public int Width
        {
            get;
            set;
        }

        public int Height
        {
            get;
            set;
        }


        public static MediaContent LoadFromXElement(XElement element)
        {
            var mediaContent = new MediaContent();
            mediaContent.Url = new Uri(element.Attribute("url").Value);
            mediaContent.Type = element.Attribute("type").Value;
            mediaContent.Width = Int32.Parse(element.Attribute("width").Value);
            mediaContent.Height = Int32.Parse (element.Attribute("height").Value);

            return mediaContent;
        }
    }
}
