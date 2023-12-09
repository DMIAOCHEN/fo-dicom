﻿// Copyright (c) 2012-2023 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).
#nullable disable

using BenchmarkDotNet.Running;

namespace FellowOakDicom.Benchmark
{
    static class Program
    {
        static void Main()
        {
            // Run all benchmarks in assembly
            BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
