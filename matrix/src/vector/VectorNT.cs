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
         T[] data;

        /// <summary>
        /// The vector's dimension
        /// </summary>
        public static readonly int Dim = nati<N>();     

        /// <summary>
        /// The zero vector
        /// </summary>
        public static Vector<N,T> Zero => new Vector<N,T>(new T[Dim]);
         

        [MethodImpl(Inline)]   
        public static implicit operator Vector<T>(Vector<N,T> src)
            => new Vector<T>(src.data);

        [MethodImpl(Inline)]   
        public static implicit operator ReadOnlySpan<T>(Vector<N,T> src)
            => src.data;

        [MethodImpl(Inline)]   
        public static implicit operator Vector<N,T>(T[] src)
            => new Vector<N, T>(src);


        [MethodImpl(Inline)]   
        public static implicit operator Vector<N,T>(Vector<T> src)
            => new Vector<N, T>(src.Data);

        [MethodImpl(Inline)]
        public static bool operator == (Vector<N,T> lhs, Vector<N,T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (Vector<N,T> lhs, Vector<N,T> rhs) 
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static T operator *(Vector<N,T> lhs, Vector<N,T> rhs)
            => mathspan.dot<T>(lhs.Data, rhs.Data);         

        /// <summary>
        /// Initializes a vector with an array
        /// </summary>
        /// <param name="src">The data source</param>
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
        {
            [MethodImpl(Inline)]
            get => ref data[index];
        }

        /// <summary>
        /// The vector data
        /// </summary>
        public T[] Data
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

        /// <summary>
        /// Projects the source vector onto a target vector of the same length 
        /// via a supplied transformation
        /// </summary>
        /// <param name="f">The transformation function</param>
        /// <typeparam name="U">The target vector element type</typeparam>
        [MethodImpl(Inline)]
        public Vector<N,U> Map<U>(Func<T,U> f)
            where U:unmanaged
        {
            var dst = Vector.Alloc<N,U>();
            return Map(f, ref dst);
        }

        /// <summary>
        /// Projects the source vector onto a caller-supplied target vector of the same length 
        /// via a supplied transformation
        /// </summary>
        /// <param name="f">The transformation function</param>
        /// <typeparam name="U">The target vector element type</typeparam>
        public ref Vector<N,U> Map<U>(Func<T,U> f, ref Vector<N,U> dst)
            where U:unmanaged
        {
            for(var i=0; i < Length; i++)
                dst[i] = f(data[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public Covector<N,T> Transpose()
            => Covector<N, T>.Load(data);

        /// <summary>
        /// Loads the data from the source into a block vector, allocating as necessary to ensure alignment
        /// </summary>
        [MethodImpl(Inline)]
        public BlockVector<N,T> Block()
            => BlockVector.Load<N,T>(Span256.Load(data));

        [MethodImpl(Inline)]
        public Vector<N,U> Convert<U>()
            where U : unmanaged
               => new Vector<N,U>(convert<T,U>(data));

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

        [MethodImpl(Inline)]
        public string Format(char? delimiter = null)
            => data.FormatList(delimiter ?? AsciSym.Comma);    

        public override bool Equals(object rhs)
            => rhs is Vector<N,T> x && Equals(x);

        public override int GetHashCode()
            => data.GetHashCode();
 
        public override string ToString()
            => Format();
    
    }
}

