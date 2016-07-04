using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter string");
                var s = Console.ReadLine();
                if (s == "")
                {
                    return;
                }
                MyString str = new MyString(s);
                Console.WriteLine(str.NumberWords());
                s = str.Reverse();
                Console.WriteLine(s);
                s = str.Sort();
                Console.WriteLine(s);

            }
        }
    }
}
