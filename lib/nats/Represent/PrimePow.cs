//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
        
    /// <summary>
    /// Reifies a natural prime base raised to a natural power
    /// </summary>
    public readonly struct PrimePow<P, E> : TypeNat
        where E : TypeNat, new()
        where P : TypeNat, IPrime<P>, new()
    {
        public static readonly PrimePow<P,E> Rep = default;

        public static readonly Pow<P,E> Seq = default;

        public static readonly ulong Value = Seq.value;

        public TypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq.seq;

        public ulong value 
            => Seq.value;

        public byte[] digits() 
            => Seq.digits();

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }

}