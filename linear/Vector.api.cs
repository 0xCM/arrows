//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;

    public static class Vector
    {
        [MethodImpl(Inline)]
        public static Vector<Sum<M,N>,T> Concat<M,N,T>(Vector<M,T> v1, Vector<N,T> v2)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
        {
            var dst = span<T>(new Sum<M,N>());
            v1.Unsize().CopyTo(dst);
            v2.Unsize().CopyTo(dst.Slice(new M()));
            return Vector<Sum<M,N>,T>.Define(dst);
        }
                
        /// <summary>
        /// Creates a generic bitvector from a source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> Bits<T>(in T src)        
            where T : struct
                => new BitVector<T>(in src);

        /// <summary>
        /// Loads a natural span from an existing span that is required to have
        /// the specified natural length. This operation performs no allocation.
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> Load<N,T>(Span<T> src, N length = default)
            where N : ITypeNat, new()
            where T : struct
                => Vector<N,T>.Define(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> Load<N,T>(Span<N,T> src)
            where N : ITypeNat, new()
            where T : struct
                => Vector<N,T>.Define(src);

        /// <summary>
        /// Loads a natural span from a readonly span that is required to have
        /// the specified natural length. This operation replicates
        /// the source readonly span.
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> Load<N,T>(in ReadOnlySpan<T> src, N length = default)
            where N : ITypeNat, new()
            where T : struct
                => Vector<N,T>.Define(in src);
        
        [MethodImpl(Inline)]
        public static Vector<T> Zero<T>(int minlen)
            where T : struct
            => Alloc<T>(minlen);

        [MethodImpl(Inline)]
        public static Vector<T> Load<T>(Span256<T> src)
            where T : struct
                => new Vector<T>(src);                
                
        [MethodImpl(Inline)]
        public static Vector<T> Load<T>(ReadOnlySpan256<T> src)
            where T : struct
                => new Vector<T>(src); 

        [MethodImpl(Inline)]
        public static Vector<T> Load<T>(Span<T> src)
            where T : struct
        {
            var blocklen = Span256.blocklength<T>();                        
            var qr = math.quorem(src.Length, blocklen);                        
            if(qr.Remainder == 0)
                return new Vector<T>(Span256.load(src));
            else
            {
                var blocks = qr.Quotient + 1;
                var dst = Span256.alloc<T>(blocks);
                src.CopyTo(dst);
                return new Vector<T>(dst);
            }                                            
        }

        [MethodImpl(Inline)]
        public static Vector<T> Load<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var blocklen = Span256.blocklength<T>();                        
            var qr = math.quorem(src.Length, blocklen); 
            var blocks = qr.Quotient + (qr.Remainder == 0 ? 0 : 1);
            var dst = Span256.alloc<T>(blocks);
            src.CopyTo(dst);
            return new Vector<T>(dst);
        }


        [MethodImpl(Inline)]
        public static Vector<T> Alloc<T>(int minlen)               
            where T : struct
        {
            var blocklen = Span256.blocklength<T>();                        
            var qr = math.quorem(minlen, blocklen); 
            var blocks = qr.Quotient + (qr.Remainder == 0 ? 0 : 1);
            var dst = Span256.alloc<T>(blocks);
            return new Vector<T>(dst);
        } 
    }

}