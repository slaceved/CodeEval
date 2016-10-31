using System;

namespace OddNumbers
{
    /// <summary>
    /// Return all odd numbers from 1 - 99 on separte lines
    /// </summary>
    public class Solution
    {
        public static void Main(string[] args)
        {
            for (var i = 1; i < 100; i++)
            {
                if (i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }
}
