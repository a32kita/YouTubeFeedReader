using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace YouTubeFeedReader.Entities
{
    public class MediaGroup
    {
        public string Title
        {
            get;
            set;
        }

        public MediaContent Content
        {
            get;
            set;
        }

        public MediaThumbnail Thumbnail
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public MediaCommunity Community
        {
            get;
            set;
        }


        public static MediaGroup LoadFromXElement(XElement element)
        {
            var mediaGroup = new MediaGroup();
            mediaGroup.Title = element.Element(XmlNsMedia + "title").Value;
            mediaGroup.Content = MediaContent.LoadFromXElement(element.Element(XmlNsMedia + "content"));
            mediaGroup.Thumbnail = MediaThumbnail.LoadFromXElement(element.Element(XmlNsMedia + "thumbnail"));
            mediaGroup.Description = element.Element(XmlNsMedia + "description").Value;
            mediaGroup.Community = MediaCommunity.LoadFromXElement(element.Element(XmlNsMedia + "community"));

            return mediaGroup;
        }
    }
}
