using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace Dojo.Kata.HR._002_CountingValleys
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class BenchMark
    {
        int steps = 8;
        string path = "UDDDUDUU";


        [Benchmark]
        public void countingValleys()
        {
            Kata.countingValleys(steps, path);
        }

    }
}
