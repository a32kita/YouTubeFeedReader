using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace YouTubeFeedReader.Entities
{
    public class MediaStarRating
    {
        public ulong Count
        {
            get;
            set;
        }

        public float Average
        {
            get;
            set;
        }

        public float Min
        {
            get;
            set;
        }

        public float Max
        {
            get;
            set;
        }


        public static MediaStarRating LoadFromXElement(XElement element)
        {
            var mediaStarRating = new MediaStarRating();
            mediaStarRating.Count = UInt64.Parse(element.Attribute("count").Value);
            mediaStarRating.Average = Single.Parse(element.Attribute("average").Value);
            mediaStarRating.Min = Single.Parse(element.Attribute("min").Value);
            mediaStarRating.Max = Single.Parse(element.Attribute("max").Value);

            return mediaStarRating;
        }
    }
}
