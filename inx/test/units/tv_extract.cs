//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    using static zfunc;

    public class tv_extract : UnitTest<tv_extract>
    {     
        public void extract128()
        {
            extract128_check<byte>();
            extract128_check<sbyte>();
            extract128_check<short>();
            extract128_check<ushort>();
            extract128_check<int>();
            extract128_check<uint>();
            extract128_check<long>();
            extract128_check<ulong>();
            extract128_check<float>();
            extract128_check<double>();

        }

        public void extract256()
        {
            extract256_check<byte>();
            extract256_check<sbyte>();
            extract256_check<short>();
            extract256_check<ushort>();
            extract256_check<int>();
            extract256_check<uint>();
            extract256_check<long>();
            extract256_check<ulong>();
            extract256_check<float>();
            extract256_check<double>();
            
        }

        void extract128_check<T>()
            where T : unmanaged
        {
            TypeCaseStart<T>();

            var len = Vec128<T>.Length;
            var src = Random.CpuVec128<T>();
            var expect = span<T>(len);
            src.ToSpan(expect);
            for(byte i = 0; i< len; i++)
                Claim.eq(expect[i], ginx.extract(in src, i));

            TypeCaseEnd<T>();                
        }
            
        public void extract256_check<T>()
            where T : unmanaged
        {
            TypeCaseStart<T>();

            var len = Vec256<T>.Length;
            var half = len >> 1;
            var src = Random.CpuVec256<T>();
            var srcData = src.ToSpan(span<T>(len));
            
            var x0 = ginx.extract128(in src,0);
            var y0 = x0.ToSpan(span<T>(half));
            var z0 = srcData.Slice(0, half);
            Claim.eq(y0,z0);

            var x1 = ginx.extract128(in src,1);
            var y1 = x1.ToSpan(span<T>(half));
            var z1 = srcData.Slice(half);
            Claim.eq(y1,z1);

            TypeCaseEnd<T>();                
        }

    }
}