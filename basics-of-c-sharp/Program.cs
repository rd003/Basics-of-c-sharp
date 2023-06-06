
using basics_of_c_sharp;
using BenchmarkDotNet.Running;

namespace BasicsOfCSharp;

public class Program
{
   static void Main()
    {
        var summary = BenchmarkRunner.Run<BenchmarkProjection>();
    }
}

