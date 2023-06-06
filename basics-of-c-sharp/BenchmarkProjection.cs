using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics_of_c_sharp
{
    [MemoryDiagnoser]
    public class BenchmarkProjection
    {
        private int[] data;
        // 1000, 10,000
        [Params(1000,10000)]
        public int ArraySize;

        [GlobalSetup]
        public void GlobalSetup()
        {
            // arraySize=1000, data= [0,1,2.....999]
            data = Enumerable.Range(0, ArraySize).ToArray();
        }

        // [1,2,3,4] => [1*1,2*2,3*3,4*4] = [1,4,9,16]
        [Benchmark(Baseline =true)]
        public int[] ProjectWithForLoop()
        {
            var result = new int[ArraySize];

            for (int i = 0; i < ArraySize; i++)
            {
                result[i] = data[i] * data[i];
            }
            return result;
        }

        [Benchmark]
        public int[] ProjectWithLINQ()
        {
            return data.Select(x => x * x).ToArray();
        }

    }
}
