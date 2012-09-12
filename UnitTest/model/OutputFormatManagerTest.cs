using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using EnumFiles.Model;

namespace UnitTest.model
{
    [TestClass]
    public class OutputFormatManagerTest
    {
        private string dirName;

        [TestInitialize]
        public void Initialize()
        {
            this.dirName = Path.Combine(Path.GetTempPath(), "enumfiles-testmgr");
            System.Diagnostics.Trace.WriteLine("dir=" + this.dirName);
            if (!Directory.Exists(this.dirName))
            {
                Directory.CreateDirectory(this.dirName);
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (Directory.Exists(this.dirName))
            {
                Directory.Delete(this.dirName, true);
            }
        }

        [TestMethod]
        public void TestSimpleLoadAndSave()
        {
            string progDir = Path.Combine(this.dirName, "prog");
            string allDir = Path.Combine(this.dirName, "all");
            string justDir = Path.Combine(this.dirName, "just");

            Directory.CreateDirectory(progDir);
            Directory.CreateDirectory(allDir);
            Directory.CreateDirectory(justDir);

            var mgr = new OutputFormatManager();
            mgr.AddDirectory(new PersistentDirectoryInfo(progDir, false));
            mgr.AddDirectory(new PersistentDirectoryInfo(allDir, true));
            mgr.AddDirectory(new PersistentDirectoryInfo(justDir, true));

            var of1 = new OutputFormat()
            {
                Name = "name1",
                Header = "header1",
                EachItem = "eachItem1",
                EachItemAlternate = "eachItem1Alt",
                Footer = "footer1"
            };

            Assert.AreEqual(mgr.AllItems.Count(), 0);
            Assert.IsNull(mgr["name1"]);
            Assert.IsNull(mgr["name2"]);

            mgr.Update(of1);

            Assert.AreEqual(mgr.AllItems.Count(), 1);
            Assert.IsNotNull(mgr["name1"]);
            Assert.IsNull(mgr["name2"]);

            var of2 = of1.duplicate();
            of2.Name = "name2";

            mgr.Update(of2);

            Assert.AreEqual(mgr.AllItems.Count(), 2);
            Assert.IsNotNull(mgr["name1"]);
            Assert.IsNotNull(mgr["name2"]);

            Assert.AreEqual(new DirectoryInfo(justDir).GetFiles().Count(), 0);

            mgr.Save();

            Assert.AreEqual(new DirectoryInfo(justDir).GetFiles().Count(), 2);

            mgr.Clear();

            Assert.AreEqual(mgr.AllItems.Count(), 0);

            mgr.Load();

            Assert.AreEqual(mgr.AllItems.Count(), 2);
            Assert.IsNotNull(mgr["name1"]);
            Assert.IsNotNull(mgr["name2"]);

            var of_o1 = mgr["name1"];
            Assert.AreEqual(of1, of_o1);

            var of_o2 = mgr["name2"];
            Assert.AreEqual(of2, of_o2);
        }

        [TestMethod]
        public void TestCascade()
        {
            string progDir = Path.Combine(this.dirName, "prog");
            string allDir = Path.Combine(this.dirName, "all");
            string justDir = Path.Combine(this.dirName, "just");

            {
                Directory.CreateDirectory(progDir);
                Directory.CreateDirectory(allDir);
                Directory.CreateDirectory(justDir);

                var progDirInfo = new DirectoryInfo(progDir);
                var allDirInfo = new DirectoryInfo(allDir);
                var justDirInfo = new DirectoryInfo(justDir);

                Assert.AreEqual(progDirInfo.GetFiles().Count(), 0);
                Assert.AreEqual(allDirInfo.GetFiles().Count(), 0);
                Assert.AreEqual(justDirInfo.GetFiles().Count(), 0);

                var of1 = new OutputFormat()
                {
                    Name = "name1"
                };
                of1.Header = "a";

                var of2 = of1.duplicate();
                of2.Header = "b";

                var of3 = of1.duplicate();
                of3.Header = "c";

                var of4 = of1.duplicate();
                of4.Name = "name2";
                of4.Header = "d";

                var of5 = of1.duplicate();
                of5.Name = "name2";
                of5.Header = "e";

                OutputFormatPersistent.Save(of1, progDirInfo);
                OutputFormatPersistent.Save(of2, allDirInfo);
                OutputFormatPersistent.Save(of3, justDirInfo);

                OutputFormatPersistent.Save(of4, progDirInfo);
                OutputFormatPersistent.Save(of5, allDirInfo);
            }

            {
                var mgr = new OutputFormatManager();
                mgr.AddDirectory(new PersistentDirectoryInfo(progDir, false));
                mgr.AddDirectory(new PersistentDirectoryInfo(allDir, true));
                mgr.AddDirectory(new PersistentDirectoryInfo(justDir, true));

                mgr.Load();

                Assert.AreEqual(mgr.AllItems.Count(), 2);

                Assert.AreEqual(mgr["name1"].Header, "c");
                Assert.AreEqual(mgr["name2"].Header, "e");

                OutputFormat x;
                bool ret;

                ret = mgr.TryGetValue("name1", out x);
                Assert.IsTrue(ret);
                x.Footer = "x";

                mgr.Update(x);

                Assert.AreEqual(mgr["name1"].Footer, "x");

                ret = mgr.TryGetValue("name2", out x);
                Assert.IsTrue(ret);
                x.Footer = "y";

                mgr.Update(x);

                Assert.AreEqual(mgr["name2"].Footer, "y");

                mgr.Save();
            }

            {
                var mgr = new OutputFormatManager();
                mgr.AddDirectory(new PersistentDirectoryInfo(progDir, false));
                mgr.AddDirectory(new PersistentDirectoryInfo(allDir, true));
                mgr.AddDirectory(new PersistentDirectoryInfo(justDir, true));

                mgr.Load();

                Assert.AreEqual(mgr.AllItems.Count(), 2);

                Assert.AreEqual(mgr["name1"].Header, "c");
                Assert.AreEqual(mgr["name2"].Header, "e");
                Assert.AreEqual(mgr["name1"].Footer, "x");
                Assert.AreEqual(mgr["name2"].Footer, "y");

                mgr["name1"] = null;
                mgr.Remove(mgr["name2"]);

                Assert.AreEqual(mgr["name1"].Header, "b");
                Assert.AreEqual(mgr["name2"].Header, "d");

                mgr.Save();
            }

            {
                var mgr = new OutputFormatManager();
                mgr.AddDirectory(new PersistentDirectoryInfo(progDir, false));
                mgr.AddDirectory(new PersistentDirectoryInfo(allDir, true));
                mgr.AddDirectory(new PersistentDirectoryInfo(justDir, true));

                mgr.Load();

                Assert.AreEqual(mgr.AllItems.Count(), 2);

                Assert.AreEqual(mgr["name1"].Header, "b");
                Assert.AreEqual(mgr["name2"].Header, "d");
            }
        }
    }
}
