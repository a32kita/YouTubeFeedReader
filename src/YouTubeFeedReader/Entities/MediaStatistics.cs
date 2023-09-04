using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace YouTubeFeedReader.Entities
{
    public class MediaStatistics
    {
        public ulong Views
        {
            get;
            set;
        }

        public static MediaStatistics LoadFromXElement(XElement element)
        {
            var mediaStatistics = new MediaStatistics();
            mediaStatistics.Views = AttributeToUInt64(element.Attribute("views"));

            return mediaStatistics;
        }
    }
}
