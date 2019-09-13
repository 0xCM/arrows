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
        public static T xor<T>(T lhs, T rhs)
            where T : struct
                => gmath.xor(lhs,rhs);

        [MethodImpl(Inline)]
        public static ref T xor<T>(ref T lhs, in T rhs)
            where T : struct
                => ref gmath.xor(ref lhs,in rhs);


        [MethodImpl(Inline)]
        public static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                math.xor(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.xor(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.xor(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.xor(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.xor(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.xor(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.xor(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.xor(uint64(lhs), uint64(rhs), uint64(dst));
            else
                throw unsupported<T>();
            return  dst;
        }

        /// <summary>
        /// Computes the bitwise AND between arrays of potentially different lengths
        /// </summary>
        /// <param name="lhs">The left cells</param>
        /// <param name="rhs">The right cells</param>
        /// <typeparam name="T">The memory cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] xor<T>(T[] lhs, T[] rhs)
            where T : unmanaged
        {            
            var dst = new T[math.max(lhs.Length, rhs.Length)];
            var len = math.min(lhs.Length, rhs.Length);
            for(var i=0; i<len; i++)
                and(in lhs[i],in rhs[i], ref dst[i]);
            return dst;
        }


        [MethodImpl(Inline)]
        public static Span<T> xor<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.xor(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.xor(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.xor(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.xor(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.xor(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.xor(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.xor(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.xor(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }

        [MethodImpl(Inline)]
        public static Span<T> xor<T>(Span<T> lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.xor(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.xor(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.xor(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.xor(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.xor(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.xor(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.xor(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.xor(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }
 
         
    }
}