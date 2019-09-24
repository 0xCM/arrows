//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static nfunc;
    using static As;

    partial class bitvector
    {
        /// <summary>
        /// Creates an 8-bit bitvector from the least 8 bits of a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector8 bv8<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                    return (byte)int8(ref src);
            else if(typeof(T) == typeof(byte))
                    return (byte)uint8(ref src);
            else if(typeof(T) == typeof(short))
                    return (byte)int16(ref src);
            else if(typeof(T) == typeof(ushort))
                    return (byte)uint16(ref src);
            else if(typeof(T) == typeof(int))
                    return (byte)int32(ref src);
            else if(typeof(T) == typeof(uint))
                    return (byte)uint32(ref src);
            else if(typeof(T) == typeof(long))
                    return (byte)int64(ref src);
            else if(typeof(T) == typeof(ulong))
                    return (byte)uint64(ref src);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Creates a 16-bit bitvector from the least 16 bits (or fewer) of a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector16 bv16<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                    return (ushort)int8(ref src);
            else if(typeof(T) == typeof(byte))
                    return (ushort)uint8(ref src);
            else if(typeof(T) == typeof(short))
                    return (ushort)int16(ref src);
            else if(typeof(T) == typeof(ushort))
                    return (ushort)uint16(ref src);
            else if(typeof(T) == typeof(int))
                    return (ushort)int32(ref src);
            else if(typeof(T) == typeof(uint))
                    return (ushort)uint32(ref src);
            else if(typeof(T) == typeof(long))
                    return (ushort)int64(ref src);
            else if(typeof(T) == typeof(ulong))
                    return (ushort)uint64(ref src);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Creates a 32-bit bitvector from the least 32 bits (or fewer) of a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector32 bv32<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                    return (uint)int8(ref src);
            else if(typeof(T) == typeof(byte))
                    return (uint)uint8(ref src);
            else if(typeof(T) == typeof(short))
                    return (uint)int16(ref src);
            else if(typeof(T) == typeof(ushort))
                    return (uint)uint16(ref src);
            else if(typeof(T) == typeof(int))
                    return (uint)int32(ref src);
            else if(typeof(T) == typeof(uint))
                    return (uint)uint32(ref src);
            else if(typeof(T) == typeof(long))
                    return (uint)int64(ref src);
            else if(typeof(T) == typeof(ulong))
                    return (uint)uint64(ref src);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Creates a 32-bit bitvector from the least 32 bits (or fewer) of a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector64 bv64<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return (ulong)int8(ref src);
            else if(typeof(T) == typeof(byte))
                return (ulong)uint8(ref src);
            else if(typeof(T) == typeof(short))
                return (ulong)int16(ref src);
            else if(typeof(T) == typeof(uint))
                return (ulong)uint16(ref src);
            else if(typeof(T) == typeof(int))
                return (ulong)int32(ref src);
            else if(typeof(T) == typeof(uint))
                return (ulong)uint32(ref src);
            else if(typeof(T) == typeof(long))
                return (ulong)int64(ref src);
            else if(typeof(T) == typeof(ulong))
                return (ulong)uint64(ref src);
            else
                throw unsupported<T>();
        }

    }

}