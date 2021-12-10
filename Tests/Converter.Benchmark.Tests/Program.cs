namespace Converter.Benchmark.Tests
{
    using System;
    using BenchmarkDotNet.Running;

    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Running Benchmarks...");

            var summary = BenchmarkRunner.Run<CelsiusDoubleBenchies>();
        }
    }
}
