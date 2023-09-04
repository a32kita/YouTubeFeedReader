global using static YouTubeFeedReader.InternalCommonValue;

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace YouTubeFeedReader
{
    internal class InternalCommonValue
    {
        internal static XNamespace XmlNsYt
        {
            get;
        }

        internal static XNamespace XmlNsMedia
        {
            get;
        }

        internal static XNamespace XmlNsAtom
        {
            get;
        }

        static InternalCommonValue()
        {
            XmlNsYt = "http://www.youtube.com/xml/schemas/2015";
            XmlNsMedia = "http://search.yahoo.com/mrss/";
            XmlNsAtom = "http://www.w3.org/2005/Atom";
        }
    }
}
