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
    
    using static mfunc;
    using static zfunc;


    public class InXBitwiseOps : UnitTest<InXBitwiseOps>
    {
        public void TestAllOn()
        {
            var v1 = Vec128.define(uint.MaxValue, uint.MaxValue, uint.MaxValue, uint.MaxValue);
            Claim.@true(dinx.allOn(v1));

            var v2 = Vec128.define(uint.MaxValue, uint.MaxValue - 1, uint.MaxValue, uint.MaxValue);
            Claim.@false(dinx.allOn(v2));                
        }     

        public void LeftShiftV256U32()
        {
            var src = Randomizer.Vec256<uint>();
            var shifts = Randomizer.Vec256<uint>(closed(1u,7u));            
            
            var expect = src.ToSpan();
            for(var i = 0; i < src.Length(); i ++)
                expect[i] = gmath.lshift(src[i], shifts[i]);
            
            var v1 = expect.Vector();
            var v2 = ginx.lshiftv(src, shifts);            

            Claim.eq(v1,v2);            
        }
        
        public void LeftShiftV128U32()
        {
            var src = Randomizer.Vec128<uint>();
            var shifts = Randomizer.Vec128<uint>(closed(1u,7u));            

            var expect = src.ToSpan();
            for(var i = 0; i < src.Length(); i ++)
                expect[i] = gmath.lshift(src[i], shifts[i]);
            
            var v1 = expect.Vector();
            var v2 = ginx.lshiftv(src, shifts);            

            Claim.eq(v1,v2);            
        }

        public void LeftShiftV128U64()
        {
            var src = Randomizer.Vec128<ulong>();
            var shifts = Randomizer.Vec128<ulong>(closed(1ul,7ul));            

            var expect = src.ToSpan();
            for(var i = 0; i < src.Length(); i ++)
                expect[i] = gmath.lshift(src[i], shifts[i]);
            
            var v1 = expect.Vector();
            var v2 = ginx.lshiftv(src, shifts);            

            Claim.eq(v1,v2);            
        }

        public void LeftShiftV256U64()
        {
            var src = Randomizer.Vec256<ulong>();
            var shifts = Randomizer.Vec256<ulong>(closed(1ul,7ul));            
            
            var expect = src.ToSpan();
            for(var i = 0; i < src.Length(); i ++)
                expect[i] = gmath.lshift(src[i], shifts[i]);
            
            var v1 = expect.Vector();
            var v2 = ginx.lshiftv(src, shifts);            

            Claim.eq(v1,v2);            
        }

    }

}