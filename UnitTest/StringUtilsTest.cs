using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnumFiles;

namespace UnitTest
{
    [TestClass]
    public class StringUtilsTest
    {
        [TestMethod]
        public void TestReflectionToString()
        {
            var obj1 = new
            {
                Val1 = 1
            };

            var obj2 = new
            {
                Val1 = 1,
                Val2 = "hello, world"
            };

            var obj3 = new
            {
                Val1 = 1,
                Val2 = "hello, world",
                Val3 = DateTime.Today
            };

            Console.WriteLine(StringUtils.ReflectionToString(obj1));
            Console.WriteLine(StringUtils.ReflectionToString(obj2));
            Console.WriteLine(StringUtils.ReflectionToString(obj3));
        }
    }
}
