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
        /// Enables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
        public static ref T enable<T>(ref T src, in int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.enable(ref int8(ref src), in pos);
            else if(typeof(T) == typeof(byte))
                Bits.enable(ref uint8(ref src), in pos);
            else if(typeof(T) == typeof(short))
                Bits.enable(ref int16(ref src), in pos);
            else if(typeof(T) == typeof(ushort))
                Bits.enable(ref uint16(ref src), in pos);
            else if(typeof(T) == typeof(int))
                Bits.enable(ref int32(ref src), in pos);
            else if(typeof(T) == typeof(uint))
                Bits.enable(ref uint32(ref src), in pos);
            else if(typeof(T) == typeof(long))
                Bits.enable(ref int64(ref src), in pos);
            else if(typeof(T) == typeof(ulong))
                Bits.enable(ref uint64(ref src), in pos);
            else
                throw unsupported<T>();

            return ref src;                            
        }

        /// <summary>
        /// Enables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
        public static T enable<T>(T src, in int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.enable(int8(src), pos));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.enable(uint8(src), pos));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.enable(int16(src), pos));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.enable(uint16(src), pos));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.enable(int32(src), pos));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.enable(uint32(src), pos));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.enable(int64(src), pos));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.enable(uint64(src), pos));
            else
                throw unsupported<T>();            
        }
    }
}