using System;

namespace SumOfDigits2
{
    internal class Solution
    {
        public static void Main(string[] args)
        {
            const int tenOver10000 = ((1 << 25)/1000 + 1); // .001 Q25
            string input;
            while ((input = Console.ReadLine()) != null)
            {
                var n = Math.Abs(int.Parse(input));
                var sum = 0;
                int c;
                n = (n * tenOver10000) >> 9; // n*10/10000 Q16
                for (c = 0; c < 4; c++)
                {
                    sum += n >> 16;
                    n = (n & 0xffff) * 10; // next digit
                }
                Console.WriteLine(sum);
            }
        }
    }
}
