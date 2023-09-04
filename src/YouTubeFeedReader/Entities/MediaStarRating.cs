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
            mediaStarRating.Count = AttributeToUInt64(element.Attribute("count"));
            mediaStarRating.Average = AttributeToSingle(element.Attribute("average"));
            mediaStarRating.Min = AttributeToSingle(element.Attribute("min"));
            mediaStarRating.Max = AttributeToSingle(element.Attribute("max"));

            return mediaStarRating;
        }
    }
}
