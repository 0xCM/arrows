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
    using static math;
    using static ansi;

    public abstract class TestApp<A> : Context
        where A : TestApp<A>, new()
    {

        protected TestApp(IRandomSource random = null)
            : base(random ?? RNG.XOrShift1024(Seed1024.TestSeed))
        {
            
        }

        protected virtual void RunTests(params string[] args)
        {
            try
            {
                TestTools.RunTests<A>(string.Empty, false);

            }
            catch (Exception e)
            {
                NotifyError(e);
            }

        }

        protected static void Run(params string[] args)
            => new A().RunTests(args);
    }
}