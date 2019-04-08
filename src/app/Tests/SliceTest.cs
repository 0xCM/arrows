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
    using System.ComponentModel;

    using Z0.Testing;

    using static Nats;
    using static zcore;
    using static ztest;

    
    [DisplayName("slice")]
    public class SliceTest    
    {
        static readonly Randomizer Random = Context.Random;


        public static void equality()
        {
            var src1 = Rand.slice(5, real(50),  real(150));
            Claim.eq(src1, src1);

            var  src2 = Rand.slice(5, real(-150), real(250));
            Claim.eq(src2, src2);

            var  src3 = Rand.slice(5, Z0.real<uint>.MinVal, Z0.real<uint>.MaxVal);
            Claim.eq(src3, src3);

        }

        const int IterCount = 75000;

        public static intg<long>[] iterG()
        {
            long len = IterCount;
            var squares = new intg<long>[len];
            iterg<long>(0L,len, i => squares[i] = i * i);            
            return squares;
        }


        public static long[] iterDirect()
        {
            var len = IterCount;
            var squares = new long[len];
            for(var i = 0L; i<len; i++)
                squares[i] = i*i;

            return squares;

        }


        public static long[] iterL()
        {
            long len = IterCount;
            var squares = new long[len];
            iter(0L,len, i => squares[i] = i * i);
            return squares;
        }

        public static void iterRight()
        {
            var i1 = iterG().Unwrap().Freeze();
            var i2 = iterDirect();
            var i3 = iterL();
            var result = true;
            for(var i=0; i<IterCount; i++)
            {
                result &= (i1[i] == i2[i]);
                result &= (i2[i] == i3[i]);
                if(!result)
                    Claim.fail($"Data at index {i} do not match: {i1[i]}, {i2[i]}, {i3[i]}");
            }

        }

    }

}