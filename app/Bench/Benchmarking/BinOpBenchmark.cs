//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static zcore;


    

    public abstract class BinOpBenchmark<T> : Benchmark<T>
        where T : struct, IEquatable<T>
    {

        protected static readonly Operative.PrimOps<T> PrimOps = primops.typeops<T>();


         public BinOpBenchmark(BenchConfig config)
            : base(config)
         {

             this.LeftSrc = Sample();
             this.RightSrc = Sample();
         }


        protected Index<T> LeftSrc {get;}

        protected Index<T> RightSrc {get;}


    }

}


