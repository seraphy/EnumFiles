using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnumFiles.Model;
using System.IO;
using System.Linq;

namespace UnitTest.model
{
    [TestClass]
    public class OutputFormatPersistentTest
    {
        [TestMethod]
        public void TestSaveAndLoadAndDelete()
        {
            string dir = Path.Combine(Path.GetTempPath(), "enumfile-test");
            var dirInfo = new DirectoryInfo(dir);
            if (dirInfo.Exists)
            {
                dirInfo.Delete(true);
            }

            var of = new OutputFormat();
            of.Name = "of1";
            of.Header = "header1";
            of.Footer = "footer1";
            of.EachItem = "eachItem1";
            of.EachItemAlternate = "eachItemAlt1";

            OutputFormatPersistent.Save(of, dirInfo);

            var of2 = of.duplicate();
            of2.Name = "of?2";

            OutputFormatPersistent.Save(of2, dirInfo);

            var results = OutputFormatPersistent.Load(dir).ToArray();

            foreach (OutputFormat iof in results)
            {
                Console.WriteLine(iof);
            }

            Assert.AreEqual(results.Length, 2);

            OutputFormatPersistent.Delete(of, dirInfo);
            OutputFormatPersistent.Delete(of2, dirInfo);

            dirInfo.Delete();
        }
    }
}
