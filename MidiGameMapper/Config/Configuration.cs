using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MidiGameMapper.Config
{
    [Serializable]
    [XmlRoot(ElementName = "midiMapperConfig")]
    public class Configuration
    {
        [XmlElement("mapping")]
        public List<Mapping> Mappings { get; set; }

        public Configuration()
        {
            Mappings = new List<Mapping>();
        }
    }
}
