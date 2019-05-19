namespace Z0
{
    //using N20 = NatSeq<N2,N0>;
    using System.Runtime.CompilerServices;
    using static nfunc;

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

        public static N63 N63 = default;

        public static N64 N64 = default;

        public static N127 N127 = default;

        public static N128 N128 = default;

        public static N255 N255 = default;

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

        public override bool Equals(object obj)
            => obj is N10;

        [MethodImpl(Inline)]
        public static bool operator ==(N10 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N10 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N10 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N10 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N10 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N10 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N11 : NatSeq<N11>
    {
        public static readonly N11 Rep = default;

        public static readonly NatSeq<N1,N1> Seq = default;

        public override bool Equals(object obj)
            => obj is N11;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() => format();

        public override int GetHashCode()
            => value.GetHashCode();
     }

    public readonly struct N12 : NatSeq<N12>
    {
        public static readonly N12 Rep = default;

        public static readonly NatSeq<N1,N2> Seq = default;

        public override bool Equals(object obj)
            => obj is N12;


        public ITypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N13 : NatSeq<N13>
    {
        public static readonly N13 Rep = default;

        public static readonly NatSeq<N1,N3> Seq = default;

        public override bool Equals(object obj)
            => obj is N13;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();

        public override string ToString() 
            => Seq.format();

        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N14 : NatSeq<N14>
    {
        public static readonly N14 Rep = default;

        public static readonly NatSeq<N1,N4> Seq = default;

        public override bool Equals(object obj)
            => obj is N14;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N15 : NatSeq<N15>
    {
        public static readonly N15 Rep = default;

        public static readonly NatSeq<N1,N5> Seq = default;

        public override bool Equals(object obj)
            => obj is N15;

        [MethodImpl(Inline)]
        public static bool operator ==(N15 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N15 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N15 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N15 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N15 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N15 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }


    public readonly struct N16 : NatSeq<N16>, INatPow<N16,N2,N5>
    {
        public static readonly N16 Rep = default;

        public static readonly NatSeq<N1,N6> Seq = default;

        
        public override bool Equals(object obj)
            => obj is N16;

        [MethodImpl(Inline)]
        public static bool operator ==(N16 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N16 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N16 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N16 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N16 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N16 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N17 : NatSeq<N17>
    {
        public static readonly N17 Rep = default;

        public static readonly NatSeq<N1,N7> Seq = default;

        public override bool Equals(object obj)
            => obj is N17;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N18 : NatSeq<N18>
    {
        public static readonly N18 Rep = default;

        public static readonly NatSeq<N1,N8> Seq = default;

        public override bool Equals(object obj)
            => obj is N18;

        [MethodImpl(Inline)]
        public static bool operator ==(N18 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N18 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N18 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N18 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N18 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N18 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N19 : NatSeq<N19>
    {
        public static readonly N19 Rep = default;

        public static readonly NatSeq<N1,N9> Seq = default;

        public override bool Equals(object obj)
            => obj is N19;

        [MethodImpl(Inline)]
        public static bool operator ==(N19 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N19 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N19 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N19 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N19 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N19 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N20 : NatSeq<N20>
    {
        public static readonly N20 Rep = default;

        public static readonly NatSeq<N2,N0> Seq = default;

        public override bool Equals(object obj)
            => obj is N20;

        [MethodImpl(Inline)]
        public static bool operator ==(N20 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N20 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N20 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N20 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N20 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N20 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() 
            => Seq.format();

        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N32 : NatSeq<N32>, INatPow<N32,N2,N6>
    {
        public static readonly N32 Rep = default;

        public static readonly NatSeq<N3,N2> Seq = default;


        public override bool Equals(object obj)
            => obj is N32;

        [MethodImpl(Inline)]
        public static bool operator ==(N32 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N32 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N32 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N32 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N32 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N32 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();
        
        public override string ToString() => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }
    public readonly struct N63 : NatSeq<N63>, IPrior<N63,N64>
    {
        public static readonly N63 Rep = default;

        public static readonly NatSeq<N6,N3> Seq = default;
        
        public override bool Equals(object obj)
            => obj is N63;

        [MethodImpl(Inline)]
        public static bool operator ==(N63 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N63 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N63 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N63 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N63 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N63 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;
        
        public NatSeq seq => Seq;
        
        public ulong value => Seq.value;
        
        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();
        
        public string format() => Seq.format();
        
        public override string ToString() => format();
        
        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N64 : NatSeq<N64>, INatPow<N64, N2,N6>
    {
        [MethodImpl(Inline)]
        public static bool operator ==(N64 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N64 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N64 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N64 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N64 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N64 rhs)
            => (ulong)lhs >= rhs.value;

        public static readonly N64 Rep = default;
        
        public static readonly NatSeq<N6,N4> Seq = default;
        
        public ITypeNat rep => Rep;
        
        public NatSeq seq => Seq;
        
        public ulong value => Seq.value;
        
        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();
        
        public string format() => Seq.format();
        
        public override string ToString() => format();

        public override bool Equals(object obj)
            => obj is N64;
        
        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N127 : NatSeq<N127>, IPrior<N127,N128>
    {
        [MethodImpl(Inline)]
        public static bool operator ==(N127 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N127 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N127 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N127 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N127 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N127 rhs)
            => (ulong)lhs >= rhs.value;

        public static readonly N127 Rep = default;
        
        public static readonly NatSeq<N1,N2,N7> Seq = default;
        
        public ITypeNat rep => Rep;
        
        public NatSeq seq => Seq;
        
        public ulong value => Seq.value;
        
        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();
        
        public string format() => Seq.format();
        
        public override string ToString() => format();

        public override bool Equals(object obj)
            => obj is N127;
        
        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N128 : NatSeq<N128>,  INatPow<N128, N2,N7>
    {
        [MethodImpl(Inline)]
        public static bool operator ==(N128 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N128 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N128 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N128 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N128 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N128 rhs)
            => (ulong)lhs >= rhs.value;

        public static readonly N128 Rep = default;
        
        public static readonly NatSeq<N1,N2,N8> Seq = default;
        
        public ITypeNat rep => Rep;
        
        public NatSeq seq => Seq;
        
        public ulong value => Seq.value;
        
        byte[] ITypeNat.Digits() => (Seq as ITypeNat).Digits();
        
        public string format() => Seq.format();
        
        public override string ToString() => format();

        public override bool Equals(object obj)
            => obj is N128;
        
        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N255 : NatSeq<N255>, IPrior<N255,N256>
    {
        public static readonly N255 Rep = default;

        public static readonly NatSeq<N2,N5,N5> Seq = default;

        public override bool Equals(object obj)
            => obj is N255;

        [MethodImpl(Inline)]
        public static bool operator ==(N255 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N255 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N255 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N255 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N255 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N255 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq.seq;

        public ulong value 
            => Seq.value;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() 
            => Seq.format();
        
        public override int GetHashCode()
            => value.GetHashCode();
    }


    public readonly struct N256 : NatSeq<N256>, INatPow<N256, N2,N8>
    {
        public static readonly N256 Rep = default;

        public static readonly NatSeq<N2,N5,N6> Seq = default;

        public override bool Equals(object obj)
            => obj is N256;

        [MethodImpl(Inline)]
        public static bool operator ==(N256 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N256 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N256 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N256 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N256 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N256 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq.seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() 
            => Seq.format();
        
        public override int GetHashCode()
            => value.GetHashCode();
    }


    public readonly struct N512 : NatSeq<N512>, INatPow<N512, N2,N9>
    {
        public static readonly N512 Rep = default;

        public static readonly NatSeq<N5,N1,N2> Seq = default;


        [MethodImpl(Inline)]
        public static bool operator ==(N512 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N512 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N512 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N512 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N512 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N512 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq.seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();

        public string format() => Seq.format();

        public override string ToString() => format();

        public override bool Equals(object obj)
            => obj is N512;
        
        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N1024 : NatSeq<N1024>, INatPow<N1024, N2,N10>
    {
        public static readonly N1024 Rep = default;

        public static readonly NatSeq<N1,N0,N2,N4> Seq = default;

        public override bool Equals(object obj)
            => obj is N1024;
 
        [MethodImpl(Inline)]
        public static bool operator ==(N1024 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N1024 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N1024 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N1024 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N1024 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N1024 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq.seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();


        public override string ToString() 
            => Seq.format();
       
        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N2048 : NatSeq<N2048>, INatPow<N2048, N2, N11>
    {
        public static readonly N2048 Rep = default;

        public static readonly NatSeq<N2,N0,N4,N8> Seq = default;

        [MethodImpl(Inline)]
        public static bool operator ==(N2048 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N2048 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N2048 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N2048 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N2048 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N2048 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq.seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();

        public override string ToString() 
            => Seq.format();

        public override bool Equals(object obj)
            => obj is N2048;
        
        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N4096 : NatSeq<N4096>, INatPow<N4096, N2, N12>
    {
        public static readonly N4096 Rep = default;

        public static readonly NatSeq<N4,N0,N9,N6> Seq = default;

        public override bool Equals(object obj)
            => obj is N4096;

        [MethodImpl(Inline)]
        public static bool operator ==(N4096 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N4096 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N4096 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N4096 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N4096 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N4096 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq.seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();

        public override string ToString() 
            => Seq.format();
        
        public override int GetHashCode()
            => value.GetHashCode();
    }

    public readonly struct N8192: NatSeq<N8192>, INatPow<N8192, N2, N12>
    {
        public static readonly N8192 Rep = default;

        public static readonly NatSeq<N8,N1,N9,N2> Seq = default;

 
        public override bool Equals(object obj)
            => obj is N8192;

        [MethodImpl(Inline)]
        public static bool operator ==(N8192 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N8192 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N8192 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N8192 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N8192 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N8192 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep => Rep;

        public NatSeq seq => Seq.seq;

        public ulong value => Seq.value;

        byte[] ITypeNat.Digits() 
            => (Seq as ITypeNat).Digits();
 
        public override string ToString() 
            => Seq.format();
        
        public override int GetHashCode()
            => value.GetHashCode();
   }


}