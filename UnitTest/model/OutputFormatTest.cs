using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnumFiles;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using EnumFiles.Model;

namespace UnitTest
{
    [TestClass]
    public class OutputFormatTest
    {
        [TestMethod]
        public void TestXmlSerialize()
        {
            var obj1 = new OutputFormat()
            {
                Name = "test1",
                Header = "header-1",
                EachItem = "item1",
                EachItemAlternate = "item2",
                Footer = "footer-1"
            };

            var xmlSerializer = new XmlSerializer(typeof(OutputFormat));
            using (var txtWr = new StringWriter())
            {
                using (XmlTextWriter wr = new XmlTextWriter(txtWr))
                {
                    wr.Formatting = Formatting.Indented;
                    xmlSerializer.Serialize(wr, obj1);
                }
                Console.WriteLine(txtWr.ToString());
            }
        }
    }
}
