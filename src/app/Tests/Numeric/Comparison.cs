//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;


    using static Nats;
    using static zcore;


    public class NumericComparison
    {
        static readonly RandUInt Random = Context.Random;


        public static void NumericSliceEquality()
        {
            var  src1 = Random.next(5, Byte.MinValue, Byte.MaxValue).ToSlice();
            inform(Claim.eq(src1, src1));

            var  src2 = Random.next(5, UInt16.MinValue, UInt16.MaxValue).ToSlice();
            inform(Claim.eq(src2, src2));

            var  src3 = Random.next(5, UInt32.MinValue, UInt32.MaxValue).ToSlice();
            inform(Claim.eq(src3, src3));

        }


    }

}