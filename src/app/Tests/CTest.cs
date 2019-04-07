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
        static void divRemTest<T>(int count, T min, T max)
            where T : IComparable<T>
        {
            var src1 = Rand.reals<T>(min, max).Take(count).Freeze();
            var src2 = Rand.reals<T>(min, max).Where(x => x.neq(x.zero)).Take(count).Freeze();
            var inputs = zip(src1,src2).Freeze();
            var expect = map(inputs, x => x.left.divrem(x.right)).Freeze();
            var actual = map(inputs, x => x.left.divrem(x.right)).Freeze();
                

            iter(inputs.Count, i => 
                require(actual[i].q == expect[i].q && actual[i].r == expect[i].r, 
                    inputs[i], expect[i], actual[i]));
        }

        static void absTest<T>(T input, T expect)
            where T : C.SInt<T>, new()
        {
            var actual = input.abs();
            require(actual.eq(expect), input, expect, actual);
        }

        public static void divRemTest()
        {
            var count = 5000;
            
            divRemTest(count, -250000,250000);
            divRemTest(count, -250000L,250000L);
            divRemTest(count, 0UL,5000000UL);
        }
        public static void absTests()
        {
            var src = Rand.primal(-250000,250000).Take(500).Freeze();
            var inputs = C.int32.define(src).Freeze();
            iter(inputs, x => absTest<C.int32>(x, Math.Abs(x)));            

        }

    }

}
