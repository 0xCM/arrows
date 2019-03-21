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
    using C = Contracts;    
    using static corefunc;
    using static Nats;

    /// <summary>
    /// A nat sequence of length 1
    /// </summary>
    public readonly struct NatSeq<T0> : NatSeq
        where T0 : TypeNat
    {
        public static readonly NatSeq<T0> Inhabitant = default(NatSeq<T0>);

        static readonly uint SeqVal 
            = Nats.nat<T0>().value;
        public uint value => SeqVal;
        
        public override string ToString() 
            => SeqVal.ToString();    
    }

    /// <summary>
    /// A nat sequence of length 2
    /// </summary>
    public readonly struct NatSeq<T0,T1>  : NatSeq, TypeNat<NatSeq<T0,T1>>
        where T0 : TypeNat
        where T1 : TypeNat
    {
        public static readonly NatSeq<T0,T1> Inhabitant = default;

        static readonly uint SeqVal 
            = Nats.nat<T0>().value * 10
            + Nats.nat<T1>().value;
        public uint value => SeqVal;

        public NatSeq<T0, T1> current 
            => Inhabitant;

        public override string ToString() 
            => SeqVal.ToString();            
    }

    /// <summary>
    /// A nat sequence of length 3
    /// </summary>
    public readonly struct NatSeq<T0,T1,T2>  : NatSeq, TypeNat<NatSeq<T0,T1,T2>>
        where T0 : TypeNat
        where T1 : TypeNat
        where T2 : TypeNat
    {
        public static readonly NatSeq<T0,T1,T2> Inhabitant = default;
        static readonly uint SeqVal 
            = Nats.nat<T0>().value * 100
            + Nats.nat<T1>().value * 10
            + Nats.nat<T2>().value;
        
        public uint value => SeqVal;

        public NatSeq<T0, T1, T2> current => Inhabitant;

        public override string ToString() 
            => SeqVal.ToString();    

    }

    /// <summary>
    /// A nat sequence of length 4
    /// </summary>
    public readonly struct NatSeq<T0,T1,T2,T3>  : NatSeq, TypeNat<NatSeq<T0,T1,T2,T3>>
        where T0 : TypeNat
        where T1 : TypeNat
        where T2 : TypeNat
        where T3 : TypeNat
    {
        public static readonly NatSeq<T0,T1,T2,T3> Inhabitant = default(NatSeq<T0,T1,T2,T3>);

        static readonly uint SeqVal 
            = Nats.nat<T0>().value * 1000
            + Nats.nat<T1>().value * 100
            + Nats.nat<T2>().value * 10
            + Nats.nat<T3>().value;
        
        public uint value => SeqVal;

        public NatSeq<T0, T1, T2, T3> current => Inhabitant;

        public override string ToString() 
            => SeqVal.ToString();    
    }

    /// <summary>
    /// A nat sequence of length 5
    /// </summary>
    public readonly struct NatSeq<T0,T1,T2,T3,T4>  : NatSeq, TypeNat<NatSeq<T0,T1,T2,T3,T4>>
        where T0 : TypeNat
        where T1 : TypeNat
        where T2 : TypeNat
        where T3 : TypeNat
        where T4 : TypeNat
    {
        public static readonly NatSeq<T0,T1,T2,T3,T4> Inhabitant = default;

        static readonly uint SeqVal 
            = Nats.nat<T0>().value * 10000
            + Nats.nat<T1>().value * 1000
            + Nats.nat<T2>().value * 100
            + Nats.nat<T3>().value * 10
            + Nats.nat<T4>().value;
        
        public uint value => SeqVal;

        public NatSeq<T0, T1, T2, T3, T4> current => Inhabitant;

        public override string ToString() 
            => SeqVal.ToString();    
    }

    /// <summary>
    /// A nat sequence of length 6
    /// </summary>
    public readonly struct NatSeq<T0,T1,T2,T3,T4,T5>  : NatSeq, TypeNat<NatSeq<T0,T1,T2,T3,T4,T5>>
        where T0 : TypeNat
        where T1 : TypeNat
        where T2 : TypeNat
        where T3 : TypeNat
        where T4 : TypeNat
        where T5 : TypeNat
    {
        public static readonly NatSeq<T0,T1,T2,T3,T4,T5> Inhabitant = default;

        static readonly uint SeqVal 
            = Nats.nat<T0>().value * 100000
            + Nats.nat<T1>().value * 10000
            + Nats.nat<T2>().value * 1000
            + Nats.nat<T3>().value * 100
            + Nats.nat<T4>().value * 10
            + Nats.nat<T5>().value;
        
        public uint value => SeqVal;

        public NatSeq<T0, T1, T2, T3, T4, T5> current => Inhabitant;

        public override string ToString() 
            => SeqVal.ToString();    
    }

}