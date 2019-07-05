//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class UniformRandom
    {

        [MethodImpl(Inline)]
        public static BitMatrix8 BitMatrix8(this IRandomSource random)
            => Z0.BitMatrix8.Define(random.NextInt());

        [MethodImpl(Inline)]
        public static BitMatrix16 BitMatrix16(this IRandomSource random)
            => Z0.BitMatrix16.Define(random.Span<ushort>(16));

        [MethodImpl(Inline)]
        public static BitMatrix32 BitMatrix32(this IRandomSource random)
            => Z0.BitMatrix32.Define(random.Span<uint>(32));

        [MethodImpl(Inline)]
        public static BitMatrix64 BitMatrix64(this IRandomSource random)
            => Z0.BitMatrix64.Define(random.Span<ulong>(64));        
    }

}