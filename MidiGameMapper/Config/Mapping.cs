using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MidiGameMapper.Config
{
    [Serializable]
    public class Mapping
    {
        [XmlAttribute("description")]
        public string Description { get; set; }

        [XmlAttribute("profile")]
        public string Profile { get; set; }

        [XmlElement("input")]
        public List<Input> Inputs { get; set; }
        [XmlElement("output")]
        public List<Output> Outputs { get; set; }

        public Mapping()
        {
            Inputs = new List<Input>();
            Outputs = new List<Output>();
        }
    }
}
