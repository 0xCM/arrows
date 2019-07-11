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
        /// Disables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.All)]
        public static ref T disable<T>(ref T src, in int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.disable(ref int8(ref src), in pos);
            else if(typeof(T) == typeof(byte))
                Bits.disable(ref uint8(ref src), in pos);
            else if(typeof(T) == typeof(short))
                Bits.disable(ref int16(ref src), in pos);
            else if(typeof(T) == typeof(ushort))
                Bits.disable(ref uint16(ref src), in pos);
            else if(typeof(T) == typeof(int))
                Bits.disable(ref int32(ref src), in pos);
            else if(typeof(T) == typeof(uint))
                Bits.disable(ref uint32(ref src), in pos);
            else if(typeof(T) == typeof(long))
                Bits.disable(ref int64(ref src), in pos);
            else if(typeof(T) == typeof(ulong))
                Bits.disable(ref uint64(ref src), in pos);
            else if(typeof(T) == typeof(float))
                Bits.disable(ref float32(ref src), in pos);
            else if(typeof(T) == typeof(double))
                Bits.disable(ref float64(ref src), in pos);
            else
                throw unsupported<T>();
                
            return ref src;                            
        }
    }
}