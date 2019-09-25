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
    using D = BitwiseDelegates;

    public class tv_flip : UnitTest<tv_flip>
    {

        public void flip128()
        {
            
            Flip128<byte>();
            Flip128<sbyte>();
            Flip128<short>();
            Flip128<ushort>();
            Flip128<int>();
            Flip128<uint>();
        }
        
        public void flip256()
        {
            
            Flip256<byte>();
            Flip256<sbyte>();
            Flip256<short>();
            Flip256<ushort>();
            Flip256<int>();
            Flip256<uint>();
            Flip256<long>();
            Flip256<ulong>();
        }

        void Flip128<T>()
            where T : unmanaged
        {
            TypeCaseStart<T>();
            for(var i=0; i<Pow2.T06; i++)                        
            {
                var src = Random.CpuVec128<T>();
                var srcData = src.ToSpan();
                var expect  = Vec128.Load(ref mathspan.flip(srcData)[0]);
                var actual = gbits.flip(in src);
                Claim.yea(expect.Equals(actual));
            }
            TypeCaseEnd<T>();            
        }

        void Flip256<T>()
            where T : unmanaged
        {
            TypeCaseStart<T>();
            for(var i=0; i<Pow2.T06; i++)                        
            {
                var src = Random.CpuVec256<T>();
                var srcData = src.ToSpan();
                var expect  = Vec256.Load(ref mathspan.flip(srcData)[0]);
                var actual = gbits.flip(in src);
                Claim.yea(expect.Equals(actual));
            }
            TypeCaseEnd<T>();            
        }

    }
}