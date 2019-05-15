//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using Z0;
 
    using static zfunc;
    using static mfunc;
    
    partial class Bits
    {                

        [MethodImpl(Inline)]
        static byte LeftMask(byte src, int pos)
            => ((byte)1).LShift(pos);

        [MethodImpl(Inline)]
        static sbyte LeftMask(sbyte src, int pos)
            => ((sbyte)1).LShift(pos);

        [MethodImpl(Inline)]
        static short LeftMask(short src, int pos)
            => ((short)1).LShift(pos);

        [MethodImpl(Inline)]
        static ushort LeftMask(ushort src, int pos)
            => ((ushort)1).LShift(pos);

        [MethodImpl(Inline)]
        static int LeftMask(int src, int pos)
            => 1 << pos;

        [MethodImpl(Inline)]
        static uint LeftMask(uint src, int pos)
            => 1u << pos;

        [MethodImpl(Inline)]
        static long LeftMask(long src, int pos)
            => 1L << pos;

        [MethodImpl(Inline)]
        static ulong LeftMask(ulong src, int pos)
            => 1ul << pos;
    }

}