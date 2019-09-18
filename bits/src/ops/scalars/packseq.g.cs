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
        public static ref T packseq<T>(ReadOnlySpan<byte> src, out T dst)
            where T : struct
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                dst = generic<T>(ref Bits.packseq(src, out byte _));
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                dst = generic<T>(ref Bits.packseq(src, out ushort _));
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                dst = generic<T>(ref Bits.packseq(src, out uint _));
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                dst = generic<T>(ref Bits.packseq(src, out ulong _));
            else            
                throw unsupported<T>();            
            return ref dst;
        }        


    }

}