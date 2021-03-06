//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;    

    public static class VSpanX
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
            vstore(src, ref dst[offset]);
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
            vstore(src, ref dst[offset]);
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
            vstore(src, ref dst[0]);
            return dst;
        }                       

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
            vstore(src, ref dst[0]);
            return dst;
        }                       

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
        /// Allocates an array into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this Vec128<T> src)
            where T : struct            
        {
            var dst = new T[Vec128<T>.Length];
            vstore(src, ref head(dst));
            return dst;
        }

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
        /// Extracts vector content as a span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Span<T> ToSpan<T>(this Vec512<T> src)
            where T : struct        
                => new Span<T>(As.pvoid(ref Unsafe.Add(ref src, 0)), Vec512<T>.Length);        

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
        /// Allocates an array into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this Vec256<T> src)
            where T : struct            
        {
            var dst = new T[Vec256<T>.Length];
            vstore(src, ref head(dst));
            return dst;
        }
            
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
            vstore(src.lo, ref dst[0]);
            vstore(src.hi, ref dst[32]);
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
            vstore(src.v00, ref dst[0]);
            vstore(src.v01, ref dst[32]);
            vstore(src.v10, ref dst[64]);
            vstore(src.v10, ref dst[96]);
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
