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
    
    public abstract class NumericTest
    {

    }

    /// <summary>
    /// Base type for computational tests
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class NumericTest<T> : NumericTest
        where T : struct, IEquatable<T>            
    {    
        /// <summary>
        /// Defines the primops that will be used during the test
        /// </summary>
        /// <typeparam name="T">The primitive operand type</typeparam>
        protected static readonly Operative.PrimOps<T> Ops = primops.type<T>();

        protected readonly int RepeatCount = 5;

        /// <summary>
        /// The minimum primal value that will be used 
        /// </summary>
        protected T MinPrimVal {get;}

        /// <summary>
        /// The maximum primal value that will be used 
        /// </summary>
        protected T MaxPrimVal {get;}

        /// <summary>
        /// The size of the primitive sample
        /// </summary>
        protected uint SampleSize {get;}

        /// <summary>
        /// Pulls a sample of random primitives 
        /// </summary>
        protected IReadOnlyList<T> sample()
            => Rand.primal(MinPrimVal,MaxPrimVal).Freeze(SampleSize);

        /// <summary>
        /// Creates primitie vectors from a supplied stream
        /// </summary>
        /// <param name="src">The source strem</param>
        /// <typeparam name="N">The vector length</typeparam>
        protected IEnumerable<Vector<N,T>> MakeVectors<N>(IEnumerable<T> src)
            where N : TypeNat, new()
            => from x in src.Partition(nati<N>())
                where x.Count == nati<N>()
                select vector<N,T>(x);

        protected NumericTest(T MinPrimVal, T MaxPrimVal, uint SampleSize = Pow2.T20)
        {
            this.MinPrimVal = MinPrimVal;
            this.MaxPrimVal = MaxPrimVal;
            this.SampleSize = SampleSize;
        }

        protected NumericTest(Interval<T> Bounds, uint SampleSize = Pow2.T20)
            : this(Bounds.left, Bounds.right, SampleSize)
        {
        }

    }




}