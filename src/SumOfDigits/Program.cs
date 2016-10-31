using System;

namespace SumOfDigits
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var reader = Console.OpenStandardInput();
            while (reader.CanRead)
            {
                var input = int.Parse(Console.ReadLine());
                var n = Math.Abs(input);
                var sum = 0;
                while (n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
