using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MidiGameMapper.Config
{
    class ConfigReader
    {
        public static Configuration ReadFile(string fileName)
        {
            var ser = new XmlSerializer(typeof(Configuration));
            using (var stream = File.OpenRead(fileName))
            {
                Configuration config = (Configuration)ser.Deserialize(stream);
                return config;
            }
        }

        public static Configuration Read(string xml)
        {
            var ser = new XmlSerializer(typeof(Configuration));
            using (var stream = new StringReader(xml))
            {
                Configuration config = (Configuration)ser.Deserialize(stream);
                return config;
            }
        }
    }
}
