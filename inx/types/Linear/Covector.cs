//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static zfunc;

    public ref struct Covector<N,T>
        where N : ITypeNat, new()
        where T : struct    
    {
        Span<N,T> data {get;}

        static readonly N NatRep = new N();

        [MethodImpl(Inline)]
        public static Covector<N,T> Load(ref T src)
            => new Covector<N,T>(ref src);

        [MethodImpl(Inline)]
        public static Covector<N,T> Define(Span<N,T> src)
            => new Covector<N,T>(src);

        [MethodImpl(Inline)]
        public static Covector<N,T> Define(in ReadOnlySpan<T> src)
            => new Covector<N,T>(src);

        [MethodImpl(Inline)]
        public static Covector<N,T> Define(Span<T> src)
            => new Covector<N,T>(src);

        /// <summary>
        /// Specifies the length of the vector, i.e. its component count
        /// </summary>
        public static readonly int Length = nati<N>();     

        /// <summary>
        /// Vec => Slice
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator Span<N,T>(Covector<N,T> src)
            => src.data;

        /// <summary>
        /// Slice => Vec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator Covector<N,T>(Span<N,T> src)
            => new Covector<N,T>(src);

        [MethodImpl(Inline)]
        Covector(ref T src)
        {
            data =  NatSpan.Load<N,T>(ref src);  
            require(data.Length == Length);
        }

        [MethodImpl(Inline)]
        Covector(in ReadOnlySpan<N,T> src)
        {
            data = NatSpan.Replicate(src);
        }

        [MethodImpl(Inline)]
        Covector(in ReadOnlySpan<T> src)
        {
            require(src.Length == Length);
            data = NatSpan.Load<N,T>(src);
        }

        [MethodImpl(Inline)]
        Covector(Span<T> src)
        {
            require(src.Length == Length);
            data = NatSpan.Load(src, NatRep);
        }

        [MethodImpl(Inline)]
        Covector(Span<N,T> src)
        {
            data = src;
        }
        
        public ref T this[int index] 
            => ref data[index];

        public Span<T> Unsized
        {
            [MethodImpl(Inline)]
            get => data;
        }

        [MethodImpl(Inline)]
        public Vector<N,T> Transpose()
            => Vector.Load(data);

        [MethodImpl(Inline)]
        public Span<T> Unsize()
            => data.Unsize();
 
        public override bool Equals(object other)
            => throw new NotSupportedException();
 
        public override int GetHashCode()
            => throw new NotSupportedException();
 
        public override string ToString()
            => throw new NotSupportedException();
    }
}

