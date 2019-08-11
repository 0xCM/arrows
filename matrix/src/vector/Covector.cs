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

    /// <summary>
    /// Defines the algebraic dual to a vector; in practice, covectors represent
    /// rows in a matrix while vectors represent columns. This duality captures the
    /// salient distinction between row and column-major matrix storage
    /// </summary>
    public ref struct Covector<N,T>
        where N : ITypeNat, new()
        where T : struct    
    {
        Span256<T> data;

        static readonly N NatRep = new N();

        [MethodImpl(Inline)]
        public static Covector<N,T> Load(ref T src)
            => new Covector<N,T>(ref src);

        [MethodImpl(Inline)]
        public static Covector<N,T> Define(Span<N,T> src)
            => new Covector<N,T>(src);

        [MethodImpl(Inline)]
        public static Covector<N,T> Define(Span256<T> src)
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
        /// Implicly converts a covector of natural length to a span of natural length
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator Span<N,T>(Covector<N,T> src)
            => src.data;

        /// <summary>
        /// Implicly converts a source span of natural length to a covector of natural length
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator Covector<N,T>(Span<N,T> src)
            => new Covector<N,T>(src);

        /// <summary>
        /// Implicly converts a covector of natural length to an unsized 256-bit blocked span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator Span256<T>(Covector<N,T> src)
            => src.data;

        /// <summary>
        /// Implicly converts a covector of natural length to an unsized 256-bit blocked readonly span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator ReadOnlySpan256<T>(Covector<N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bool operator == (Covector<N,T> lhs, in Covector<N,T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (Covector<N,T> lhs, in Covector<N,T> rhs) 
            => !lhs.Equals(rhs);


        [MethodImpl(Inline)]
        public Covector(in Span256<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        public Covector(in ReadOnlySpan256<T> src)
            => this.data = src.Replicate();

        [MethodImpl(Inline)]
        Covector(ref T src)
        {  
            require(Span256.IsAligned<T>(Length));
            data =  Span256.Load<T>(ref src, Length);  
        }

        [MethodImpl(Inline)]
        Covector(in ReadOnlySpan<T> src)
        {
            data = Span256.Load(src);
        }

        [MethodImpl(Inline)]
        Covector(Span<T> src)
        {
            data = Span256.Load(src);
        }

        [MethodImpl(Inline)]
        Covector(Span<N,T> src)
        {            
            data = Span256.Load(ref head(src.Unsized), src.Length);
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
            => Vector<N,T>.LoadAligned(ref data[0]);

        [MethodImpl(Inline)]
        public Span<T> Unsize()
            => Unsized;
 
        public bool Equals(Covector<N,T> rhs)
        {
            var lhsData = Unsized;
            var rhsData = rhs.Unsized;
            for(var i = 0; i<lhsData.Length; i++)
                if(gmath.neq(lhsData[i], rhsData[i]))
                    return false;
            return true;
        }

        public override bool Equals(object other)
            => throw new NotSupportedException();
 
        public override int GetHashCode()
            => throw new NotSupportedException();
 
        public override string ToString()
            => throw new NotSupportedException();
    }
}

