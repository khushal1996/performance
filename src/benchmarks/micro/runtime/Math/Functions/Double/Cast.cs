// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using BenchmarkDotNet.Attributes;
using MicroBenchmarks;
using System.Diagnostics;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics;

namespace System.MathBenchmarks
{
    public partial class Double
    {
        private const double val = 1.0;
		private const ulong uval = 2;

        [Benchmark]
		[MethodImplAttribute(MethodImplOptions.NoInlining)]
        public ulong ConvDoubleToUlongBM() => ConvDoubleToUlong(val);
		
		[MethodImplAttribute(MethodImplOptions.NoInlining)]
        public static ulong ConvDoubleToUlong(double dvalue)
        {
			return (ulong)dvalue;
        }
		
		[Benchmark]
		[MethodImplAttribute(MethodImplOptions.NoInlining)]
        public double ConvUlongToDoubleBM() => ConvUlongToDouble(uval);
		
		[MethodImplAttribute(MethodImplOptions.NoInlining)]
        public static double ConvUlongToDouble(ulong dvalue)
        {
			return (double)dvalue;
        }
		
		[Benchmark]
		[MethodImplAttribute(MethodImplOptions.NoInlining)]
        public float ConvUlongToFloatBM() => ConvUlongToFloat(uval);
		
		[MethodImplAttribute(MethodImplOptions.NoInlining)]
        public static float ConvUlongToFloat(ulong dvalue)
        {
			return (float)dvalue;
        }
    }
}
