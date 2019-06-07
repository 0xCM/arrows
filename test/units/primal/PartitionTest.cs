//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;


    public class PartitionTest : UnitTest<PartitionTest>
    {        

        void TestClosed<T>(T min, T max, T? width = null)
            where T : struct
        {
            var partition = closed(min, max).PartitionPoints(width);
            
            var firstExpect = min;
            var firstActual = partition[0];

            var lastExpect = max;
            var lastActual = partition[partition.Length - 1];

            Claim.eq(firstExpect, firstActual);
            Claim.eq(lastExpect, lastActual);

        }

        void TestOpen<T>(T min, T max, T width)
            where T : struct
        {
            var partition = open(min, max).PartitionPoints(width);            
            var first = partition[0];
            var last = partition[partition.Length - 1];
            var countActual = partition.Length;
            gmath.width(min, max, out T distance);
            var countExpect = convert<T,int>(gmath.div(distance,width), out int x);
            
            Claim.eq(countExpect, countActual);
            Claim.@true(gmath.gt(first, min));
            Claim.@true(gmath.lt(last, max));

        }

        public void PartitionOpenInterval()
        {
            TestOpen(0, 99, 1);
            TestOpen(0.0, 99.0, 1.0);
            TestOpen(0.0, 100, 0.5);
            TestOpen(0.0, 100, 0.72);

        }
        public void PartitionClosedInterval()
        {
            TestClosed((byte)3, (byte)57);
            TestClosed(Byte.MinValue, Byte.MaxValue);
            TestClosed((sbyte)0, SByte.MaxValue);            
            TestClosed((short)-200, (short)57);            
            TestClosed(0, 99);
            TestClosed(0u,99u);
            TestClosed(0L, 99L);
            TestClosed(0ul,99ul);
            TestClosed(-250.75, 100.20);
            TestClosed(-250.75f, 100.20f);

            TestClosed(100, 233, 5);
            TestClosed(100, 234, 5);
            TestClosed(100, 235, 5);
            TestClosed(-100, 75, 3);
        }

    }

}