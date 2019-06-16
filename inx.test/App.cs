//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{        
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    public class App : TestApp<App>
    {            

        protected override void RunTests()
        {

        }

        public static void Main(params string[] args)
            => Run(args);
    }
}