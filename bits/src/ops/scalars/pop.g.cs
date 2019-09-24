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
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
        /// <summary>
        /// Counts the number enabled source bits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static uint pop<T>(in T src)
            where T : struct
        {        
            if(typeof(T) == typeof(sbyte))
                 return Bits.pop(int8(in src));
            else if(typeof(T) == typeof(byte))
                 return Bits.pop(uint8(in src));
            else if(typeof(T) == typeof(short))
                 return Bits.pop(int16(in src));
            else if(typeof(T) == typeof(ushort))
                 return Bits.pop(uint16(in src));
            else if(typeof(T) == typeof(int))
                 return Bits.pop(int32(in src));
            else if(typeof(T) == typeof(uint))
                 return Bits.pop(uint32(in src));
            else if(typeof(T) == typeof(long))
                 return Bits.pop(int64(in src));
            else if(typeof(T) == typeof(ulong))
                 return Bits.pop(uint64(in src));
            else 
                throw unsupported<T>();
        }

 
    }
}