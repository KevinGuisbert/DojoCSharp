using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace Dojo.Kata.HR._001_SalesByMatch
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class Benchmark
    {
        //private List<int> arrayValues = new List<int> { 1, 2, 1, 2, 1, 3, 2 };
        private List<int> arrayValues = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
        private int arrayLength;

        [Benchmark]
        public void sockMerchant()
        {
            arrayLength = arrayValues.Count;

            Kata.sockMerchant(arrayLength, arrayValues);
        }

        [Benchmark]
        public void sockMerchantAuxiliarArray()
        {
            arrayLength = arrayValues.Count;

            Kata.sockMerchantAuxiliarArray(arrayLength, arrayValues);
        }

        [Benchmark]
        public void sockMerchantRemoving()
        {
            arrayLength = arrayValues.Count;

            Kata.sockMerchantRemoving(arrayLength, arrayValues);
        }
    }
}
