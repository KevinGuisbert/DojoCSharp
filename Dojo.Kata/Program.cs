using System;

namespace Dojo.Kata
{
    class Program
    {

        private static void Call8kyu(int Kata)
        {
            switch (Kata)
            {
                case 1:
                    Console.WriteLine("- 8kyu - SquareSum - ");

                    int[] n = { 1, 2, 2 };
                    int expected = 9;
                    int result = _8kyu._001_SquareSum.after.Kata.SquareSum(n);
                    if (result == expected)
                    {
                        Console.WriteLine($"Success: { result }");
                    }

                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            Call8kyu(1);
        }
    }
}
