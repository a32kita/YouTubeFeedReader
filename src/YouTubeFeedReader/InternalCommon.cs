global using static YouTubeFeedReader.InternalCommon;

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace YouTubeFeedReader
{
    internal class InternalCommon
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

        static InternalCommon()
        {
            XmlNsYt = "http://www.youtube.com/xml/schemas/2015";
            XmlNsMedia = "http://search.yahoo.com/mrss/";
            XmlNsAtom = "http://www.w3.org/2005/Atom";
        }

        //public static TValueType ElementToValue<TValueType>(XElement element)
        //{
        //    if (element == null)
        //        return default(TValueType);

        //    var targetType = typeof(TValueType);
        //    if (targetType == typeof(Int32))
        //        return (TValueType)Int32.Parse(element.Value);
        //}


        public static int ElementToInt32(XElement element)
        {
            if (element == null)
                return default(int);

            try
            {
                return int.Parse(element.Value);
            }
            catch
            {
                return default(int);
            }
        }

        public static float ElementToSingle(XElement element)
        {
            if (element == null)
                return 0;

            try
            {
                return float.Parse(element.Value);
            }
            catch
            {
                return default(float);
            }
        }

        public static ulong ElementToUInt64(XElement element)
        {
            if (element == null)
                return 0;

            try
            {
                return ulong.Parse(element.Value);
            }
            catch
            {
                return default(ulong);
            }
        }

        public static DateTimeOffset ElementToDateTimeOffset(XElement element)
        {
            if (element == null)
                return default(DateTimeOffset);

            try
            {
                return DateTimeOffset.Parse(element.Value);
            }
            catch
            {
                return default(DateTimeOffset);
            }
        }

        public static Uri ElementToUri(XElement element)
        {
            if (element == null)
                return null;

            try
            {
                return new Uri(element.Value);
            }
            catch
            {
                return default(Uri);
            }
        }

        public static int AttributeToInt32(XAttribute attribute)
        {
            if (attribute == null)
                return default(int);

            try
            {
                return int.Parse(attribute.Value);
            }
            catch
            {
                return default(int);
            }
        }

        public static float AttributeToSingle(XAttribute attribute)
        {
            if (attribute == null)
                return 0;

            try
            {
                return float.Parse(attribute.Value);
            }
            catch
            {
                return default(float);
            }
        }

        public static ulong AttributeToUInt64(XAttribute attribute)
        {
            if (attribute == null)
                return 0;

            try
            {
                return ulong.Parse(attribute.Value);
            }
            catch
            {
                return default(ulong);
            }
        }

        public static DateTimeOffset AttributeToDateTimeOffset(XAttribute attribute)
        {
            if (attribute == null)
                return default(DateTimeOffset);

            try
            {
                return DateTimeOffset.Parse(attribute.Value);
            }
            catch
            {
                return default(DateTimeOffset);
            }
        }

        public static Uri AttributeToUri(XAttribute attribute)
        {
            if (attribute == null)
                return null;

            try
            {
                return new Uri(attribute.Value);
            }
            catch
            {
                return default(Uri);
            }
        }
    }
}
