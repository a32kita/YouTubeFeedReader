using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace YouTubeFeedReader.Entities
{
    public class MediaThumbnail
    {
        public Uri Url
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


        public static MediaThumbnail LoadFromXElement(XElement element)
        {
            var mediaThumbnail = new MediaThumbnail();
            mediaThumbnail.Url = new Uri(element.Attribute("url")?.Value);
            mediaThumbnail.Width = Int32.Parse(element.Attribute("width")?.Value);
            mediaThumbnail.Height = Int32.Parse (element.Attribute("height")?.Value);

            return mediaThumbnail;
        }
    }
}
