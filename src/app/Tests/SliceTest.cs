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

    using static Nats;
    using static zcore;
    using static ztest;

    
    [DisplayName("slice")]
    public class SliceTest    
    {
        static readonly Randomizer Random = Context.Random;


        public static void equality()
        {
            var src1 = Rand.values(5, ureal(50),  ureal(150));
            tell(Claim.eq(src1, src1));

            var  src2 = Rand.values(5, real(-150), real(-250));
            tell(Claim.eq(src2, src2));

            var  src3 = Rand.values(5, Z0.real<uint>.MinVal, Z0.real<uint>.MaxVal);
            tell(Claim.eq(src3, src3));

        }

        const long IterCount = 75000;

        public static intg<long>[] iterG()
        {
            long len = IterCount;
            var squares = new intg<long>[len];
            iter<long>(0L,len, i => squares[i] = i * i);            
            return squares;
        }


        public static long[] iterDirect()
        {
            long len = IterCount;
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
            var i1 = iterG().Unwrap();
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