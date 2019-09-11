//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right primal operands
        /// </summary>
        /// <param name="lhs">The left scalar</param>
        /// <param name="rhs">The right scalar</param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static T andn<T>(in T lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.andn(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.andn(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.andn(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.andn(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.andn(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.andn(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.andn(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.andn(in int64(in lhs), in int64(in rhs)));
            else 
                throw unsupported<T>();
        }


        /// <summary>
        /// Extracts the lowest set bit from the source, if any, and is logically equivalent to
        /// the composite operation (-src) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static T blsi<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.blsi(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.blsi(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.blsi(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.blsi(uint64(src)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Sets all the lower bits of the result up to and including the lowest set bit in the source
        /// Equivalent to the composite operation (a-1) ^ a
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static T blsmsk<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.blsmsk(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.blsmsk(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.blsmsk(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.blsmsk(uint64(src)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Copies all bits from the source to the result, and disable the bit in the 
        /// result that corresponds to the lowest set bit in a. 
        /// Exquivalent to the composite operation (src - 1) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static T blsr<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.blsr(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.blsr(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.blsr(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.blsr(uint64(src)));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static T bzhi<T>(T src, uint index)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.bzhi(uint8(src), index));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.bzhi(uint16(src), index));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.bzhi(uint32(src), index));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.bzhi(uint64(src),index));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source vale</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T gather<T>(in T src, in T mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.gather(in int8(in src), in int8(in mask)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.gather(in uint8(in src), in uint8(in mask)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.gather(in int16(in src), in int16(in mask)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.gather(in uint16(in src), in uint16(in mask)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.gather(in int32(in src), in int32(in mask)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.gather(in uint32(in src), in uint32(in mask)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.gather(in int64(in src), in int64(in mask)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.gather(in uint64(in src), in uint64(in mask)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// </summary>
        /// <param name="src">The source vale</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref T gather<T>(in T src, in T mask, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                Bits.gather(in int8(in src), in int8(in mask), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                Bits.gather(in uint8(in src), in uint8(in mask), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                Bits.gather(in int16(in src), in int16(in mask), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                Bits.gather(in uint16(in src), in uint16(in mask), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.gather(in int32(in src), in int32(in mask), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.gather(in uint32(in src), in uint32(in mask), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.gather(in int64(in src), in int64(in mask), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.gather(in uint64(in src), in uint64(in mask), ref uint64(ref dst));
            else            
                throw unsupported<T>();
            return ref dst;
        }           

        /// <summary>
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ulong ntz<T>(in T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 return Bits.ntz(int8(in asRef(in src)));
            else if(typeof(T) == typeof(byte))
                 return Bits.ntz(uint8(in asRef(in src)));
            else if(typeof(T) == typeof(short))
                 return Bits.ntz(int16(in asRef(in src)));
            else if(typeof(T) == typeof(ushort))
                 return Bits.ntz(uint16(in asRef(in src)));
            else if(typeof(T) == typeof(int))
                 return Bits.ntz(int32(in asRef(in src)));
            else if(typeof(T) == typeof(uint))
                 return Bits.ntz(uint32(in asRef(in src)));
            else if(typeof(T) == typeof(long))
                 return Bits.ntz(int64(in asRef(in src)));
            else if(typeof(T) == typeof(ulong))
                 return Bits.ntz(uint64(in asRef(in src)));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The scatter spec</param>
        /// <typeparam name="T">The identifiying mask</typeparam>
        [MethodImpl(Inline)]
        public static T scatter<T>(in T src, in T mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.scatter(in uint8(in src), uint8(in mask)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.scatter(in uint16(in src), uint16(in mask)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.scatter(in uint32(in src), uint32(in mask)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.scatter(in uint64(in src), uint64(in mask)));
            else            
                throw unsupported<T>();
        }           

    }

}