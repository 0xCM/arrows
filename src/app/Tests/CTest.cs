//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.ComponentModel;

    using static Nats;
    using static zcore;
    using static ztest;

    
    [DisplayName("c")]
    public class CTests
    {
        static readonly int DefaultSampleCount = 500;

        static void absTest<T>(int count, T min, T max)
        {
            var inputs = Rand.values<T>(count, min, max).Freeze();
            var expect = map(inputs, s => s.abs()).Freeze();
            var signable = C.signable<T>();
            var actual = map(inputs, s => signable.abs(s)).Freeze();

            iter(inputs.Count, i => 
                require(actual[i] == expect[i], inputs[i], expect[i], actual[i]));
        }

        static void divRemTest<T>(int count, T min, T max)
            where T : IComparable<T>
        {
            var src1 = Rand.values<T>(min, max).Take(count).Freeze();
            var src2 = Rand.values<T>(min, max).Where(x => x.neq(x.zero)).Take(count).Freeze();
            var inputs = zip(src1,src2).Freeze();
            var expect = map(inputs, x => x.left.divrem(x.right)).Freeze();
            var signable = C.signable<T>();
            var actual = map(inputs, x => signable.divrem(x.left, x.right)).Freeze();
                

            iter(inputs.Count, i => 
                require(actual[i].q == expect[i].q && actual[i].r == expect[i].r, 
                    inputs[i], expect[i], actual[i]));
        }

        public static void absTests()
        {
            absTest(DefaultSampleCount, Int32.MinValue, Int32.MaxValue);
            absTest(DefaultSampleCount, Int16.MinValue, Int16.MaxValue);
            absTest(DefaultSampleCount, Int32.MinValue, Int32.MaxValue);
            absTest(DefaultSampleCount, Int64.MinValue, Int64.MaxValue);
        }

        public static void divRemTests()
        {
            divRemTest(DefaultSampleCount, Int32.MinValue, Int32.MaxValue);
            divRemTest(DefaultSampleCount, Int16.MinValue, Int16.MaxValue);
            divRemTest(DefaultSampleCount, Int32.MinValue, Int32.MaxValue);
            divRemTest(DefaultSampleCount, Int64.MinValue, Int64.MaxValue);
        }

        const int PerfIter = 5*10*10*10*10*10*2;

        public static void divRemPerfUnwrapped()
        {
            var count = PerfIter; 
            var min = Int32.MinValue;
            var max = Int32.MaxValue;
            var src1 = Rand.values<int>(min, max).Take(count).Freeze();
            var src2 = Rand.values<int>(min, max).Where(x => x.neq(x.zero)).Take(count).Freeze();
            var inputs = zip(src1,src2).Freeze();
            var signable = C.signable<int>();
            var actual = map(inputs, x => signable.divrem(x.left, x.right)).Freeze();
            tell($"Executed {actual.Count} unwrapped divrem operations");

        }

        public static void divRemPerfWrappedA()
        {
            var count = PerfIter; 
            var min = Int32.MinValue;
            var max = Int32.MaxValue;
            var src1 = Rand.values<int>(min, max).Take(count).Freeze();
            var src2 = Rand.values<int>(min, max).Where(x => x.neq(x.zero)).Take(count).Freeze();
            var inputs = zip(src1.Select(x => C.num(x)),src2.Select(x => C.num(x))).Freeze();
            var actual = map(inputs, x => C.Inhabitant.divrem(x.left, x.right)).Freeze();
            tell($"Executed {actual.Count} wrapped divrem operations");
        }

        public static void divRemPerfWrappedB()
        {
            var count = PerfIter; 
            var min = Int32.MinValue;
            var max = Int32.MaxValue;
            var src1 = Rand.values<int>(min, max).Take(count).Freeze();
            var src2 = Rand.values<int>(min, max).Where(x => x.neq(x.zero)).Take(count).Freeze();
            var inputs = zip(src1.Select(x => Z0.int32.define(x)),src2.Select(x => Z0.int32.define(x))).Freeze();            
            var actual = map(inputs, x => x.left.divrem(x.right)).Freeze();
            tell($"Executed {actual.Count} wrapped divrem operations");
        }

        public static void divRemPerfG()
        {
            var count = PerfIter; 
            var min = Int32.MinValue;
            var max = Int32.MaxValue;
            var src1 = Rand.values<int>(min, max).Take(count).Freeze();
            var src2 = Rand.values<int>(min, max).Where(x => x.neq(x.zero)).Take(count).Freeze();
            var inputs = zip(src1.ToIntG(),src2.ToIntG()).Freeze();            
            var actual = map(inputs, x => x.left.divrem(x.right)).Freeze();
            tell($"Executed {actual.Count} wrapped divrem operations");
        }

    }

}
