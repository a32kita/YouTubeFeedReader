using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace YouTubeFeedReader.Entities
{
    public class MediaCommunity
    {
        public MediaStarRating StarRating
        {
            get;
            set;
        }

        public MediaStatistics Statistics
        {
            get;
            set;
        }


        public static MediaCommunity LoadFromXElement(XElement element)
        {
            var mediaCommunity = new MediaCommunity();
            mediaCommunity.StarRating = MediaStarRating.LoadFromXElement(element.Element(XmlNsMedia + "starRating"));
            mediaCommunity.Statistics = MediaStatistics.LoadFromXElement(element.Element(XmlNsMedia + "statistics"));

            return mediaCommunity;
        }
    }
}
