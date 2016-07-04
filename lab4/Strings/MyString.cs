﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class MyString
    {
        readonly string[] _words;

        public MyString(string s)
        {
            _words = s.Split(' ');
        }

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
