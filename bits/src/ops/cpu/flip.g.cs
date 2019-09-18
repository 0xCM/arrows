//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;
    

    partial class gbits
    {
        [MethodImpl(Inline)]
        public static T[] flip<T>(T[] src)
            where T : unmanaged
        {
            var dst = new T[src.Length];
            for(var i=0; i<dst.Length; i++)
                gmath.flip(in src[i], ref dst[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Vec128<T> flip<T>(in Vec128<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.flip(in int8(in src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.flip(in uint8(in src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.flip(in int16(in src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.flip(in uint16(in src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.flip(in int32(in src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.flip(in uint32(in src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.flip(in int64(in src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.flip(in uint64(in src)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> flip<T>(in Vec256<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.flip(in int8(in src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.flip(in uint8(in src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.flip(in int16(in src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.flip(in uint16(in src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.flip(in int32(in src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.flip(in uint32(in src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.flip(in int64(in src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.flip(in uint64(in src)));
            else 
                throw unsupported<T>();
        }
         

        [MethodImpl(Inline)]
        public static Span<T> flip<T>(Span<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.flip(int8(src));
            else if(typeof(T) == typeof(byte))
                Bits.flip(uint8(src));
            else if(typeof(T) == typeof(short))
                Bits.flip(int16(src));
            else if(typeof(T) == typeof(ushort))
                Bits.flip(uint16(src));
            else if(typeof(T) == typeof(int))
                Bits.flip(int32(src));
            else if(typeof(T) == typeof(uint))
                Bits.flip(uint32(src));
            else if(typeof(T) == typeof(long))
                Bits.flip(int64(src));
            else if(typeof(T) == typeof(ulong))
                Bits.flip(uint64(src));
            else
                throw unsupported<T>();
            return src;
        }

        /// <summary>
        /// Computes the bitwise complement of each source element and stores
        /// the result at the corresponding location in the target
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primal element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> flip<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.flip(int8(src), int8(dst));
            else if(typeof(T) == typeof(byte))
                Bits.flip(uint8(src),uint8(dst));
            else if(typeof(T) == typeof(short))
                Bits.flip(int16(src),int16(dst));
            else if(typeof(T) == typeof(ushort))
                Bits.flip(uint16(src),uint16(dst));
            else if(typeof(T) == typeof(int))
                Bits.flip(int32(src), int32(dst));
            else if(typeof(T) == typeof(uint))
                Bits.flip(uint32(src),uint32(dst));
            else if(typeof(T) == typeof(long))
                Bits.flip(int64(src),int64(dst));
            else if(typeof(T) == typeof(ulong))
                Bits.flip(uint64(src),uint64(dst));
            else
                throw unsupported<T>();
            return dst;
        }


    }
}