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
            mediaThumbnail.Url = AttributeToUri(element.Attribute("url"));
            mediaThumbnail.Width = AttributeToInt32(element.Attribute("width"));
            mediaThumbnail.Height = AttributeToInt32(element.Attribute("height"));

            return mediaThumbnail;
        }
    }
}
