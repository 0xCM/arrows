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
    

    /// <summary>
    /// Base class for testing vectored binary operations
    /// </summary>
    /// <typeparam name="N">The natural length type</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    public abstract class VectorBinOpTest<C,N,T,R> : BinOpTest<C,T>
        where C : VectorBinOpTest<C,N,T,R>
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

        protected VectorBinOpTest(Interval<T> bounds, Func<T,bool> filter = null, int? SampleSize = null)
            : base(bounds, filter, SampleSize)
        {
            LeftPrimVecSrc =  MakeVectors<N>(LeftPrimSrc).Freeze();
            RightPrimVecSrc = MakeVectors<N>(RightPrimSrc).Freeze();            
            VectorCount = LeftPrimVecSrc.Count;
        }

        public virtual IReadOnlyList<Vector<N,R>> Baseline() 
            => index<Vector<N,R>>();

        public virtual IReadOnlyList<Vector<N,R>> Applied()
            => index<Vector<N,R>>();

        public virtual IReadOnlyList<Vector<N,R>> Raw() 
            => index<Vector<N,R>>();

        public virtual void Verify()
        {
            var expect = Baseline();
            var actual = Applied();
            iter(VectorCount, i => Claim.eq(expect[i], actual[i]));
        }

    }



}