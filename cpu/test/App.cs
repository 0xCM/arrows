//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zfunc;

    using static Registers;

    public class App : TestApp<App>
    {            
        public static void Main(params string[] args)
            => Run(args);
    }

    public static class AppX
    {
        [MethodImpl(Inline)]
        static IRandomStream<T> stream<T>(IEnumerable<T> src, RngKind rng)
            where T : struct
                =>  new RandomStream<T>(rng,src);

    }
}