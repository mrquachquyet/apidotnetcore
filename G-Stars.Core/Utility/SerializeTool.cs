using System;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace VNCDCL.Core.Utility
{
    public static class SerializeTool
    {
        
        /// <summary>
        /// Serialize object to json string
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static string Serialize(object model)
        {
            return JsonConvert.SerializeObject(model);
        }
        
        /// <summary>
        /// Deserialize object from string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        /// <summary>
        /// Deserialize object from string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        public static T DeserializeXml<T>(string xmlString)
        {
            try
            {
                var deserializer = new XmlSerializer(typeof(T));
                return (T)deserializer.Deserialize(new StringReader(xmlString));
            }
            catch (Exception)
            {
                return default(T);
            }
        }
    }
}
