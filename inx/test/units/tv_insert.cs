//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class tv_insert : UnitTest<tv_insert>
    {
        public void insert128()
        {
            insert128_check<byte>();            
            insert128_check<sbyte>();
            insert128_check<short>();
            insert128_check<ushort>();
            insert128_check<int>();
            insert128_check<uint>();
            insert128_check<long>();
            insert128_check<ulong>();
            insert128_check<float>();
            insert128_check<double>();
        
        }

        void insert128_check<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            for(var i=0; i < Pow2.T06; i++)
            {
                var v128Src = Random.CpuVec128<T>();
                var srcSpan = v128Src.ToSpan();

                var dst = Vec256.Zero<T>();
                
                var vLo = ginx.insert(v128Src, dst,0);
                var vLoSpan = vLo.ToSpan().Slice(0, vLo.Length()/2);

                var vHi = ginx.insert(v128Src, dst, 1);
                var vHiSpan = vHi.ToSpan().Slice(vLo.Length()/2);

                Claim.eq(srcSpan, vLoSpan);
                Claim.eq(srcSpan, vHiSpan);
            }
            TypeCaseEnd<T>();
        }
        

    }

}
