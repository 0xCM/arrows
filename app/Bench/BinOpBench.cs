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


    public abstract class BaselineOp<T> : BinOpBench<T>
        where T : struct, IEquatable<T>
    {

        protected abstract long  Compute(T[] dst);

        public BaselineOp(BenchConfig config)
            : base(config)
        {

        }

        public long Run()
        {
            DequeueMessages();
            var duration = 0L;
            var dst = alloc<T>(Config.SampleSize);
            for(var i = 0; i< Config.Reps; i++)
                duration += Compute(dst);                                
            DequeueMessages();
            return duration;
        }            

    }

    public abstract class BaselineOp<S,T> : BaselineOp<T>
        where S : BaselineOp<S,T>
        where T : struct, IEquatable<T>
    {
        public BaselineOp(BenchConfig config)
            : base(config)
        {

        }

    }
    

    public class BinOpBench<T> : Benchmark<T>
        where T : struct, IEquatable<T>
    {

        protected static readonly Operative.PrimOps<T> PrimOps = primops.typeops<T>();

         public BinOpBench(BenchConfig config)
            : base(config)
         {

             this.LeftSrc = Sample();
             this.RightSrc = Sample();
         }


        protected Index<T> LeftSrc {get;}

        protected Index<T> RightSrc {get;}


    }

}


