using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace MyStringTest
{
    [TestClass]
    public class TestNumberWords
    {
        [TestMethod]
        public void MyString_NunberWords_String()
        {
            var myString = new MyString("Hello from the other side");
            var cnt = myString.NumberWords();
            Assert.AreEqual(5, cnt);
        }

        [TestMethod]
        public void MyString_NunberWords_EmptyString()
        {
            var myString = new MyString("");
            var cnt = myString.NumberWords();

            Assert.AreEqual(0 , cnt);
        }

        [TestMethod]
        public void MyString_NunberWords_OneWordString()
        {
            var myString = new MyString("Hello");
            var cnt = myString.NumberWords();

            Assert.AreEqual(1 , cnt);
        }
    }
}
