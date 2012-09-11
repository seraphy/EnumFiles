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

        [TestMethod]
        public void TestIsModified()
        {
            var o1 = new OutputFormat();
            var o2 = new OutputFormat();
            Assert.IsTrue(!o1.IsModified(o1));
            Assert.IsTrue(!o1.IsModified(o2));
            Assert.IsTrue(!o2.IsModified(o1));

            o2.Name = "a";
            Assert.IsTrue(o1.IsModified(o2));
            Assert.IsTrue(o2.IsModified(o1));
            o2.Name = o1.Name;

            o2.Header = "aa";
            Assert.IsTrue(o1.IsModified(o2));
            Assert.IsTrue(o2.IsModified(o1));
            o2.Header = o1.Header;

            o2.Footer = "bb";
            Assert.IsTrue(o1.IsModified(o2));
            Assert.IsTrue(o2.IsModified(o1));
            o2.Footer = o1.Footer;

            o2.EachItem = "cc";
            Assert.IsTrue(o1.IsModified(o2));
            Assert.IsTrue(o2.IsModified(o1));
            o2.EachItem = o1.EachItem;

            o2.EachItemAlternate = "dd";
            Assert.IsTrue(o1.IsModified(o2));
            Assert.IsTrue(o2.IsModified(o1));
            o2.EachItemAlternate = o1.EachItemAlternate;
        }

        [TestMethod]
        public void TestEquals()
        {
            var o1 = new OutputFormat();
            var o2 = new OutputFormat();
            Assert.IsTrue(o1.Equals(o2));
            Assert.IsTrue(o1.Equals(o2));
            Assert.IsTrue(o2.Equals(o1));

            o2.Name = "a";
            Assert.IsTrue(!o1.Equals(o2));
            Assert.IsTrue(!o2.Equals(o1));
            o2.Name = o1.Name;

            o2.Header = "aa";
            Assert.IsTrue(!o1.Equals(o2));
            Assert.IsTrue(!o2.Equals(o1));
            o2.Header = o1.Header;

            o2.Footer = "bb";
            Assert.IsTrue(!o1.Equals(o2));
            Assert.IsTrue(!o2.Equals(o1));
            o2.Footer = o1.Footer;

            o2.EachItem = "cc";
            Assert.IsTrue(!o1.Equals(o2));
            Assert.IsTrue(!o2.Equals(o1));
            o2.EachItem = o1.EachItem;

            o2.EachItemAlternate = "dd";
            Assert.IsTrue(!o1.Equals(o2));
            Assert.IsTrue(!o2.Equals(o1));
            o2.EachItemAlternate = o1.EachItemAlternate;
        }

        [TestMethod]
        public void TestEquals2()
        {
            var o1 = new OutputFormat();
            var o2 = new OutputFormat();
            Assert.IsTrue(o1 == o2);
            Assert.IsTrue(o1 == o2);
            Assert.IsTrue(o2 == o1);

            o2.Name = "a";
            Assert.IsTrue(o1 != o2);
            Assert.IsTrue(o2 != o1);
            Assert.IsTrue(!(o1 == o2));
            Assert.IsTrue(!(o2 == o1));
            o2.Name = o1.Name;

            o2.Header = "aa";
            Assert.IsTrue(o1 != o2);
            Assert.IsTrue(o2 != o1);
            Assert.IsTrue(!(o1 == o2));
            Assert.IsTrue(!(o2 == o1));
            o2.Header = o1.Header;

            o2.Footer = "bb";
            Assert.IsTrue(o1 != o2);
            Assert.IsTrue(o2 != o1);
            Assert.IsTrue(!(o1 == o2));
            Assert.IsTrue(!(o2 == o1));
            o2.Footer = o1.Footer;

            o2.EachItem = "cc";
            Assert.IsTrue(o1 != o2);
            Assert.IsTrue(o2 != o1);
            Assert.IsTrue(!(o1 == o2));
            Assert.IsTrue(!(o2 == o1));
            o2.EachItem = o1.EachItem;

            o2.EachItemAlternate = "dd";
            Assert.IsTrue(o1 != o2);
            Assert.IsTrue(o2 != o1);
            Assert.IsTrue(!(o1 == o2));
            Assert.IsTrue(!(o2 == o1));
            o2.EachItemAlternate = o1.EachItemAlternate;
        }
    }
}
