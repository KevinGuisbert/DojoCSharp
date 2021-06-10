using System;
using System.Collections.Generic;
using BenchmarkDotNet.Running;

namespace Dojo.Kata
{
    class Program
    {

        #region HackerRank Warm-Up

        private static void HR_SalesByMatch()
        {
            Console.WriteLine("- HackerRank - Sales By Match - ");

            //List<int> arrayValues = new List<int> { 1, 2, 1, 2, 1, 3, 2 };
            List<int> arrayValues = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int expected = 3;
            int result = HR._001_SalesByMatch.Kata.sockMerchantRemoving(9, arrayValues);
            if (result == expected)
            {
                Console.WriteLine($"Success: { result }");
            }

            Console.ReadKey();


            //BenchmarkRunner.Run<HR._001_SalesByMatch.Benchmark>();
        }

        private static void HR_CountingValleys()
        {
            Console.WriteLine("- HackerRank - Counting Valleys - ");
            int steps = 8;
            string path = "UDDDUDUU";
            int expected = 1;

            int result = HR._002_CountingValleys.Kata.countingValleys(steps, path);
            if (result == expected)
            {
                Console.WriteLine($"Success: { result }");
            }

            Console.ReadKey();

            //BenchmarkRunner.Run<HR._002_CountingValleys.BenchMark>();
        }

        private static void HR_JumpingOnTheClouds()
        {
            Console.WriteLine("- HackerRank - Jumping On The Clouds -");
            List<int> arrayValues = new List<int> { 0, 0, 1, 0, 0, 1, 0 };
            int expected = 4;

            int result = HR._003_JumpingOnTheClouds.Kata.jumpingOnClouds(arrayValues);
            if (result == expected)
            {
                Console.WriteLine($"Success: { result }");
            }

            Console.ReadKey();
        }

        #endregion

        #region 8KYU

        private static void _8KYU_SquareSum()
        {
            Console.WriteLine("- 8kyu - SquareSum - ");

            int[] n = { 1, 2, 2 };
            int expected = 9;
            int result = _8kyu._001_SquareSum.Kata.SquareSum(n);
            if (result == expected)
            {
                Console.WriteLine($"Success: { result }");
            }

            Console.ReadKey();
        }

        #endregion

        static void Main(string[] args)
        {

            //------------------------------
            // 8 KYU
            //------------------------------
            //_8KYU_SquareSum();

            //------------------------------
            // Hacker Rank Warm-up
            //------------------------------
            //HR_SalesByMatch();
            //HR_CountingValleys();
            HR_JumpingOnTheClouds();

        }
    }
}
