//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
        
    /// <summary>
    /// Reifies a natural prime base raised to a natural power
    /// </summary>
    public readonly struct PrimePow<P, E> : ITypeNat
        where E : ITypeNat, new()
        where P : ITypeNat, INatPrime<P>, new()
    {
        public static readonly PrimePow<P,E> Rep = default;

        public static readonly Pow<P,E> Seq = default;

        public static readonly ulong Value = Seq.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq.seq;

        public ulong value 
            => Seq.value;

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }

}