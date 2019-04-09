//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;
    using static ztest;
    
    /// <summary>
    /// Base type for computational tests
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class NumericTest<T>
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

        protected NumericTest(T MinPrimVal, T MaxPrimVal, uint SampleSize = Pow2.T20)
        {
            this.MinPrimVal = MinPrimVal;
            this.MaxPrimVal = MaxPrimVal;
            this.SampleSize = SampleSize;
        }
    }


    /// <summary>
    /// Base class for test cases that verify the correct function, 
    /// tracks the performance of, binary operations defined over 
    /// generic reals
    /// </summary>
    /// <typeparam name="T">The underlying primitive type</typeparam>
    public abstract class RealBinOpTest<T,R> : BinOpTest<T>
        where T : struct, IEquatable<T>            
    {

        /// <summary>
        /// The source for left real values
        /// </summary>
        protected IReadOnlyList<real<T>> LeftRealSrc {get;}
        
        /// <summary>
        /// The source for right real values
        /// </summary>
        protected IReadOnlyList<real<T>> RightRealSrc {get;}

        protected RealBinOpTest(T MinPrimVal, T MaxPrimVal, uint SampleSize = Pow2.T20)
            : base(MinPrimVal, MaxPrimVal, SampleSize)
        {
            this.LeftRealSrc = LeftPrimSrc.ToReal();
            this.RightRealSrc = RightPrimSrc.ToReal();
        }

    }

    /// <summary>
    /// Base class for testing vectored binary operations
    /// </summary>
    /// <typeparam name="N">The natural length type</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    public abstract class VectorBinOpTest<N,T,R> : BinOpTest<T>
        where N : TypeNat, new()
        where T : struct, IEquatable<T>            
        where R : struct, IEquatable<R>
    {
        /// <summary>
        /// The source for left primitive vectors
        /// </summary>
        protected  IReadOnlyList<Vector<N,T>> LeftPrimVecSrc {get;}
        
        /// <summary>
        /// The source for right primitive vectors
        /// </summary>
        protected  IReadOnlyList<Vector<N,T>> RightPrimVecSrc {get;}

        /// <summary>
        /// The number of vectors in the sample
        /// </summary>
        protected int VectorCount {get;}
        
        /// <summary>
        /// The length of each vector in the sample
        /// </summary>
        protected int VectorLength {get;}  = nati<N>();

        IEnumerable<Vector<N,T>> SampleVectors(IEnumerable<T> src)
            => from x in src.Partition(VectorLength)
                where x.Count == VectorLength
                select vector<N,T>(x);

        protected VectorBinOpTest(T MinPrimVal, T MaxPrimVal, uint SampleSize = Pow2.T20)
            : base(MinPrimVal, MaxPrimVal, SampleSize)
        {
            LeftPrimVecSrc =  SampleVectors(LeftPrimSrc).Freeze();
            RightPrimVecSrc = SampleVectors(RightPrimSrc).Freeze();            
            VectorCount = LeftPrimVecSrc.Count;
        }

        public virtual IReadOnlyList<Vector<N,R>> Baseline() 
            => list<Vector<N,R>>();

        public virtual IReadOnlyList<Vector<N,R>> Applied()
            => list<Vector<N,R>>();

        public virtual IReadOnlyList<Vector<N,R>> Raw() 
            => list<Vector<N,R>>();

        public virtual void Verify()
        {
            var expect = Baseline();
            var actual = Applied();
            iter(VectorCount, i => Claim.eq(expect[i], actual[i]));
        }

    }

    public abstract class RealVectorBinOpTest<N,T,R> : VectorBinOpTest<N,T,R>
        where N : TypeNat, new()
        where T : struct, IEquatable<T>            
        where R : struct, IEquatable<R>
    {

        /// <summary>
        /// The source for left real vectors
        /// </summary>
        protected  IReadOnlyList<Vector<N,real<T>>> LeftRealVecSrc {get;}
        
        /// <summary>
        /// The source for right real vectors
        /// </summary>
        protected  IReadOnlyList<Vector<N,real<T>>> RightRealVecSrc {get;}

        protected RealVectorBinOpTest(T MinPrimVal, T MaxPrimVal, uint SampleSize = Pow2.T20)
            : base(MinPrimVal, MaxPrimVal, SampleSize)
        {
            LeftRealVecSrc = map(LeftPrimVecSrc,v => v.map(real));
            RightRealVecSrc = map(RightPrimVecSrc,v => v.map(real));
        }

        public new virtual IReadOnlyList<Vector<N,real<R>>> Applied() 
            => list<Vector<N,real<R>>>();

        public virtual new void Verify()
        {
            var expect = Baseline();
            var actual = Applied().Map(x => x.map(y => y.unwrap()));
            iter(VectorCount, i => Claim.eq(expect[i], actual[i]));
        }
    }
}