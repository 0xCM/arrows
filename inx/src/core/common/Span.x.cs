//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    

    partial class ginxs
    {
        /// <summary>
        /// Stores source vector conent in a caller-supplied target span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this Vec256<T> src, Span<T> dst, int offset = 0)
            where T : struct
        {            
            Vec256.Store(src, ref dst[offset]);
            return  dst;
        }

        /// <summary>
        /// Stores source vector conent in a caller-supplied target span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this Vec128<T> src, Span<T> dst, int offset = 0)
            where T : struct
        {            
            Vec128.Store(src, ref dst[offset]);
            return  dst;
        }

        /// <summary>
        /// Allocates a blocked span into which vector content is stored
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> ToSpan128<T>(this Vec128<T> src)
            where T : struct     
        {
            var dst = Span128.AllocBlocks<T>(1);
            Vec128.Store(in src, ref dst[0]);
            return dst;
        }                       

        /// <summary>
        /// Clones the source vector and returns the resul
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Replicate<T>(this Vec128<T> src)
            where T : struct
                => Vec128.Load(src.ToSpan128());

        /// <summary>
        /// Allocates a blocked span into which vector content is stored
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> ToReadOnlySpan128<T>(this Vec128<T> src)
            where T : struct     
                => src.ToSpan128();
        
        /// <summary>
        /// Allocates a blocked span into which vector content is stored
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> ToSpan256<T>(this Vec256<T> src)
            where T : struct            
        {
            var dst = Span256.AllocBlocks<T>(1);
            Vec256.Store(in src, ref dst[0]);
            return dst;
        }                       

        /// <summary>
        /// Clones the source vector and returns the resul
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Replicate<T>(this Vec256<T> src)
            where T : struct
                => Vec256.Load(src.ToSpan256());
        
        /// <summary>
        /// Allocates a blocked span into which vector content is stored
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> ToReadOnlySpan256<T>(this Vec256<T> src)
            where T : struct            
                => src.ToSpan256();        

        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this Vec128<T> src)
            where T : struct            
                => src.ToSpan128();

        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this Vec128<T> src)
            where T : struct            
                => src.ToSpan128();

        /// <summary>
        /// Allocates a blocked span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this Vec256<T> src)
            where T : struct            
                => src.ToSpan256();

        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this Vec256<T> src)
            where T : struct            
                => src.ToSpan256();

        /// <summary>
        /// Allocates a blocked span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> ToSpan256<T>(this Vec512<T> src)
            where T : struct            
         {
            var dst = Span256.AllocBlocks<T>(2);
            Vec256.Store(in src.lo, ref dst[0]);
            Vec256.Store(in src.hi, ref dst[32]);
            return dst;
        }                       

        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this Vec512<T> src)
            where T : struct            
                => src.ToSpan();
         
        /// <summary>
        /// Allocates a blocked span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> ToSpan256<T>(this Vec1024<T> src)
            where T : struct            
         {
            var dst = Span256.AllocBlocks<T>(4);
            Vec256.Store(in src.v00, ref dst[0]);
            Vec256.Store(in src.v01, ref dst[32]);
            Vec256.Store(in src.v10, ref dst[64]);
            Vec256.Store(in src.v10, ref dst[96]);
            return dst;
        }                       

        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this Vec1024<T> src)
            where T : struct           
                => src.ToSpan256(); 

        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this Vec1024<T> src)
            where T : struct            
                => src.ToSpan();

    }
}