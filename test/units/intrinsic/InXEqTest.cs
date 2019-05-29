//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;


    public class InXEqTest : UnitTest<InXEqTest>
    {
        Duration TestEq<T>(N128 bits, int blocks)
            where T : struct
        {
            var src = Randomizer.Span128<T>(blocks); 
            var sw = stopwatch();
            for(var block = 0; block< src.BlockCount; block++)
            {
                var v1 = src.Vector(block);
                var v2 = src.Vector(block);                                
                var eq = ginx.eq(v1,v2);
                for(var i =0; i< eq.Length; i++)
                    Claim.@true(eq[i]);
            }           
            return snapshot(sw);
        }
        Duration TestEq<T>(N256 bits, int blocks)
            where T : struct
        {
            var src = Randomizer.Span256<T>(blocks); 
            var sw = stopwatch();
            for(var block = 0; block< src.BlockCount; block++)
            {
                var v1 = src.Vector(block);
                var v2 = src.Vector(block);                                
                var eq = ginx.eq(v1,v2);
                for(var i =0; i< eq.Length; i++)
                    Claim.@true(eq[i]);
            }           
            return snapshot(sw);

        }

        public void TestEq()
        {
            var blocks = Pow2.T08;
            var n128 = N128.Rep;
            var n256 = N256.Rep;
            TestEq<byte>(n128, blocks);
            TestEq<sbyte>(n128, blocks);
            TestEq<short>(n128, blocks);
            TestEq<ushort>(n128, blocks);
            TestEq<int>(n128, blocks);
            TestEq<uint>(n128, blocks);
            TestEq<long>(n128, blocks);
            TestEq<ulong>(n128, blocks);
            TestEq<float>(n128, blocks);
            TestEq<double>(n128, blocks);
            TestEq<byte>(n256, blocks);
            TestEq<sbyte>(n256, blocks);
            TestEq<short>(n256, blocks);
            TestEq<ushort>(n256, blocks);
            TestEq<int>(n256, blocks);
            TestEq<uint>(n256, blocks);
            TestEq<long>(n256, blocks);
            TestEq<ulong>(n256, blocks);
        }
    }

}