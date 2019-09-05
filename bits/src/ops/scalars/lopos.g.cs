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

    public static partial class gbits
    {
        /// <summary>
        /// Returns the position of the least on bit in the source
        /// </summary>
        /// <param name="src">The source vale</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T lopos<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.lopos(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.lopos(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.lopos(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.lopos(uint64(src)));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T loff<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 loff(ref int8(ref src));
            if(typeof(T) == typeof(byte))
                 loff(ref uint8(ref src));
            if(typeof(T) == typeof(short))
                 loff(ref int16(ref src));
            if(typeof(T) == typeof(ushort))
                 loff(ref uint16(ref src));
            if(typeof(T) == typeof(int))
                 loff(ref int32(ref src));
            if(typeof(T) == typeof(uint))
                 loff(ref uint32(ref src));
            if(typeof(T) == typeof(long))
                 loff(ref int64(ref src));
            if(typeof(T) == typeof(ulong))
                 loff(ref uint64(ref src));
            else
                throw unsupported<T>();

            return ref src;
        }       

        [MethodImpl(Inline)]
        static ref sbyte loff(ref sbyte src)
        {
            src &= (sbyte)(src - 1);
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref byte loff(ref byte src)
        {
            src &= (byte)(src - 1);
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref short loff(ref short src)
        {
            src &= (short)(src - 1);
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref ushort loff(ref ushort src)
        {
            src &= (ushort)(src - 1);
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref int loff(ref int src)
        {
            src &= src - 1;
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref uint loff(ref uint src)
        {
            src &= src - 1;
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref long loff(ref long src)
        {
            src &= src - 1;
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref ulong loff(ref ulong src)
        {
            src &= src - 1;
            return ref src;
        } 
    }

}