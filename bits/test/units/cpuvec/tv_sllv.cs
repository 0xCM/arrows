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

    public class tv_sllv : UnitTest<tv_sllv>
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

        public void sllv256u32()
        {
            var src = Polyrand.CpuVec256<uint>();
            var shifts = Polyrand.CpuVec256<uint>(closed(1u,7u));  

            var expect = src.ToSpan256();
            for(var i = 0; i < src.Length(); i ++)
                expect[i] = gbits.shiftl(src[i], shifts[i]);
            
            var v1 = expect.LoadVec256();
            var v2 = gbits.sllv(src, shifts);            

            Claim.eq(v1,v2);            
        }
        
        public void sslv128u32()
        {
            var src = Polyrand.CpuVec128<uint>();
            var shifts = Polyrand.CpuVec128<uint>(closed(1u,7u));            

            var expect = src.ToSpan128();
            for(var i = 0; i < src.Length(); i ++)
                expect[i] = gbits.shiftl(src[i], shifts[i]);
            
            var v1 = expect.LoadVec128();
            var v2 = gbits.sllv(src, shifts);            

            Claim.eq(v1,v2);            
        }

        public void sllv128u64()
        {
            var src = Polyrand.CpuVec128<ulong>();
            var shifts = Polyrand.CpuVec128<ulong>(closed(1ul,7ul));            

            var expect = src.ToSpan128();
            for(var i = 0; i < src.Length(); i ++)
                expect[i] = gbits.shiftl(src[i], shifts[i]);
            
            var v1 = expect.LoadVec128();
            var v2 = gbits.sllv(src, shifts);            

            Claim.eq(v1,v2);            
        }

        public void sllv256u64()
        {
            var src = Polyrand.CpuVec256<ulong>();
            var shifts = Polyrand.CpuVec256<ulong>(closed(1ul,7ul));            
            
            var expect = src.ToSpan256();
            for(var i = 0; i < src.Length(); i ++)
                expect[i] = gbits.shiftl(src[i], shifts[i]);
            
            var v1 = expect.LoadVec256();
            var v2 = gbits.sllv(src, shifts);            

            Claim.eq(v1,v2);            
        }

    }

}