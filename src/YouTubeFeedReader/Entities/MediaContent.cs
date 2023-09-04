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
            mediaContent.Url = AttributeToUri(element.Attribute("url"));
            mediaContent.Type = element.Attribute("type").Value;
            mediaContent.Width = AttributeToInt32(element.Attribute("width"));
            mediaContent.Height = AttributeToInt32(element.Attribute("height"));

            return mediaContent;
        }
    }
}
