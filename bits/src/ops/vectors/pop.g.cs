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
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
        public static ulong pop<T>(in T src)
            where T : struct
        {        
            if(typeof(T) == typeof(sbyte))
                 return pop(int8(in src));
            else if(typeof(T) == typeof(byte))
                 return pop(uint8(in src));
            else if(typeof(T) == typeof(short))
                 return pop(int16(in src));
            else if(typeof(T) == typeof(ushort))
                 return pop(uint16(in src));
            else if(typeof(T) == typeof(int))
                 return pop(int32(in src));
            else if(typeof(T) == typeof(uint))
                 return pop(uint32(in src));
            else if(typeof(T) == typeof(long))
                 return pop(int64(in src));
            else if(typeof(T) == typeof(ulong))
                 return pop(uint64(in src));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static ulong pop(sbyte src) => Popcnt.PopCount((uint)src);

        [MethodImpl(Inline)]
        static ulong pop(byte src) => Popcnt.PopCount(src);

        [MethodImpl(Inline)]
        static ulong pop(short src) => Popcnt.PopCount((uint)src);

        [MethodImpl(Inline)]
        static ulong pop(ushort src) => Popcnt.PopCount(src);

        [MethodImpl(Inline)]
        static ulong pop(int src) => Popcnt.PopCount((uint)src);

        [MethodImpl(Inline)]
        static ulong pop(uint src) => Popcnt.PopCount(src);

        [MethodImpl(Inline)]
        static ulong pop(long src) => Popcnt.X64.PopCount((ulong)src);

        [MethodImpl(Inline)]
        static ulong pop(ulong src) => Popcnt.X64.PopCount(src);
 
    }
}