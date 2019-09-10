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


    public class tv_nonzero : UnitTest<tv_nonzero>
    {
        public void nonzero128()
        {
            nonzero128_check<sbyte>();
            nonzero128_check<byte>();
            nonzero128_check<short>();
            nonzero128_check<ushort>();
            nonzero128_check<int>();
            nonzero128_check<uint>();
            nonzero128_check<long>();
            nonzero128_check<ulong>();
        }

        public void nonzero256()
        {
            nonzero256_check<sbyte>();
            nonzero256_check<byte>();
            nonzero256_check<short>();
            nonzero256_check<ushort>();
            nonzero256_check<int>();
            nonzero256_check<uint>();
            nonzero256_check<long>();
            nonzero256_check<ulong>();

        }

        void nonzero128_check<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var  src = Random.Span128<T>(blocks: SampleSize);
            for(var i = 0; i< src.BlockCount; i++)
            {
                var v = Vec128.Load(ref src.Block(i));
                Claim.yea(gbits.nonzero(v));
            }
            
            Claim.nea(gbits.nonzero(Vec128.Zero<T>()));
            TypeCaseEnd<T>();
        }

        void nonzero256_check<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var  src = Random.Span256<T>(blocks: SampleSize);
            for(var i = 0; i< src.BlockCount; i++)
            {
                var v = Vec256.Load(ref src.Block(i));
                Claim.yea(gbits.nonzero(v));
            }
            
            Claim.nea(gbits.nonzero(Vec256.Zero<T>()));
            TypeCaseEnd<T>();
        }

    }

}