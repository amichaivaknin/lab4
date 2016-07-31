using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    class Program
    {
        static int[] CalcPrimes(int i, int j)
        {
            var primes = new ArrayList();
            while (i < j)
            {
                //1.consider the use of better names
                //2. is this a flag? Why it isn't a boolean?
                var fl = 0;

                //Actually you can stop at sqrt(i)
                for (var k = 2; k <= i/2; k++)
                {
                    //1. The convention in C# is to start body-expressions in a seperate line with bracets, even for one liners.
                    //2. You don't need to continue...'else' will do the job.
                    if (i%k != 0)
                    {
                        continue;
                    }
                    fl = 1;
                    break;
                }

                if (fl == 0)
                {
                    if(i!=1)
                    primes.Add(i);
                }
                ++i;
            }

            var rp= new int[primes.Count];
             primes.CopyTo(rp);
            return rp;

        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter two numbers");
            var readLine = Console.ReadLine();

            //Consider string.IsNullOrEmpty
            if (readLine != null)
            {
                string[] numbers = readLine.Split();
                var i = int.Parse(numbers[0]);
                var j = int.Parse(numbers[1]);
                var primeArr = CalcPrimes(i, j);

                foreach (int prime in primeArr)
                {
                    Console.WriteLine(prime);
                }
            }
            

        }
    }
}
