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

    partial class RngX
    {
        [MethodImpl(Inline)]
        public static BitMatrix4 BitMatrix4(this IRandomSource random)
            => Z0.BitMatrix4.Define(random.Next<ushort>());

        [MethodImpl(Inline)]
        public static BitMatrix8 BitMatrix8(this IRandomSource random)
            => Z0.BitMatrix8.Define(random.NextUInt64());

        [MethodImpl(Inline)]
        public static BitMatrix16 BitMatrix16(this IRandomSource random)
            => Z0.BitMatrix16.Define(random.Span<ushort>(16));

        [MethodImpl(Inline)]
        public static BitMatrix32 BitMatrix32(this IRandomSource random)
            => Z0.BitMatrix32.Define(random.Span<uint>(32));

        [MethodImpl(Inline)]
        public static BitMatrix64 BitMatrix64(this IRandomSource random)
            => Z0.BitMatrix64.Define(random.Span<ulong>(64));        
    
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> BitMatrix<M,N,T>(this IRandomSource random, M m = default, N n = default, T x = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => Z0.BitMatrix.Define(random.Span<T>(BitLayout.Grid(m,n,x).TotalStorageLength()),m,n);

        [MethodImpl(Inline)]
        public static BitMatrix<N,N,T> BitMatrix<N,T>(this IRandomSource random, N n = default, T x = default)
            where N : ITypeNat, new()
            where T : struct
                => random.BitMatrix<N,N,T>();
                
    }

}