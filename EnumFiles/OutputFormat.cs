using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace EnumFiles
{
    [Serializable]
    [XmlRoot("OutputFormat")]
    public class OutputFormat
    {
        [XmlAttribute]
        public string Name { set; get; }

        [XmlElement]
        public string Header { set; get; }

        [XmlElement]
        public string EachItem { set; get; }

        [XmlElement]
        public string EachItemAlternate { set; get; }

        [XmlElement]
        public string Footer { set; get; }

        public override string ToString()
        {
            return StringUtils.ReflectionToString(this);
        }
    }
}
