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
        Duration Eq128<T>(N128 bits, int blocks)
            where T : struct
        {
            var src = Randomizer.Span128<T>(blocks); 
            var sw = stopwatch();
            for(var block = 0; block< src.BlockCount; block++)
            {
                var v1 = src.Vector(block);
                var v2 = src.Vector(block);                                
                var eq = ginx.cmpeq(v1,v2);
                Claim.@true(eq);
            }         
            TypeStepOk<T>();
            return snapshot(sw);
        }
        
        Duration Eq256<T>(N256 bits, int blocks)
            where T : struct
        {
            var src = Randomizer.Span256<T>(blocks); 
            var sw = stopwatch();
            for(var block = 0; block< src.BlockCount; block++)
            {
                var v1 = src.Vector(block);
                var v2 = src.Vector(block);                                
                var eq = ginx.cmpeq(v1,v2);
                Claim.@true(eq);
            }           
            TypeStepOk<T>();
            return snapshot(sw);

        }

        public void TestEq()
        {
            var blocks = Pow2.T08;
            var n128 = N128.Rep;
            var n256 = N256.Rep;
            Eq128<byte>(n128, blocks);
            Eq128<sbyte>(n128, blocks);
            Eq128<short>(n128, blocks);
            Eq128<ushort>(n128, blocks);
            Eq128<int>(n128, blocks);
            Eq128<uint>(n128, blocks);
            Eq128<long>(n128, blocks);
            Eq128<ulong>(n128, blocks);
            Eq128<float>(n128, blocks);
            Eq128<double>(n128, blocks);
            Eq256<byte>(n256, blocks);
            Eq256<sbyte>(n256, blocks);
            Eq256<short>(n256, blocks);
            Eq256<ushort>(n256, blocks);
            Eq256<int>(n256, blocks);
            Eq256<uint>(n256, blocks);
            Eq256<long>(n256, blocks);
            Eq256<ulong>(n256, blocks);
        }
    }

}