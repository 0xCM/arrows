//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;
    
    public static class BitMatrixOpId
    {
        public static string and<M,N,T>()
            where T : unmanaged
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => BitMatrixOpId<M,N,T>.TheOnly.OpName(OpKind.And);
    }

    public readonly struct BitMatrixOpId<M,N,T>
        where T : unmanaged
        where M : ITypeNat, new()
        where N : ITypeNat, new()
    {
        static readonly BitSize SegSize = bitsize<T>();
        
        static readonly int RowCount = nati<M>();
        
        static readonly int ColCount = nati<M>();

        public static readonly BitMatrixOpId<M,N,T> TheOnly = default;

        public string OpName(OpKind kind)
            => $"bm_{kind}_{RowCount}x{ColCount}x{SegSize}";
    }

}