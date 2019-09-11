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
    using System.Runtime.InteropServices;
    
    using static nfunc;
    using static zfunc;

    public struct Vector<N,T>
        where N : ITypeNat, new()
        where T : unmanaged
    {
         MemorySpan<T> data;        

        /// <summary>
        /// The vector's dimension
        /// </summary>
        public static readonly int Dim = nati<N>();     

        public static readonly Vector<N,T> Zero = new Vector<N,T>(new T[Dim]);
         
        /// <summary>
        /// Implicitly reveals the vector's underlying storage
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator Span<N,T>(Vector<N,T> src)
            => src.data.Span;

        [MethodImpl(Inline)]   
        public static implicit operator MemorySpan<T>(Vector<N,T> src)
            => src.data;

        [MethodImpl(Inline)]   
        public static implicit operator Vector<T>(Vector<N,T> src)
            => new Vector<T>(src.data);

        [MethodImpl(Inline)]   
        public static implicit operator ReadOnlySpan<T>(Vector<N,T> src)
            => src.data.Span;

        [MethodImpl(Inline)]   
        public static implicit operator Vector<N,T>(T[] src)
            => new Vector<N, T>(src);

        [MethodImpl(Inline)]   
        public static implicit operator Vector<N,T>(MemorySpan<T> src)
            => new Vector<N, T>(src);

        [MethodImpl(Inline)]   
        public static implicit operator Vector<N,T>(Vector<T> src)
            => new Vector<N, T>(src.Data);

        [MethodImpl(Inline)]
        public static bool operator == (Vector<N,T> lhs, in Vector<N,T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (Vector<N,T> lhs, in Vector<N,T> rhs) 
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static T operator *(Vector<N,T> lhs, in Vector<N,T> rhs)
            => gmath.dot<T>(lhs.Unsized, rhs.Unsized);         

        [MethodImpl(Inline)]
        public Vector(MemorySpan<T> src)
        {
            require(src.Length >= Dim);
            data = src;
        }

        [MethodImpl(Inline)]
        public Vector(T[] src)
        {
            require(src.Length >= Dim);
            data = src;
        }
                    
        /// <summary>
        /// Queries/manipulates component values
        /// </summary>
        public ref T this[int index] 
            => ref data[index];

        public MemorySpan<T> Unsized
        {
            [MethodImpl(Inline)]
            get => data;
        }
 
         /// <summary>
        /// The count of vector components, otherwise known as its dimension
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Dim;
        }

        [MethodImpl(Inline)]
        public Covector<N,T> Transpose()
            => Covector<N, T>.Define(data);

        [MethodImpl(Inline)]
        public Vector<N,U> As<U>()
            where U : unmanaged
                => new Vector<N, U>(data.As<U>());

        public bool Equals(Vector<N,T> rhs)
        {
            for(var i = 0; i<Dim; i++)
                if(gmath.neq(data[i], rhs.data[i]))
                    return false;
            return true;
        }

        [MethodImpl(Inline)]
        public ref Vector<N,T> CopyTo(ref Vector<N,T> dst)
        {
            data.CopyTo(dst.data);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public Vector<N,T> Replicate(bool structureOnly = false)
            => new Vector<N,T>(data.Replicate(structureOnly));

        public override bool Equals(object rhs)
            => rhs is Vector<N,T> x  && Equals(x);
 
        public override int GetHashCode()
            => throw new NotSupportedException();
 
        public override string ToString()
            => throw new NotSupportedException();
    
    }
}

