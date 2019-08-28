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
        /// Creates a bitview over a source value
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <typeparam name="T">The source type</typeparam>
        public static BitView<T> view<T>(ref T src)
            where T: struct
                => new BitView<T>(ref src);

        /// <summary>
        /// Computes the minimal number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T width<T>(in T src)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.width(in uint8(in src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.width(in uint16(in src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.width(uint32(in src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.width(in uint64(in src)));
            else            
                throw unsupported<T>();
        }           


    }

}