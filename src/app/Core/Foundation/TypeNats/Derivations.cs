//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Reflection;
    using static corefunc;

    /// <summary>
    /// Reifies a natural base raised to a natural power
    /// </summary>
    public readonly struct PrimePower<N, P> : Traits.PrimePower<PrimePower<N,P>, N, P>
        where N : TypeNat, new()
        where P : TypeNat, new()
    {
        public static readonly Pow<N,P> Rep = Nat.exp<N,P>();        
        public static readonly uint Value = Rep.value;
        public TypeNat rep => Rep;
        public uint value => Rep.value;
        public byte[] digits() => Rep.digits();
        public override string ToString() => value.ToString();
    }

    public readonly struct N16 : Traits.NatSeq<N16>, Traits.Pow<N16,N2,N5>
    {
        public static readonly NatSeq<N3,N2> Rep = default;
        public TypeNat rep => Rep;
        public uint value => Rep.value;
        public byte[] digits() => Rep.digits();
        public override string ToString() => value.ToString();
    }


    public readonly struct N32 : Traits.NatSeq<N32>, Traits.Pow<N32,N2,N6>
    {
        public static readonly NatSeq<N3,N2> Rep = default;
        public TypeNat rep => Rep;
        public uint value => Rep.value;
        public byte[] digits() => Rep.digits();
        public override string ToString() => value.ToString();
    }

    public readonly struct N64 : Traits.NatSeq<N64>, Traits.Pow<N64, N2,N6>
    {
        public static readonly NatSeq<N6,N4> Rep = default;
        public TypeNat rep => Rep;
        public uint value => Rep.value;
        public byte[] digits() => Rep.digits();
        public override string ToString() => value.ToString();        
    }

    public readonly struct N128 : Traits.NatSeq<N128>, Traits.Pow<N128, N2,N7>
    {
        public static readonly NatSeq<N1,N2,N8> Rep = default;
        public TypeNat rep => Rep;
        public uint value => Rep.value;
        public byte[] digits() => Rep.digits();
        public override string ToString() => value.ToString();        
    }


    public readonly struct N256 : Traits.NatSeq<N256>, Traits.Pow<N256, N2,N8>
    {
        public static readonly NatSeq<N2,N5,N6> Rep = default;
        public TypeNat rep => Rep;
        public uint value => Rep.value;
        public byte[] digits() => Rep.digits();
        public override string ToString() => value.ToString();
    }


    public readonly struct N512 : Traits.NatSeq<N512>, Traits.Pow<N512, N2,N9>
    {
        public static readonly NatSeq<N5,N1,N2> Rep = default;
        public TypeNat rep => Rep;
        public uint value => Rep.value;
        public byte[] digits() => Rep.digits();
        public override string ToString() => value.ToString();
    }
}