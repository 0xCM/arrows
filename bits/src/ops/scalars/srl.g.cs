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
        /// Applies a logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref T srl<T>(ref T src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.srl(ref int8(ref src), offset);
            else if(typeof(T) == typeof(byte))
                Bits.srl(ref uint8(ref src), offset);
            else if(typeof(T) == typeof(short))
                Bits.srl(ref int16(ref src), offset);
            else if(typeof(T) == typeof(ushort))
                Bits.srl(ref uint16(ref src), offset);
            else if(typeof(T) == typeof(int))
                Bits.srl(ref int32(ref src), offset);
            else if(typeof(T) == typeof(uint))
                Bits.srl(ref uint32(ref src), offset);
            else if(typeof(T) == typeof(long))
                Bits.srl(ref int64(ref src), offset);
            else if(typeof(T) == typeof(ulong))
                Bits.srl(ref uint64(ref src), offset);
            else
                throw unsupported<T>();
            return ref src;
        }

        /// <summary>
        /// Applies a logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static T srl<T>(T src, int offset)
            where T : struct
                => srl(ref src, offset);

    }
}