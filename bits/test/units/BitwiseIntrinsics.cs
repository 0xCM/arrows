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

    public class BitwiseIntrinsics : UnitTest<BitwiseIntrinsics>
    {

        public void Nonzero()
        {
            Claim.yea(gbits.nonzero(Vec256.FromParts(1ul, 2ul, 3ul, 4ul)));
            Claim.yea(gbits.nonzero(Vec256.FromParts(1ul, 0ul, 0ul, 0ul)));
            Claim.nea(gbits.nonzero(Vec256.FromParts(0ul, 0ul, 0ul, 0ul)));

            Claim.yea(gbits.nonzero(Vec128.FromParts(1u, 2u, 3u, 4u)));
            Claim.yea(gbits.nonzero(Vec128.FromParts(1u, 0u, 0u, 0u)));
            Claim.nea(gbits.nonzero(Vec128.FromParts(0u, 0u, 0u, 0u)));
        }

        public void LeftShiftV256U32()
        {
            var src = Random.CpuVec256<uint>();
            var shifts = Random.CpuVec256<uint>(closed(1u,7u));  

            var expect = src.ToSpan256();
            for(var i = 0; i < src.Length(); i ++)
                expect[i] = gbits.shiftl(src[i], shifts[i]);
            
            var v1 = expect.LoadVec256();
            var v2 = gbits.shiftl(src, shifts);            

            Claim.eq(v1,v2);            
        }
        
        public void LeftShiftV128U32()
        {
            var src = Random.CpuVec128<uint>();
            var shifts = Random.CpuVec128<uint>(closed(1u,7u));            

            var expect = src.ToSpan128();
            for(var i = 0; i < src.Length(); i ++)
                expect[i] = gbits.shiftl(src[i], shifts[i]);
            
            var v1 = expect.LoadVec128();
            var v2 = gbits.shiftl(src, shifts);            

            Claim.eq(v1,v2);            
        }

        public void LeftShiftV128U64()
        {
            var src = Random.CpuVec128<ulong>();
            var shifts = Random.CpuVec128<ulong>(closed(1ul,7ul));            

            var expect = src.ToSpan128();
            for(var i = 0; i < src.Length(); i ++)
                expect[i] = gbits.shiftl(src[i], shifts[i]);
            
            var v1 = expect.LoadVec128();
            var v2 = gbits.shiftl(src, shifts);            

            Claim.eq(v1,v2);            
        }

        public void LeftShiftV256U64()
        {
            var src = Random.CpuVec256<ulong>();
            var shifts = Random.CpuVec256<ulong>(closed(1ul,7ul));            
            
            var expect = src.ToSpan256();
            for(var i = 0; i < src.Length(); i ++)
                expect[i] = gbits.shiftl(src[i], shifts[i]);
            
            var v1 = expect.LoadVec256();
            var v2 = gbits.shiftl(src, shifts);            

            Claim.eq(v1,v2);            
        }

    }

}