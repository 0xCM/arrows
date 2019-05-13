//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;
    using static nfunc;
    

    /// <summary>
    /// Base type for computational tests
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class NumericTest<C,T> : UnitTest<C>
        where C : NumericTest<C,T>
        where T : struct, IEquatable<T>            
    {    
        /// <summary>
        /// Defines the primops that will be used during the test
        /// </summary>
        /// <typeparam name="T">The primitive operand type</typeparam>
        protected static readonly Operative.PrimOps<T> Ops = primops.typeops<T>();

        /// <summary>
        /// The minimum primal value that will be used 
        /// </summary>
        protected T MinPrimVal {get;}

        /// <summary>
        /// The maximum primal value that will be used 
        /// </summary>
        protected T MaxPrimVal {get;}


        /// <summary>
        /// Pulls a sample of random primitives 
        /// </summary>
        protected Index<T> sample()
            => Randomizer.Random<T>().stream(MinPrimVal,MaxPrimVal).Where(Filter).Freeze(SampleSize);  

        /// <summary>
        /// Creates vectors from a stream of values
        /// </summary>
        /// <param name="src">The source strem</param>
        /// <typeparam name="N">The vector length</typeparam>
        protected IEnumerable<Vector<N,T>> MakeVectors<N>(IEnumerable<T> src)
            where N : ITypeNat, new()
            => from x in src.Partition(nati<N>())
                where x.Length == nati<N>()
                select vector<N,T>(x);

        /// <summary>
        /// Creates arrays from a stream of values
        /// </summary>
        /// <param name="src">The source strem</param>
        /// <typeparam name="N">The vector length</typeparam>
        protected IEnumerable<T[]> MakeArrays(IEnumerable<T> src, int len)
            => from x in src.Partition(len)
                where x.Length == len
                select x.ToArray();

        protected Func<T,bool> Filter {get;}

        protected NumericTest(Interval<T> Bounds, Func<T,bool> filter = null, int? sampleSize = null)
            : base(sampleSize)
        {
            
            this.MinPrimVal = Bounds.Left;
            this.MaxPrimVal = Bounds.Right;            
            this.Filter = filter ?? (x => true);
        }
    }
}