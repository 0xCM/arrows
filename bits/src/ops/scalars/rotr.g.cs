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
        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T rotr<T>(T src, T offset)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rotr(uint8(src), uint8(offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.rotr(uint16(src), uint16(offset)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.rotr(uint32(src), uint32(offset)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.rotr(uint64(src), uint64(offset)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref T rotr<T>(ref T src, in T offset)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                Bits.rotr(ref uint8(ref src), in uint8(in offset));
            else if(typeof(T) == typeof(ushort))
                Bits.rotr(ref uint16(ref src), in uint16(in offset));
            else if(typeof(T) == typeof(uint))
                Bits.rotr(ref uint32(ref src), in uint32(in offset));
            else if(typeof(T) == typeof(ulong))
                Bits.rotr(ref uint64(ref src), in uint64(in offset));
            else            
                throw unsupported<T>();
            return ref src;
        }           

        [MethodImpl(Inline)]
        public static Span<T> rotr<T>(ReadOnlySpan<T> src, T offset)        
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rotr(uint8(src), uint8(in offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.rotr(uint16(src), uint16(in offset)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.rotr(uint32(src), uint32(in offset)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.rotr(uint64(src), uint64(in offset)));
            else            
                throw unsupported<T>();

        }

        [MethodImpl(Inline)]
        public static Span<T> rotr<T>(ReadOnlySpan<T> src, T offset, Span<T> dst)        
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                Bits.rotr(uint8(src), uint8(in offset), uint8(dst));
            else if(typeof(T) == typeof(ushort))
                Bits.rotr(uint16(src), uint16(in offset), uint16(dst));
            else if(typeof(T) == typeof(uint))
                Bits.rotr(uint32(src), uint32(in offset), uint32(dst));
            else if(typeof(T) == typeof(ulong))
                Bits.rotr(uint64(src), uint64(in offset), uint64(dst));
            else            
                throw unsupported<T>();
            return dst;

        }


    }

}