//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {

        /// <summary>
        /// Decrements the source value 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T dec<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.dec(int8(src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.dec(uint8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.dec(int16(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.dec(uint16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.dec(int32(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.dec(uint32(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.dec(int64(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.dec(uint64(src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.dec(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.dec(float64(src)));
            else            
                 throw unsupported<T>();                
        }           

        /// <summary>
        /// Decrements the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T dec<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.dec(ref int8(ref src));
            else if(typeof(T) == typeof(byte))
                math.dec(ref uint8(ref src));
            else if(typeof(T) == typeof(short))
                math.dec(ref int16(ref src));
            else if(typeof(T) == typeof(ushort))
                math.dec(ref uint16(ref src));
            else if(typeof(T) == typeof(int))
                math.dec(ref int32(ref src));
            else if(typeof(T) == typeof(uint))
                math.dec(ref uint32(ref src));
            else if(typeof(T) == typeof(long))
                math.dec(ref int64(ref src));
            else if(typeof(T) == typeof(ulong))
                math.dec(ref uint64(ref src));
            else if(typeof(T) == typeof(float))
                math.dec(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                math.dec(ref float64(ref src));
            else            
                throw unsupported<T>();
            return ref src;
        }           

        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                dec(int8(src), int8(dst));
            else if(typeof(T) == typeof(byte))
                dec(uint8(src), uint8(dst));
            else if(typeof(T) == typeof(short))
                dec(int16(src), int16(dst));
            else if(typeof(T) == typeof(ushort))
                dec(uint16(src), uint16(dst));
            else if(typeof(T) == typeof(int))
                dec(int32(src), int32(dst));
            else if(typeof(T) == typeof(uint))
                dec(uint32(src), uint32(dst));
            else if(typeof(T) == typeof(long))
                dec(int64(src), int64(dst));
            else if(typeof(T) == typeof(ulong))
                dec(uint64(src), uint64(dst));
            else if(typeof(T) == typeof(float))
                dec(float32(src), float32(dst));
            else if(typeof(T) == typeof(double))
                dec(float64(src), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }        

        [MethodImpl(Inline)]
        public static ref Span<T> dec<T>(ref Span<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                dec(int8(io));
            else if(typeof(T) == typeof(byte))
                dec(uint8(io));
            else if(typeof(T) == typeof(short))
                dec(int16(io));
            else if(typeof(T) == typeof(ushort))
                dec(uint16(io));
            else if(typeof(T) == typeof(int))
                dec(int32(io));
            else if(typeof(T) == typeof(uint))
                dec(uint32(io));
            else if(typeof(T) == typeof(long))
                dec(int64(io));
            else if(typeof(T) == typeof(ulong))
                dec(uint64(io));
            else if(typeof(T) == typeof(float))
                dec(float32(io));
            else if(typeof(T) == typeof(double))
                dec(float64(io));
            else
                 throw unsupported<T>();                
           
            return ref io;
        }

        static Span<sbyte> dec(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        static Span<byte> dec(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        static Span<short> dec(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        static Span<ushort> dec(ReadOnlySpan<ushort> src, Span<ushort> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        static Span<int> dec(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        static Span<uint> dec(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        static Span<long> dec(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        static Span<ulong> dec(ReadOnlySpan<ulong> src, Span<ulong> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        static Span<float> dec(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        static Span<double> dec(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;                
        }

        static Span<sbyte> dec(Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        static Span<byte> dec(Span<byte> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        static Span<short> dec(Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        static Span<ushort> dec(Span<ushort> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        static Span<int> dec(Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        static Span<uint> dec(Span<uint> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        static Span<long> dec(Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        static Span<ulong> dec(Span<ulong> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        static Span<float> dec(Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        static Span<double> dec(Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }
 
        
    }
}