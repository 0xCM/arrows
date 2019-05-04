namespace Z0
{
    //using N20 = NatSeq<N2,N0>;

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

        public static N4096 N4096 = default;

        public static N8192 N8192 = default;

    }

    public readonly struct N10 : NatSeq<N10>
    {
        public static readonly N10 Rep = default;

        public static readonly NatSeq<N1,N0> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }

    public readonly struct N11 : NatSeq<N11>
    {
        public static readonly N11 Rep = default;

        public static readonly NatSeq<N1,N1> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }

    public readonly struct N12 : NatSeq<N12>
    {
        public static readonly N12 Rep = default;

        public static readonly NatSeq<N1,N2> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }

    public readonly struct N13 : NatSeq<N13>
    {
        public static readonly N13 Rep = default;

        public static readonly NatSeq<N1,N3> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }

    public readonly struct N14 : NatSeq<N14>
    {
        public static readonly N14 Rep = default;

        public static readonly NatSeq<N1,N4> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }

    public readonly struct N15 : NatSeq<N15>
    {
        public static readonly N15 Rep = default;

        public static readonly NatSeq<N1,N5> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }


    public readonly struct N16 : NatSeq<N16>, IPow<N16,N2,N5>
    {
        public static readonly N16 Rep = default;

        public static readonly NatSeq<N1,N6> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }

    public readonly struct N17 : NatSeq<N17>
    {
        public static readonly N17 Rep = default;

        public static readonly NatSeq<N1,N7> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }

    public readonly struct N18 : NatSeq<N18>
    {
        public static readonly N18 Rep = default;

        public static readonly NatSeq<N1,N8> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }

    public readonly struct N19 : NatSeq<N19>
    {
        public static readonly N19 Rep = default;

        public static readonly NatSeq<N1,N9> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }

    public readonly struct N20 : NatSeq<N20>
    {
        public static readonly N20 Rep = default;

        public static readonly NatSeq<N2,N0> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }

    public readonly struct N32 : NatSeq<N32>, IPow<N32,N2,N6>
    {
        public static readonly N32 Rep = default;

        public static readonly NatSeq<N3,N2> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();
        
        public override string ToString() => format();

    }

    public readonly struct N64 : NatSeq<N64>, IPow<N64, N2,N6>
    {
        public static readonly N64 Rep = default;
        
        public static readonly NatSeq<N6,N4> Seq = default;
        
        public TypeNat rep => Rep;
        
        public NatSeq seq => Seq;
        
        public ulong value => Seq.value;
        
        public byte[] digits() => Seq.digits();
        
        public string format() => Seq.format();
        
        public override string ToString() => format();
    }

    public readonly struct N128 : NatSeq<N128>,  IPow<N128, N2,N7>
    {
        public static readonly N128 Rep = default;
        
        public static readonly NatSeq<N1,N2,N8> Seq = default;
        
        public TypeNat rep => Rep;
        
        public NatSeq seq => Seq;
        
        public ulong value => Seq.value;
        
        public byte[] digits() => Seq.digits();
        
        public string format() => Seq.format();
        
        public override string ToString() => format();
    }


    public readonly struct N256 : NatSeq<N256>, IPow<N256, N2,N8>
    {
        public static readonly N256 Rep = default;

        public static readonly NatSeq<N2,N5,N6> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq.seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }


    public readonly struct N512 : NatSeq<N512>, IPow<N512, N2,N9>
    {
        public static readonly N512 Rep = default;

        public static readonly NatSeq<N5,N1,N2> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq.seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }

    public readonly struct N1024 : NatSeq<N1024>, IPow<N1024, N2,N10>
    {
        public static readonly N1024 Rep = default;

        public static readonly NatSeq<N1,N0,N2,N4> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq.seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }

    public readonly struct N2048 : NatSeq<N2048>, IPow<N2048, N2, N11>
    {
        public static readonly N2048 Rep = default;

        public static readonly NatSeq<N2,N0,N4,N8> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq.seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }

    public readonly struct N4096 : NatSeq<N4096>, IPow<N4096, N2, N12>
    {
        public static readonly N4096 Rep = default;

        public static readonly NatSeq<N4,N0,N9,N6> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq.seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }

    public readonly struct N8192: NatSeq<N8192>, IPow<N8192, N2, N12>
    {
        public static readonly N8192 Rep = default;

        public static readonly NatSeq<N8,N1,N9,N2> Seq = default;

        public TypeNat rep => Rep;

        public NatSeq seq => Seq.seq;

        public ulong value => Seq.value;

        public byte[] digits() => Seq.digits();

        public string format() => Seq.format();

        public override string ToString() => format();
    }


}