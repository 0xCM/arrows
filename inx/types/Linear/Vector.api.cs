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
        /// <summary>
        /// Loads a vector from an existing span of commensuate length (Non-allocating)
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
        
        /// <summary>
        /// Loads a vector from an natural span of commensuate length (Non-allocating)
        /// 
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> Load<N,T>(Span<N,T> src)
            where N : ITypeNat, new()
            where T : struct
                => Vector<N,T>.Define(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> Load<N,T>(N len, params T[] src)
            where N : ITypeNat, new()
            where T : struct
                => Load(span(src), len);

        /// <summary>
        /// Defines a vector of natural length with components intitalized
        /// to a specified common value
        /// </summary>
        /// <param name="len">The natural nength</param>
        /// <param name="fill">The value used to initialize the components</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> Define<N,T>(T fill, N len)
            where N : ITypeNat, new()
            where T : struct
                => Load(NatSpan.alloc(fill, len));

        /// <summary>
        /// Loads a natural span from a readonly span that is required to have
        /// the specified natural length. This operation replicates
        /// the source readonly span.
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> Load<N,T>(ReadOnlySpan<T> src, N length = default)
            where N : ITypeNat, new()
            where T : struct
                => Vector<N,T>.Define(src);
        
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
 
        [MethodImpl(Inline)]        
        static Span<T> Slice<N,T>(this Span<T> src, N start = default)
            where N : ITypeNat, new()
                => src.Slice((int)start.value);

        [MethodImpl(Inline)]
        public static Vector<P,T> Concat<M,N,P,T>(Vector<M,T> v1, Vector<N,T> v2, P sum = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where P : INatSum<M,N>, new()
            where T : struct
        {
            var dst = span<T>(new NatSum<M,N>());
            v1.Unsize().CopyTo(dst);
            v2.Unsize().CopyTo(dst.Slice(new M()));
            return Vector<P,T>.Define(dst);
        }
    }
}