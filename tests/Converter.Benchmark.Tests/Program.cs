﻿namespace Converter.Benchmark.Tests;

using System;
using BenchmarkDotNet.Running;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("Running Benchmarks...");

        BenchmarkRunner.Run<DoubleBenchies>();
        BenchmarkRunner.Run<FloatBenchies>();
        BenchmarkRunner.Run<IntBenchies>();
        BenchmarkRunner.Run<LongBenchies>();
        BenchmarkRunner.Run<StringBenchies>();
    }
}
