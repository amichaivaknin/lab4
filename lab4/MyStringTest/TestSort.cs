using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace MyStringTest
{
    [TestClass]
    public class TestSort
    {
        [TestMethod]
        public void MyString_Sort_String()
        {
            var myString = new MyString("Hello from the other side");
            var str = myString.Sort();

            Assert.AreEqual("from Hello other side the", str);
        }

        [TestMethod]
        public void MyString_Sort_EmptyString()
        {
            var myString = new MyString("");
            var str = myString.Sort();

            Assert.AreEqual("", str);
        }

        [TestMethod]
        public void MyString_Sort_OneWordString()
        {
            var myString = new MyString("Hello");
            var str = myString.Sort();

            Assert.AreEqual("Hello", str);
        }
    }
}
