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
        /// Reads a position-identified bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The primal value type</typeparam>
        [MethodImpl(Inline)]
        public static ref Bit read<T>(in T src, in int pos, out Bit dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 Bits.read(in int8(in src), in pos, out dst);
            else if(typeof(T) == typeof(byte))
                 Bits.read(in uint8(in src), in pos, out dst);
            else if(typeof(T) == typeof(short))
                 Bits.read(in int16(in src), in pos, out dst);
            else if(typeof(T) == typeof(ushort))
                 Bits.read(in uint16(in src), in pos, out dst);
            else if(typeof(T) == typeof(int))
                 Bits.read(in int32(in src), in pos, out dst);
            else if(typeof(T) == typeof(uint))
                 Bits.read(in uint32(in src), in pos, out dst);
            else if(typeof(T) == typeof(long))
                 Bits.read(in int64(in src), in pos, out dst);
            else if(typeof(T) == typeof(ulong))
                 Bits.read(in uint64(in src), in pos, out dst);
            else if(typeof(T) == typeof(float))
                 Bits.read(in float32(in src), in pos, out dst);
            else if(typeof(T) == typeof(double))
                 Bits.read(in float64(in src), in pos, out dst);
            else            
                throw unsupported<T>();
            return ref dst;
        }

    }

}