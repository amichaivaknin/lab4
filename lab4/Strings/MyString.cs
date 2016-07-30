using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    //Consider a better name
    public class MyString
    {
        readonly string[] _words;

        public MyString(string s)
        {
            //What about other white space chars? Or multiple of them?
            _words = s.Split(' ');
        }

        //Consider the use of String.Builder.
        public string Reverse()
        {
            var ret = "";

            for (var i = _words.Length - 1; i >= 0; i--)
                ret = ret + _words[i] + " ";

            ret = ret.Trim();
            return ret;
        }

        public int NumberWords()
        {
            return _words[0] == "" ? 0 : _words.Length;
        }

        public string Sort()
        {
            System.Array.Sort(_words);
            var ret = _words.Aggregate("", (current, word) => current + word + " ");
            ret = ret.Trim();
            return ret;

        }
    }
}
