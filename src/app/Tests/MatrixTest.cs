//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;


    using static Nats;
    using static zcore;
    using static ztest;

    [DisplayName("matrix")]
    public class MatrixTest
    {

        static readonly Randomizer random = Context.Random;

            
        public static void equality()
        {
            var src = Rand.matrices<N5,N5,short>(real(Int16.MinValue), real(Int16.MaxValue)).Take(5);
            iter(src, m =>  Claim.eq(m,m));
        }

        // public static void cofactor()
        // {
        //     var srcdim = dim(N5,N5);
        //     var src = Rand.matrices(srcdim,real(Byte.MinValue), real(Byte.MaxValue)).Take(5);
        //     var ops = Matrix.ops(srcdim, real<byte>(0));
        //     foreach(var m in src)
        //     {
        //         var deleted = ops.delete(m, 0, 0).reinterpret(dim(N4,N4));
        //         var submatrix = ops.submatrix(m, dim(N4,N4), (1,1));
        //     }        
        // }

    }

}