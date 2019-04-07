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

    using Z0.Testing;


    using static Nats;
    using static zcore;
    using static ztest;

    [DisplayName("matrix")]
    public class MatrixTest
    {

        static readonly Randomizer random = Context.Random;

            
        public static void equality()
        {
            var src = Rand.matrices(dim<N5,N5>(), Int16.MinValue, Int16.MaxValue).Take(5);
            iter(src, m =>  Claim.eq(m,m));
        }


    }

}