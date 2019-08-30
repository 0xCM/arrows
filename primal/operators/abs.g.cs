//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {
        /// <summary>
        /// Computes the absolute value of a primal operand
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T abs<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.abs(int8(src)));
            else if(typeof(T) == typeof(byte))
                return src;
            else if(typeof(T) == typeof(short))
                return generic<T>(math.abs(int16(src)));
            else if(typeof(T) == typeof(ushort))
                return src;
            else if(typeof(T) == typeof(int))
                return generic<T>(math.abs(int32(src)));
            else if(typeof(T) == typeof(uint))
                return src;
            else if(typeof(T) == typeof(long))
                return generic<T>(math.abs(int64(src)));
            else if(typeof(T) == typeof(ulong))
                return src;
            else if(typeof(T) == typeof(float))
                return generic<T>(math.abs(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.abs(float64(src)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Computes the absolute value of a primal operand in-place
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T abs<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.abs(ref int8(ref src));
            else if(typeof(T) == typeof(byte))
                return ref src;
            else if(typeof(T) == typeof(short))
                math.abs(ref int16(ref src));
            else if(typeof(T) == typeof(ushort))
                return ref src;
            else if(typeof(T) == typeof(int))
                math.abs(ref int32(ref src));
            else if(typeof(T) == typeof(uint))
                return ref src;
            else if(typeof(T) == typeof(long))
                math.abs(ref int64(ref src));
            else if(typeof(T) == typeof(ulong))
                return ref src;
            else if(typeof(T) == typeof(float))
                math.abs(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                math.abs(ref float64(ref src));
            else            
                throw unsupported<T>();
            return ref src;                
        }           

        [MethodImpl(Inline)]
        public static ref readonly Span<T> abs<T>(in ReadOnlySpan<T> src, in Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(src).Abs(int8(dst));
            else if(typeof(T) == typeof(short))
                int16(src).Abs(int16(dst));
            else if(typeof(T) == typeof(int))
                int32(src).Abs(int32(dst));
            else if(typeof(T) == typeof(long))
                int64(src).Abs(int64(dst));
            else if(typeof(T) == typeof(float))
                float32(src).Abs(float32(dst));
            else if(typeof(T) == typeof(double))
                float64(src).Abs(float64(dst));
            else
                throw unsupported<T>();
            return ref dst;
        }

        public static ref readonly Span<T> abs<T>(in Span<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(io).Abs();
            else if(typeof(T) == typeof(short))
                int16(io).Abs();
            else if(typeof(T) == typeof(int))
                int32(io).Abs();
            else if(typeof(T) == typeof(long))
                int64(io).Abs();
            else if(typeof(T) == typeof(float))
                float32(io).Abs();
            else if(typeof(T) == typeof(double))
                float64(io).Abs();
            else
                throw unsupported<T>();
            return ref io;
        }
 
         /// <summary>
        /// Computes the absolute value of the source elements in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        static Span<sbyte> Abs(this Span<sbyte> io)
            => abs(io);

        /// <summary>
        /// Computes the absolute value of the source elements in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        static Span<short> Abs(this Span<short> io)
            => abs(io);

        /// <summary>
        /// Computes the absolute value of the source elements in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        static Span<int> Abs(this Span<int> io)
            => abs(io);

        /// <summary>
        /// Computes the absolute value of the source elements in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        static Span<long> Abs(this Span<long> io)
            => abs(io);

        /// <summary>
        /// Computes the absolute value of the source elements in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        static Span<float> Abs(this Span<float> io)
            => abs(io);

        /// <summary>
        /// Computes the absolute value of the source elements in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        static Span<double> Abs(this Span<double> io)
            => abs(io);

        [MethodImpl(Inline)]
        static ReadOnlySpan<sbyte> Abs(this ReadOnlySpan<sbyte> src, Span<sbyte> dst)
            => abs(src,dst);            

        [MethodImpl(Inline)]
        static ReadOnlySpan<short> Abs(this ReadOnlySpan<short> src, Span<short> dst)
            => abs(src,dst);            

        [MethodImpl(Inline)]
        static ReadOnlySpan<int> Abs(this ReadOnlySpan<int> src, Span<int> dst)
            => abs(src,dst);            

        [MethodImpl(Inline)]
        static ReadOnlySpan<long> Abs(this ReadOnlySpan<long> src, Span<long> dst)
            => abs(src,dst);            

        [MethodImpl(Inline)]
        static ReadOnlySpan<float> Abs(this ReadOnlySpan<float> src, Span<float> dst )
            => abs(src,dst);            

        [MethodImpl(Inline)]
        static ReadOnlySpan<double> Abs(this ReadOnlySpan<double> src, Span<double> dst )
            => abs(src,dst);            

        static Span<sbyte> abs(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.abs(src[i]);
            return dst;
        }

        static Span<short> abs(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] =math.abs(src[i]);
            return dst;
        }

        static Span<int> abs(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] =math.abs(src[i]);
            return dst;
        }

        static Span<long> abs(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] =math.abs(src[i]);
            return dst;
        }

        static Span<float> abs(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] =math.abs(src[i]);
            return dst;
        }

        static Span<double> abs(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] =math.abs(src[i]);
            return dst;
        }

        static Span<sbyte> abs(Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.abs(ref io[i]);
            return io;
        }

        static Span<short> abs(Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.abs(ref io[i]);
            return io;
        }

        static Span<int> abs(Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.abs(ref io[i]);
            return io;
        }

        static Span<long> abs(Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.abs(ref io[i]);
            return io;
        }

        static Span<float> abs(Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.abs(ref io[i]);
            return io;
        }

        static Span<double> abs(Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.abs(ref io[i]);
            return io;
        }  
    }
}