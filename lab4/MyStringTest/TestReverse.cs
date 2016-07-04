using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace MyStringTest
{
    [TestClass]
    public class TestReverse
    {
        [TestMethod]
        public void MyString_Reverse_String()
        {
            var myString = new MyString("Hello from the other side");
            var str = myString.Reverse();

            Assert.AreEqual("side other the from Hello",str);
        }

        [TestMethod]
        public void MyString_Reverse_EmptyString()
        {
            var myString = new MyString("");
            var str = myString.Reverse();

            Assert.AreEqual("", str);
        }

        [TestMethod]
        public void MyString_Reverse_OneWordString()
        {
            var myString = new MyString("Hello");
            var str = myString.Reverse();

            Assert.AreEqual("Hello", str);
        }

    }
}
