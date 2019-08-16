//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    

    partial class Bits
    {                

        /// <summary>
        /// Reverses the bits in a byte
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        /// <reference>https://graphics.stanford.edu/~seander/bithacks.htm</reference>
        [MethodImpl(Inline)]
        public static byte rev(byte src)
        {
            return (byte)(((src * 0x80200802ul) & 0x0884422110ul) * 0x0101010101ul >> 32);
        }

        /// <summary>
        /// Reverses the bits in the source
        /// </summary>
        /// <param name="src">The soruce bits</param>
        [MethodImpl(Inline)]
        public static ushort rev(ushort src)
            => pack(rev(hi(in src)),rev(lo(in src)));

        /// <summary>
        /// Reverses the bits in the source
        /// </summary>
        /// <param name="src">The soruce bits</param>
        [MethodImpl(Inline)]
        public static uint rev(uint src)
            => pack(rev(hi(in src)),rev(lo(in src)));

        /// <summary>
        /// Reverses the bits in the source
        /// </summary>
        /// <param name="src">The soruce bits</param>
        [MethodImpl(Inline)]
        public static ulong rev(ulong src)
            => pack(rev(hi(in src)),rev(lo(in src)));

    }

}