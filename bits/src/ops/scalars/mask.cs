//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    
    partial class Bits
    {                

        [MethodImpl(Inline)]
        public static ref ulong mask(ref ulong dst, byte i0)
        {
            dst |= Pow2.pow(i0);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong mask(ref ulong dst, byte i0, byte i1)
        {
            dst |= Pow2.pow(i0);
            dst |= Pow2.pow(i1);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong mask(ref ulong dst, byte i0, byte i1, byte i2)
        {
            mask(ref dst, i0, i1);
            mask(ref dst, i2);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong mask(ref ulong dst, byte i0, byte i1, byte i2, byte i3)
        {
            mask(ref dst, i0, i1);
            mask(ref dst, i2, i3);
            return ref dst;
        }
    }
}