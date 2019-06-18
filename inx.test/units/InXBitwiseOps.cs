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


    public class InXBitwiseOps : UnitTest<InXBitwiseOps>
    {
        public void TestAllOn()
        {
            var v1 = Vec128.define(uint.MaxValue, uint.MaxValue, uint.MaxValue, uint.MaxValue);
            var v2 = Vec128.ones<uint>();
            Claim.eq(v1,v2);

            // Claim.@true(dinx.on(in v1));

            // var v = Random.NextVec128<uint>();
            // Claim.@false(dinx.on(v));

        }     

        public void Nonzero()
        {
            Claim.@true(ginx.nonzero(Vec256.define(1ul, 2ul, 3ul, 4ul)));
            Claim.@true(ginx.nonzero(Vec256.define(1ul, 0ul, 0ul, 0ul)));
            Claim.@false(ginx.nonzero(Vec256.define(0ul, 0ul, 0ul, 0ul)));

            Claim.@true(ginx.nonzero(Vec128.define(1u, 2u, 3u, 4u)));
            Claim.@true(ginx.nonzero(Vec128.define(1u, 0u, 0u, 0u)));
            Claim.@false(ginx.nonzero(Vec128.define(0u, 0u, 0u, 0u)));
        }

        public void LeftShiftV256U32()
        {
            var src = Random.NextVec256<uint>();
            var shifts = Random.NextVec256<uint>(closed(1u,7u));  

            var expect = src.ToSpan();
            for(var i = 0; i < src.Length(); i ++)
                expect[i] = gbits.shiftl(src[i], shifts[i]);
            
            var v1 = expect.ToVec256();
            var v2 = ginx.shiftl(src, shifts);            

            Claim.eq(v1,v2);            
        }
        
        public void LeftShiftV128U32()
        {
            var src = Random.NextVec128<uint>();
            var shifts = Random.NextVec128<uint>(closed(1u,7u));            

            var expect = src.ToSpan();
            for(var i = 0; i < src.Length(); i ++)
                expect[i] = gbits.shiftl(src[i], shifts[i]);
            
            var v1 = expect.ToVec128();
            var v2 = ginx.shiftl(src, shifts);            

            Claim.eq(v1,v2);            
        }

        public void LeftShiftV128U64()
        {
            var src = Random.NextVec128<ulong>();
            var shifts = Random.NextVec128<ulong>(closed(1ul,7ul));            

            var expect = src.ToSpan();
            for(var i = 0; i < src.Length(); i ++)
                expect[i] = gbits.shiftl(src[i], shifts[i]);
            
            var v1 = expect.ToVec128();
            var v2 = ginx.shiftl(src, shifts);            

            Claim.eq(v1,v2);            
        }

        public void LeftShiftV256U64()
        {
            var src = Random.NextVec256<ulong>();
            var shifts = Random.NextVec256<ulong>(closed(1ul,7ul));            
            
            var expect = src.ToSpan();
            for(var i = 0; i < src.Length(); i ++)
                expect[i] = gbits.shiftl(src[i], shifts[i]);
            
            var v1 = expect.ToVec256();
            var v2 = ginx.shiftl(src, shifts);            

            Claim.eq(v1,v2);            
        }

    }

}