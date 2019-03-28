//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class Traits
    {
        /// <summary>
        /// Characterizes a natural number k such that p:P and e:E => k = p^e
        /// where p is prime
        /// </summary>
        /// <typeparam name="P"></typeparam>
        /// <typeparam name="E"></typeparam>
        public interface PrimePow<P,E> : TypeNat
            where P : TypeNat, Demands.Prime<P>,  new()
            where E : TypeNat, new()
        {

        }

        /// <summary>
        /// Characterizes a reification of a natural prime base 
        /// raised to a natural power
        /// </summary>
        public interface PrimePow<K,P,E> : PrimePow<P,E>, Pow<K, P, E>
            where K : PrimePow<K,P,E>, new()
            where P : TypeNat, Demands.Prime<P>, new()
            where E : TypeNat, new()
        {

        }

    }
        
    /// <summary>
    /// Reifies a natural prime base raised to a natural power
    /// </summary>
    public readonly struct PrimePow<P, E> : Traits.PrimePow<PrimePow<P,E>, P, E>
        where E : TypeNat, new()
        where P : TypeNat, Demands.Prime<P>, new()
    {
        public static readonly PrimePow<P,E> Rep = default;

        public static readonly Pow<P,E> Seq = default;

        public static readonly uint Value = Seq.value;

        public TypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq.seq;

        public uint value 
            => Seq.value;

        public byte[] digits() 
            => Seq.digits();

        public override string ToString() 
            => value.ToString();
    }

}