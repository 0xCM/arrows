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

        [MethodImpl(Inline)]
        public static ref T toggle<T>(ref T src, byte pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.toggle(ref int8(ref src), pos);
            else if(typeof(T) == typeof(byte))
                Bits.toggle(ref uint8(ref src), pos);
            else if(typeof(T) == typeof(short))
                Bits.toggle(ref int16(ref src), pos);
            else if(typeof(T) == typeof(ushort))
                Bits.toggle(ref uint16(ref src), pos);
            else if(typeof(T) == typeof(int))
                Bits.toggle(ref int32(ref src), pos);
            else if(typeof(T) == typeof(uint))
                Bits.toggle(ref uint32(ref src), pos);
            else if(typeof(T) == typeof(long))
                Bits.toggle(ref int64(ref src), pos);
            else if(typeof(T) == typeof(ulong))
                Bits.toggle(ref uint64(ref src), pos);
            else if(typeof(T) == typeof(float))
                Bits.toggle(ref float32(ref src), pos);
            else if(typeof(T) == typeof(double))
                Bits.toggle(ref float64(ref src), pos);
            else
                throw unsupported<T>();

            return ref src;                            
        }


    }
}