//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{        
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.IO;

    using Z0.Mkl;
    using static zfunc;


    public class App : TestApp<App>
    {            
        
        public static void Main(params string[] args)
            => Run(args);
    }
}