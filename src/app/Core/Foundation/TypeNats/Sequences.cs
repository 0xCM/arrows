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
    using static Nats;

    /// <summary>
    /// A nat sequence of length 1
    /// </summary>
    public readonly struct NatSeq<T0> : TypeNat
        where T0 : TypeNat, new()
    {
        public static readonly NatSeq<T0> Rep = default;

        public static readonly uint Value 
            = Nats.nat<T0>().value;
        
        public uint value 
            => Value;
        
        public override string ToString() 
            => Value.ToString();    
    }

    /// <summary>
    /// A nat sequence of length 2
    /// </summary>
    public readonly struct NatSeq<T0,T1>  : TypeNat<NatSeq<T0,T1>>
        where T0 : TypeNat, new()
        where T1 : TypeNat, new()
    {
        public static readonly NatSeq<T0,T1> Rep = default;

        public static readonly uint Value 
            = Nats.nat<T0>().value * 10
            + Nats.nat<T1>().value;

        public uint value 
            => Value;

        public NatSeq<T0, T1> rep 
            => Rep;


        public override string ToString() 
            => Value.ToString();            
    }

    /// <summary>
    /// A nat sequence of length 3
    /// </summary>
    public readonly struct NatSeq<T0,T1,T2>  : TypeNat<NatSeq<T0,T1,T2>>
        where T0 : TypeNat, new()
        where T1 : TypeNat, new()
        where T2 : TypeNat, new()
    {
        public static readonly NatSeq<T0,T1,T2> Rep = default;
        
        public static readonly uint Value 
            = Nats.nat<T0>().value * 100
            + Nats.nat<T1>().value * 10
            + Nats.nat<T2>().value;
        
        public uint value 
            => Value;

        public NatSeq<T0, T1, T2> rep 
            => Rep;

        public override string ToString() 
            => Value.ToString();    

    }

    /// <summary>
    /// A nat sequence of length 4
    /// </summary>
    public readonly struct NatSeq<T0,T1,T2,T3> : TypeNat<NatSeq<T0,T1,T2,T3>>
        where T0 : TypeNat, new()
        where T1 : TypeNat, new()
        where T2 : TypeNat, new()
        where T3 : TypeNat, new()
    {
        public static readonly NatSeq<T0,T1,T2,T3> Rep = default;

        public static readonly uint Value 
            = Nats.nat<T0>().value * 1000
            + Nats.nat<T1>().value * 100
            + Nats.nat<T2>().value * 10
            + Nats.nat<T3>().value;

        public uint value 
            => Value;

        public NatSeq<T0, T1, T2, T3> rep 
            => Rep;

        public override string ToString() 
            => Value.ToString();    
    }

    /// <summary>
    /// A nat sequence of length 5
    /// </summary>
    public readonly struct NatSeq<T0,T1,T2,T3,T4>  : TypeNat<NatSeq<T0,T1,T2,T3,T4>>
        where T0 : TypeNat, new()
        where T1 : TypeNat, new()
        where T2 : TypeNat, new()
        where T3 : TypeNat, new()
        where T4 : TypeNat, new()
    {
        public static readonly NatSeq<T0,T1,T2,T3,T4> Rep = default;

        public static readonly uint Value 
            = Nats.nat<T0>().value * 10000
            + Nats.nat<T1>().value * 1000
            + Nats.nat<T2>().value * 100
            + Nats.nat<T3>().value * 10
            + Nats.nat<T4>().value;

        public uint value 
            => Value;

        public NatSeq<T0, T1, T2, T3, T4> rep 
            => Rep;

        public override string ToString() 
            => Value.ToString();    
    }

    /// <summary>
    /// A nat sequence of length 6
    /// </summary>
    public readonly struct NatSeq<T0,T1,T2,T3,T4,T5> : TypeNat<NatSeq<T0,T1,T2,T3,T4,T5>>
        where T0 : TypeNat, new()
        where T1 : TypeNat, new()
        where T2 : TypeNat, new()
        where T3 : TypeNat, new()
        where T4 : TypeNat, new()
        where T5 : TypeNat, new()
    {
        public static readonly NatSeq<T0,T1,T2,T3,T4,T5> Rep = default;

        public static readonly uint Value 
            = Nats.nat<T0>().value * 100000
            + Nats.nat<T1>().value * 10000
            + Nats.nat<T2>().value * 1000
            + Nats.nat<T3>().value * 100
            + Nats.nat<T4>().value * 10
            + Nats.nat<T5>().value;

    
        public uint value 
            => Value;

        public NatSeq<T0, T1, T2, T3, T4, T5> rep 
            => Rep;

        public override string ToString() 
            => Value.ToString();    
    }

    
}