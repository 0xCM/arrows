namespace Z0
{
    using N1024 = NatSeq<N1,N0,N2,N4>;
    using N2048 = NatSeq<N2,N0,N4,N8>;
    using N10 = NatSeq<N1,N0>;
    using N11 = NatSeq<N1,N1>;
    using N12 = NatSeq<N1,N2>;
    using N13 = NatSeq<N1,N3>;
    using N14 = NatSeq<N1,N4>;
    using N15 = NatSeq<N1,N5>;
    using N17 = NatSeq<N1,N7>;
    using N18 = NatSeq<N1,N8>;
    using N19 = NatSeq<N1,N9>;
    using N20 = NatSeq<N2,N0>;

    public static class Nats
    {
        public static N0 N0 = default;

        public static N1 N1 = default;

        public static N2 N2 = default;

        public static N3 N3 = default;
        
        public static N4 N4 = default;

        public static N5 N5 = default;

        public static N6 N6 = default;

        public static N7 N7 = default;

        public static N8 N8 = default;
        
        public static N9 N9 = default;
        
        public static N10 N10 = default;
        
        public static N11 N11 = default;

        public static N12 N12 = default;

        public static N13 N13 = default;

        public static N14 N14 = default;

        public static N15 N15 = default;

        public static N16 N16 = default;

        public static N17 N17 = default;

        public static N18 N18 = default;

        public static N19 N19 = default;

        public static N20 N20 = default;

        public static N32 N32 = default;
        
        public static N64 N64 = default;

        public static N128 N128 = default;

        public static N256 N256 = default;

        public static N512 N512 = default;

        public static N1024 N1024 = default;

        public static N2048 N2048 = default;

    }


    public readonly struct N16 : NatSeq<N16>, Traits.Pow<N16,N2,N5>
    {
        public static readonly N16 Rep = default;

        public static readonly NatSeq<N1,N6> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq;

        public uint value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }


    public readonly struct N32 : NatSeq<N32>, Traits.Pow<N32,N2,N6>
    {
        public static readonly N32 Rep = default;

        public static readonly NatSeq<N3,N2> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq;

        public uint value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();
        
        public override string ToString() => format();

    }

    public readonly struct N64 : NatSeq<N64>, Traits.Pow<N64, N2,N6>
    {
        public static readonly N64 Rep = default;
        
        public static readonly NatSeq<N6,N4> Seq = default;
        
        public TypeNat rep => Rep;
        
        public NatSeq seq => Seq;
        
        public uint value => Seq.value;
        
        public byte[] digits() => Seq.digits();
        
        public string format() => Seq.format();
        
        public override string ToString() => format();
    }

    public readonly struct N128 : NatSeq<N128>,  Traits.Pow<N128, N2,N7>
    {
        public static readonly N128 Rep = default;
        
        public static readonly NatSeq<N1,N2,N8> Seq = default;
        
        public TypeNat rep => Rep;
        
        public NatSeq seq => Seq;
        
        public uint value => Seq.value;
        
        public byte[] digits() => Seq.digits();
        
        public string format() => Seq.format();
        
        public override string ToString() => format();
    }


    public readonly struct N256 : NatSeq<N256>, Traits.Pow<N256, N2,N8>
    {
        public static readonly N256 Rep = default;

        public static readonly NatSeq<N2,N5,N6> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq.seq;

        public uint value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }


    public readonly struct N512 : NatSeq<N512>, Traits.Pow<N512, N2,N9>
    {
        public static readonly N512 Rep = default;

        public static readonly NatSeq<N5,N1,N2> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq.seq;

        public uint value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }
}