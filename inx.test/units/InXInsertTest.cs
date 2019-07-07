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

    public class InXInsertTest : UnitTest<InXInsertTest>
    {
        void Insert<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            for(var i=0; i < Pow2.T06; i++)
            {
                var v128Src = Random.Vec128<T>();
                var srcSpan = v128Src.Extract();

                var dst = Vec256.zero<T>();
                
                var vLo = ginx.insert(v128Src, dst,0);
                var vLoSpan = vLo.Extract().Slice(0, vLo.Length()/2);

                var vHi = ginx.insert(v128Src, dst, 1);
                var vHiSpan = vHi.Extract().Slice(vLo.Length()/2);

                Claim.eq(srcSpan, vLoSpan);
                Claim.eq(srcSpan, vHiSpan);
            }
            TypeCaseEnd<T>();
        }
        

        public void Insert128Into256()
        {
            Insert<byte>();            
            Insert<sbyte>();
            Insert<short>();
            Insert<ushort>();
            Insert<int>();
            Insert<uint>();
            Insert<long>();
            Insert<ulong>();
            Insert<float>();
            Insert<double>();
        
        }
    }

}
