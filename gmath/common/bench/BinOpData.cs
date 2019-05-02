//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zcore;
    using static OpInfo;
    using static PrimalInfo;


    public static class BinOpData
    {
        static T[] Sample<T>(IRandomizer random, BenchConfig config, bool nonzero = false)
            where T : struct, IEquatable<T>        
                => nonzero 
                 ? random.Array<T>(config.Reps,x => gmath.neq(x,gmath.zero<T>())) 
                 : random.Array<T>(config.Reps);
        
        public static BinOpData<T> Configure<T>(BenchConfig config, IRandomizer random, bool nonzero = false)
            where T : struct, IEquatable<T>        
            => new BinOpData<T>(
                Sample<T>(random, config,nonzero), 
                Sample<T>(random, config,nonzero), 
                alloc<T>(config.Reps),
                alloc<T>(config.Reps)
                );
        
    }

    public class BinOpData<T>
        where T : struct, IEquatable<T>
    {

        public BinOpData(T[] LeftSource, T[] RightSource, T[] DirectTarget, T[] GenericTarget)
        {
            this.LeftSource = LeftSource;
            this.RightSource = RightSource;
            this.DirectTarget = DirectTarget;
            this.GenericTarget = GenericTarget;
            this.Length = length(LeftSource, RightSource);

        }

        public T[] LeftSource {get;}

        public T[] RightSource {get;}

        public T[] DirectTarget {get;}

        public T[] GenericTarget {get;}


        public int Length {get;}



    }

}