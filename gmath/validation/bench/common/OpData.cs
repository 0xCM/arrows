//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static mfunc;
    using static zfunc;
    
    using static OpInfo;

    public static class UnaryOpData
    {
        static T[] Sample<T>(IRandomizer random, BenchConfig config, bool nonzero = false)
            where T : struct, IEquatable<T>        
                => nonzero 
                 ? random.Array<T>(config.Reps,x => gmath.neq(x,gmath.zero<T>())) 
                 : random.Array<T>(config.Reps);
        
        public static UnaryOpData<T> Configure<T>(BenchConfig config, IRandomizer random, bool nonzero = false)
            where T : struct, IEquatable<T>        
            => new UnaryOpData<T>(
                Sample<T>(random, config,nonzero), 
                alloc<T>(config.Reps),
                alloc<T>(config.Reps)
                );        
    }

    public class UnaryOpData<T>
        where T : struct, IEquatable<T>
    {
        public UnaryOpData(T[] Source, T[] LeftTarget, T[] RightTarget)
        {
            this.LeftTarget = LeftTarget;
            this.RightTarget = RightTarget;
            this.Length = length(LeftTarget, RightTarget);
            this.Source = Source;
        }
    
        public T[] LeftTarget {get;}

        public T[] RightTarget {get;}

        public int Length {get;}

        public T[] Source {get;}

    }

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

        public BinOpData(T[] LeftSource, T[] RightSource, T[] LeftTarget, T[] RightTarget)
        {            
            this.LeftSource = LeftSource;
            this.RightSource = RightSource;
            this.LeftTarget = LeftTarget;
            this.RightTarget = RightTarget;
            this.Length = length(LeftTarget, RightTarget);
        }

        public readonly T[] LeftSource;

        public readonly T[] RightSource;

        public T[] LeftTarget;

        public T[] RightTarget;

        public int Length {get;}
    }
}