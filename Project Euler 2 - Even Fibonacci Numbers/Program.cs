using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// By considering the terms in the Fibonacci sequence 
// whose values do not exceed four million, find the sum of the even-valued terms.

namespace Project_Euler_2___Even_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 4000000; // We don't want to check any Fibonacci numbers higher than this.
            int[] fnumbers = { 1, 2 };  // This array always contains the two most recent fibonacci numbers.
            int nextnumber = 3; // The next Fibonacci number in the sequence.
            int sum = 0; // The running total of even Fibo' numbers.
            while (fnumbers[0] < limit)
            {
                if ((fnumbers[0] % 2) == 0) sum += fnumbers[0]; // If dividing by 2 leaves no remainder, add it to the sum
                fnumbers = ContinueSequence(fnumbers, nextnumber); 
                nextnumber = fnumbers[0] + fnumbers[1];  // Get rid of the oldest number in the sequence, generate a new one.

            }
            Console.WriteLine(sum.ToString());
            Console.ReadKey();
        }
        static int[] ContinueSequence(int[] fnumbers, int nextnumber)
        {
            fnumbers[0] = fnumbers[1];
            fnumbers[1] = nextnumber;
            return fnumbers;
        }

    }
}
