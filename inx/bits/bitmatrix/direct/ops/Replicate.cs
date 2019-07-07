//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class BitMatrixX
    {   
        [MethodImpl(Inline)] 
        public static BitMatrix4 Replicate(this BitMatrix4 src)
            => BitMatrix4.Define(src.bits.ReadOnly());

        [MethodImpl(Inline)] 
        public static BitMatrix8 Replicate(this BitMatrix8 src)
            => BitMatrix8.Define(src.bits.ReadOnly());

        [MethodImpl(Inline)] 
        public static BitMatrix16 Replicate(this BitMatrix16 src)
            => BitMatrix16.Define(src.bits.ReadOnly());

        [MethodImpl(Inline)] 
        public static BitMatrix32 Replicate(this BitMatrix32 src)
            => BitMatrix32.Define(src.bits.ReadOnly());

        [MethodImpl(Inline)] 
        public static BitMatrix64 Replicate(this BitMatrix64 src)
            => BitMatrix64.Define(src.bits.ReadOnly()); 
    }

}