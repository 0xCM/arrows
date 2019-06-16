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


    public class InXExtractTest : UnitTest<InXExtractTest>
    {
     
        void Extract128<T>()
            where T : struct
        {
            TypeCaseStart<T>();

            var len = Vec128<T>.Length;
            var src = Randomizer.Vec128<T>();
            var expect = span<T>(len);
            src.StoreTo(expect);
            for(byte i = 0; i< len; i++)
                Claim.eq(expect[i], ginx.extract(in src, i));

            TypeCaseEnd<T>();                

        }
            

        public void Extract128()
        {
            Extract128<byte>();
            Extract128<sbyte>();
            Extract128<short>();
            Extract128<ushort>();
            Extract128<int>();
            Extract128<uint>();
            Extract128<long>();
            Extract128<ulong>();
            Extract128<float>();
            Extract128<double>();
        }

        public void Extract256<T>()
            where T : struct
        {
            TypeCaseStart<T>();

            var len = Vec256<T>.Length;
            var half = len >> 1;
            var src = Randomizer.Vec256<T>();
            var srcData = src.StoreTo(span<T>(len));
            
            var x0 = ginx.extract(in src, 0);
            var y0 = x0.StoreTo(span<T>(half));
            var z0 = srcData.Slice(0, half);
            Claim.eq(y0,z0);

            var x1 = ginx.extract(in src, 1);
            var y1 = x1.StoreTo(span<T>(half));
            var z1 = srcData.Slice(half);
            Claim.eq(y1,z1);

            TypeCaseEnd<T>();                

        }
        
        public void Extract256()
        {
            Extract256<byte>();
            Extract256<sbyte>();
            Extract256<short>();
            Extract256<ushort>();
            Extract256<int>();
            Extract256<uint>();
            Extract256<long>();
            Extract256<ulong>();
            Extract256<float>();
            Extract256<double>();

        }


    }

}


