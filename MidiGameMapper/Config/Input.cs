using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MidiGameMapper.Config
{
    [Serializable]
    public class Input
    {
        /// <summary>
        /// Indicates the variable name
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("value")]
        public int Value { get; set; }

        [XmlAttribute("description")]
        public string Description { get; set; }
    }
}
