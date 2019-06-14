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

    public ref struct Vector<N,T>
        where N : ITypeNat, new()
        where T : struct    
    {
        static readonly N NatRep = new N();

        [MethodImpl(Inline)]
        public static Vector<N,T> Load(ref T src)
            => new Vector<N,T>(ref src);

        [MethodImpl(Inline)]
        public static Vector<N,T> Define(Span<N,T> src)
            => new Vector<N,T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> Define(in ReadOnlySpan<T> src)
            => new Vector<N,T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> Define(Span<T> src)
            => new Vector<N,T>(src);

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
        public static implicit operator Span<N,T>(Vector<N,T> src)
            => src.data;

        /// <summary>
        /// Slice => Vec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator Vector<N,T>(Span<N,T> src)
            => new Vector<N,T>(src);

        [MethodImpl(Inline)]
        Vector(ref T src)
        {
            data =  NatSpan.load<N,T>(ref src);  
            require(data.Length == Length);
        }

        [MethodImpl(Inline)]
        Vector(in ReadOnlySpan<N,T> src)
        {
            data = NatSpan.replicate(src);
        }

        [MethodImpl(Inline)]
        Vector(in ReadOnlySpan<T> src)
        {
            require(src.Length == Length);
            data = NatSpan.replicate<N,T>(src);
        }

        [MethodImpl(Inline)]
        Vector(Span<T> src)
        {
            require(src.Length == Length);
            data = NatSpan.adapt(src, NatRep);
        }

        [MethodImpl(Inline)]
        Vector(Span<N,T> src)
        {
            data = src;
        }
        
        Span<N,T> data {get;}

        public ref T this[int index] 
            => ref data[index];

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

