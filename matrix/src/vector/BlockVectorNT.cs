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

    public ref struct BlockVector<N,T>
        where N : ITypeNat, new()
        where T : struct    
    {
        Span256<T> data;

        static readonly N NatRep = new N();

        [MethodImpl(Inline)]
        public static BlockVector<N,T> LoadAligned(ref T src)
            => new BlockVector<N,T>(ref src);

        [MethodImpl(Inline)]
        public static BlockVector<N,T> LoadAligned(Span<N,T> src)
            => new BlockVector<N,T>(src);

        [MethodImpl(Inline)]
        public static BlockVector<N,T> LoadAligned(ReadOnlySpan<T> src)
            => new BlockVector<N,T>(src);

        [MethodImpl(Inline)]
        public static BlockVector<N,T> LoadAligned(Span<T> src)
            => new BlockVector<N,T>(src);

        [MethodImpl(Inline)]
        public static BlockVector<N,T> LoadAligned(Span256<T> src)
            => new BlockVector<N,T>(src);

        [MethodImpl(Inline)]
        public static BlockVector<N,T> LoadAligned(params T[] src)
            => new BlockVector<N, T>(src);

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
        public static implicit operator Span<N,T>(BlockVector<N,T> src)
            => src.data;

        /// <summary>
        /// Slice => Vec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator BlockVector<N,T>(Span<N,T> src)
            => new BlockVector<N,T>(src);

        [MethodImpl(Inline)]   
        public static implicit operator Span256<T>(BlockVector<N,T> src)
            => src.data;

        [MethodImpl(Inline)]   
        public static implicit operator BlockVector<T>(BlockVector<N,T> src)
            => src.Denaturalize();

        [MethodImpl(Inline)]   
        public static implicit operator ReadOnlySpan256<T>(BlockVector<N,T> src)
            => src.data;

        [MethodImpl(Inline)]   
        public static implicit operator BlockVector<N,T>(T[] src)
            => new BlockVector<N, T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (BlockVector<N,T> lhs, in BlockVector<N,T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (BlockVector<N,T> lhs, in BlockVector<N,T> rhs) 
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static T operator *(BlockVector<N,T> lhs, in BlockVector<N,T> rhs)
            => gmath.dot<T>(lhs.Unsized, rhs.Unsized);
         
        [MethodImpl(Inline)]
        BlockVector(ref T src)
        {  
            data =  Span256.Load<T>(ref src, Length);  
        }

        [MethodImpl(Inline)]
        BlockVector(in ReadOnlySpan<N,T> src)
        {
            data = Span256.Load(src.Unsized);
        }

        [MethodImpl(Inline)]
        BlockVector(in ReadOnlySpan<T> src)
        {
            data = Span256.Load(src);
        }

        [MethodImpl(Inline)]
        BlockVector(Span<T> src)
        {
            data = Span256.Load(src);
        }


        [MethodImpl(Inline)]
        BlockVector(Span256<T> src)
        {
            require(src.Length >= Length);
            data = src;
        }

        [MethodImpl(Inline)]
        BlockVector(Span<N,T> src)
        {
            data = Span256.Load(src);
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
        public BlockVector<N,U> As<U>()
            where U : struct
                => new BlockVector<N, U>(MemoryMarshal.Cast<T,U>(Unsized));

        public bool Equals(BlockVector<N,T> rhs)
        {
            var lhsData = Unsized;
            var rhsData = rhs.Unsized;
            for(var i = 0; i<lhsData.Length; i++)
                if(gmath.neq(lhsData[i], rhsData[i]))
                    return false;
            return true;
        }

        [MethodImpl(Inline)]
        public ref BlockVector<N,T> CopyTo(ref BlockVector<N,T> dst)
        {
            Unsized.CopyTo(dst.Unsized);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public BlockVector<N,U> Convert<U>()
            where U : struct
               => new BlockVector<N,U>(convert<T,U>(data));

        public BlockVector<N,T> Replicate(bool structureOnly = false)
            => new BlockVector<N,T>(data.Replicate(structureOnly));

        public BlockVector<T> Denaturalize()
            => data;

        public override bool Equals(object other)
            => throw new NotSupportedException();
 
        public override int GetHashCode()
            => throw new NotSupportedException();
 
        public override string ToString()
            => throw new NotSupportedException();
    
        public Span256<T> ToSpan256()
            => data;

        public ReadOnlySpan256<T> ToReadOnlySpan256()
            => data;
    }
}

