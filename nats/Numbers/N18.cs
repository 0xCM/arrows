//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static nconst;    
    using static nfunc;

    public readonly struct N18 : INatSeq<N18>
    {
        public static readonly N18 Rep = default;

        public static readonly NatSeq<N1,N8> Seq = default;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq;

        public ulong value 
            => Seq.value;

        public override string ToString() 
            => Seq.format();
    }



}