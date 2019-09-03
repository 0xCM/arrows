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
        /// If the source value is signed, negates it; otherwise, computes
        /// the two's complement negation
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Two%27s_complement</remarks>
        [MethodImpl(Inline)]
        public static T negate<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.negate(int8(src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.negate(uint8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.negate(int16(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.negate(uint16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.negate(int32(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.negate(uint32(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.negate(int64(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.negate(uint64(src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.negate(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.negate(float64(src)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// If the source value is signed, negates it in-place; otherwise, computes
        /// the two's complement negation in-place
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Two%27s_complement</remarks>
        [MethodImpl(Inline)]
        public static ref T negate<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.negate(ref int8(ref src));
            else if(typeof(T) == typeof(byte))
                math.negate(ref uint8(ref src));
            else if(typeof(T) == typeof(short))
                math.negate(ref int16(ref src));
            else if(typeof(T) == typeof(ushort))
                math.negate(ref uint16(ref src));
            else if(typeof(T) == typeof(int))
                math.negate(ref int32(ref src));
            else if(typeof(T) == typeof(uint))
                math.negate(ref uint32(ref src));
            else if(typeof(T) == typeof(long))
                math.negate(ref int64(ref src));
            else if(typeof(T) == typeof(ulong))
                math.negate(ref uint64(ref src));
            else if(typeof(T) == typeof(float))
                math.negate(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                math.negate(ref float64(ref src));
            else            
                throw unsupported<T>();
            return ref src;
        }           

        /// <summary>
        /// Applies the negate operator to each source element and stores the result in the target
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> negate<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                negate(int8(src), int8(dst));
            else if(typeof(T) == typeof(byte))
                negate(uint8(src), uint8(dst));
            else if(typeof(T) == typeof(short))
                negate(int16(src), int16(dst));
            else if(typeof(T) == typeof(ushort))
                negate(uint16(src), uint16(dst));
            else if(typeof(T) == typeof(int))
                negate(int32(src), int32(dst));
            else if(typeof(T) == typeof(uint))
                negate(uint32(src), uint32(dst));
            else if(typeof(T) == typeof(long))
                negate(int64(src), int64(dst));
            else if(typeof(T) == typeof(ulong))
                negate(uint64(src), uint64(dst));
            else if(typeof(T) == typeof(float))
                negate(float32(src), float32(dst));
            else if(typeof(T) == typeof(double))
                negate(float64(src), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        /// <summary>
        /// Applies the negate operator to each source element in-place
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> negate<T>(Span<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                negate(int8(src));
            else if(typeof(T) == typeof(byte))
                negate(uint8(src));
            else if(typeof(T) == typeof(short))
                negate(int16(src));
            else if(typeof(T) == typeof(ushort))
                negate(uint16(src));
            else if(typeof(T) == typeof(int))
                negate(int32(src));
            else if(typeof(T) == typeof(uint))
                negate(uint32(src));
            else if(typeof(T) == typeof(long))
                negate(int64(src));
            else if(typeof(T) == typeof(ulong))
                negate(uint64(src));
            else if(typeof(T) == typeof(float))
                negate(float32(src));
            else if(typeof(T) == typeof(double))
                negate(float64(src));
            else
                throw unsupported<T>();
            return  src;
        }

        [MethodImpl(Inline)]
        public static bool nneg<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.nonneg(int8(ref src));
            else if(typeof(T) == typeof(byte))
                return true;
            else if(typeof(T) == typeof(short))
                return math.nonneg(int16(ref src));
            else if(typeof(T) == typeof(ushort))
                return true;
            else if(typeof(T) == typeof(int))
                return math.nonneg(int32(ref src));
            else if(typeof(T) == typeof(uint))
                return true;
            else if(typeof(T) == typeof(long))
                return math.nonneg(int64(ref src));
            else if(typeof(T) == typeof(ulong))
                return true;
            else if(typeof(T) == typeof(float))
                return math.nonneg(float32(ref src));
            else if(typeof(T) == typeof(double))
                return math.nonneg(float64(ref src));
            else            
                throw unsupported<T>();
        }

        static void negate(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        static void negate(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        static void negate(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        static void negate(ReadOnlySpan<ushort> src, Span<ushort> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        static void negate(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        static void negate(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        static void negate(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        static void negate(ReadOnlySpan<ulong> src, Span<ulong> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        static void negate(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        static void negate(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        static Span<sbyte> negate(Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return io;
        }

        static Span<byte> negate(Span<byte> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return io;
        }

        static Span<short> negate(Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return io;
        }

        static Span<ushort> negate(Span<ushort> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return io;
        }

        static Span<int> negate(Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return io;
        }

        static Span<uint> negate(Span<uint> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return io;
        }

        static Span<long> negate(Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return io;
        }

        static Span<ulong> negate(Span<ulong> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return io;
        }

        static Span<float> negate(Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return io; 
        }

        static Span<double> negate(Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return io;
        }            
    }
}