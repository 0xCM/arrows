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

    using Z0.Testing;
    
    [DisplayName("c")]
    public class CTests : UnitTest<CTests>
    {
        static void divRemTest<T>(int count, T min, T max)
            where T : struct, IEquatable<T>
        {
            var rand = Context.Random<T>();
            var src1 = reals(rand.stream(min, max).Take(count).Freeze());
            var src2 = reals(rand.stream(min, max)).Where(x => x.neq(x.zero)).Take(count).Freeze();
            var inputs = zip(src1,src2).ToList();
            var expect = map(inputs, x => x.left.divrem(x.right));
            var actual = map(inputs, x => x.left.divrem(x.right));

            for(var i = 0; i< inputs.Count; i++)
            {
                require(actual[i].q == expect[i].q && actual[i].r == expect[i].r, 
                    inputs[i], expect[i], actual[i]);

            }
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
            var rand = Context.Random<int>();
            var src = rand.stream(-250000,250000).Take(500).Freeze();
            var inputs = C.int32.define(src).Freeze();
            iter(inputs, x => absTest<C.int32>(x, Math.Abs(x)));            

        }

    }

}
