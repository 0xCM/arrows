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

    public ref struct Vector<N,T>
        where N : ITypeNat, new()
        where T : struct    
    {
        Span256<T> data;

        static readonly N NatRep = new N();

        [MethodImpl(Inline)]
        public static Vector<N,T> LoadAligned(ref T src)
            => new Vector<N,T>(ref src);

        [MethodImpl(Inline)]
        public static Vector<N,T> LoadAligned(Span<N,T> src)
            => new Vector<N,T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> LoadAligned(ReadOnlySpan<T> src)
            => new Vector<N,T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> LoadAligned(Span<T> src)
            => new Vector<N,T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> LoadAligned(Span256<T> src)
            => new Vector<N,T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> LoadAligned(params T[] src)
            => new Vector<N, T>(src);

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
        public static implicit operator Span256<T>(Vector<N,T> src)
            => src.data;

        [MethodImpl(Inline)]   
        public static implicit operator Vector<T>(Vector<N,T> src)
            => src.Denaturalize();


        [MethodImpl(Inline)]   
        public static implicit operator ReadOnlySpan256<T>(Vector<N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bool operator == (Vector<N,T> lhs, in Vector<N,T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (Vector<N,T> lhs, in Vector<N,T> rhs) 
            => !lhs.Equals(rhs);


        [MethodImpl(Inline)]
        Vector(ref T src)
        {  
            require(Span256.IsAligned<T>(Length));
            data =  Span256.LoadAligned<T>(ref src, Length);  
        }

        [MethodImpl(Inline)]
        Vector(in ReadOnlySpan<N,T> src)
        {
            data = Span256.LoadAligned(src.Replicate());
        }

        [MethodImpl(Inline)]
        Vector(in ReadOnlySpan<T> src)
        {
            require(src.Length >= Length);
            data = Span256.LoadAligned(src.Replicate());
        }

        [MethodImpl(Inline)]
        Vector(Span<T> src)
        {
            data = Span256.LoadAligned(src);
        }

        [MethodImpl(Inline)]
        Vector(Span256<T> src)
        {
            require(src.Length >= Length);
            data = src;
        }

        [MethodImpl(Inline)]
        Vector(Span<N,T> src)
        {
            data = Span256.LoadAligned(src);
        }
                    
        public ref T this[int index] 
            => ref data[index];

        public Span<T> Unsized
        {
            [MethodImpl(Inline)]
            get => data.Unblocked;
        }
 
        [MethodImpl(Inline)]
        public Covector<N,T> Transpose()
            => Covector<N, T>.Define(data);

        [MethodImpl(Inline)]
        public Vector<N,U> As<U>()
            where U : struct
                => new Vector<N, U>(MemoryMarshal.Cast<T,U>(Unsized));

        public bool Equals(Vector<N,T> rhs)
        {
            var lhsData = Unsized;
            var rhsData = rhs.Unsized;
            for(var i = 0; i<lhsData.Length; i++)
                if(gmath.neq(lhsData[i], rhsData[i]))
                    return false;
            return true;
        }

        [MethodImpl(Inline)]
        public ref Vector<N,T> CopyTo(ref Vector<N,T> dst)
        {
            Unsized.CopyTo(dst.Unsized);
            return ref dst;
        }

        public Vector<N,T> Replicate(bool structureOnly = false)
            => new Vector<N,T>(data.Replicate(structureOnly));

        public Vector<T> Denaturalize()
            => data;

        public override bool Equals(object other)
            => throw new NotSupportedException();
 
        public override int GetHashCode()
            => throw new NotSupportedException();
 
        public override string ToString()
            => throw new NotSupportedException();
    }
}

