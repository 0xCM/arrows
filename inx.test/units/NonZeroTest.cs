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


    public class NonZeroTest : UnitTest<NonZeroTest>
    {

        void NonZero128<T>(int blocks)
            where T : struct
        {
            TypeCaseStart<T>();
            var  src = Random.Span128<T>(blocks);
            for(var i = 0; i< blocks; i++)
            {
                var v = Vec128.Load(ref src.Block(i));
                Claim.yea(gbits.nonzero(v));
            }
            
            Claim.nea(gbits.nonzero(Vec128.Zero<T>()));
            TypeCaseEnd<T>();
        }

        void NonZero256<T>(int blocks)
            where T : struct
        {
            TypeCaseStart<T>();
            var  src = Random.Span256<T>(blocks);
            for(var i = 0; i< blocks; i++)
            {
                var v = Vec256.Load(ref src.Block(i));
                Claim.yea(gbits.nonzero(v));
            }
            
            Claim.nea(gbits.nonzero(Vec256.Zero<T>()));
            TypeCaseEnd<T>();
        }

        public void NonZero()
        {
            var blocks = Pow2.T08;
            NonZero128<sbyte>(blocks);
            NonZero128<byte>(blocks);
            NonZero128<short>(blocks);
            NonZero128<ushort>(blocks);
            NonZero128<int>(blocks);
            NonZero128<uint>(blocks);
            NonZero128<long>(blocks);
            NonZero128<ulong>(blocks);

            NonZero256<sbyte>(blocks);
            NonZero256<byte>(blocks);
            NonZero256<short>(blocks);
            NonZero256<ushort>(blocks);
            NonZero256<int>(blocks);
            NonZero256<uint>(blocks);
            NonZero256<long>(blocks);
            NonZero256<ulong>(blocks);

        }

    }

}