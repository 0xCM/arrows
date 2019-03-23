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
    public readonly struct NatSeq<T1> : Traits.NatSeq<NatSeq<T1>,T1>
        where T1 : TypeNat, new()
    {
        public static readonly NatSeq<T1> Rep = default;
        
        public static readonly uint Value 
            = Nat.nat<T1>().value;
        
        public static readonly byte[] Digits 
            = corefunc.digits(Value);
        
        public uint value 
            => Value;

        public NatSeq<T1> rep
            => Rep; 

        public byte[] digits()
            => Digits;

        public override string ToString() 
            => Value.ToString();    
    }

    /// <summary>
    /// A nat sequence of length 2
    /// </summary>
    public readonly struct NatSeq<T1,T2> : Traits.NatSeq<NatSeq<T1,T2>,T1,T2>  
        where T1 : TypeNat, new()
        where T2 : TypeNat, new()
    {
        public static readonly NatSeq<T1,T2> Rep = default;

        public static readonly uint Value 
            = Nat.nat<T1>().value * 10
            + Nat.nat<T2>().value;

        public static readonly byte[] Digits 
            = corefunc.digits(Value);

        public uint value 
            => Value;

        public NatSeq<T1, T2> rep 
            => Rep;

        public byte[] digits()
            => Digits;

        public override string ToString() 
            => Value.ToString();            
    }

    /// <summary>
    /// A nat sequence of length 3
    /// </summary>
    public readonly struct NatSeq<T1,T2,T3>  
        : Traits.NatSeq
        <
            NatSeq<T1,T2,T3>,
            T1,T2,T3
        >
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
    {
        public static readonly NatSeq<T1,T2,T3> Rep = default;
        
        public static readonly uint Value 
            = Nat.nat<T1>().value * 100
            + Nat.nat<T2>().value * 10
            + Nat.nat<T3>().value;

        public static readonly byte[] Digits 
            = corefunc.digits(Value);

        public uint value 
            => Value;

        public NatSeq<T1, T2, T3> rep 
            => Rep;

        public override string ToString() 
            => Value.ToString();    
    }

    /// <summary>
    /// A nat sequence of length 4
    /// </summary>
    public readonly struct NatSeq<T1,T2,T3,T4> 
        : Traits.NatSeq
        <
            NatSeq<T1,T2,T3,T4>,
            T1,T2,T3,T4
        >
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
    {
        public static readonly NatSeq<T1,T2,T3,T4> Rep = default;

        public static readonly uint Value 
            = Nat.nat<T1>().value * 1000
            + Nat.nat<T2>().value * 100
            + Nat.nat<T3>().value * 10
            + Nat.nat<T4>().value;

        public static readonly byte[] Digits 
            = corefunc.digits(Value);

        public uint value 
            => Value;

        public NatSeq<T1, T2, T3, T4> rep 
            => Rep;

        public byte[] digits()
            => Digits;

        public override string ToString() 
            => Value.ToString();    
    }

    /// <summary>
    /// A nat sequence of length 5
    /// </summary>
    public readonly struct NatSeq<T1,T2,T3,T4,T5>
        : Traits.NatSeq
        <
            NatSeq<T1,T2,T3,T4,T5>,
            T1,T2,T3,T4,T5
        >
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
            where T5 : TypeNat, new()
    {
        public static readonly NatSeq<T1,T2,T3,T4,T5> Rep = default;

        public static readonly uint Value 
            = Nat.nat<T1>().value * 10000
            + Nat.nat<T2>().value * 1000
            + Nat.nat<T3>().value * 100
            + Nat.nat<T4>().value * 10
            + Nat.nat<T5>().value;

        public static readonly byte[] Digits 
            = corefunc.digits(Value);

        public uint value 
            => Value;

        public NatSeq<T1, T2, T3, T4, T5> rep 
            => Rep;

        public byte[] digits()
            => Digits;

        public override string ToString() 
            => Value.ToString();    
    }

    /// <summary>
    /// A nat sequence of length 6
    /// </summary>
    public readonly struct NatSeq<T1,T2,T3,T4,T5,T6> 
        : Traits.NatSeq
        <
            NatSeq<T1,T2,T3,T4,T5,T6>,
            T1,T2,T3,T4,T5,T6
        >
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
            where T5 : TypeNat, new()
            where T6 : TypeNat, new()
    {
        public static readonly NatSeq<T1,T2,T3,T4,T5,T6> Rep = default;

        public static readonly uint Value 
            = Nat.nat<T1>().value * 100000
            + Nat.nat<T2>().value * 10000
            + Nat.nat<T3>().value * 1000
            + Nat.nat<T4>().value * 100
            + Nat.nat<T5>().value * 10
            + Nat.nat<T6>().value;

        public static readonly byte[] Digits 
            = corefunc.digits(Value);
    
        public uint value 
            => Value;

        public NatSeq<T1, T2, T3, T4, T5, T6> rep 
            => Rep;

        public byte[] digits()
            => Digits;

        public override string ToString() 
            => Value.ToString();    
    }

   /// <summary>
    /// A nat sequence of length 7
    /// </summary>
    public readonly struct NatSeq<T1,T2,T3,T4,T5,T6,T7> 
        : Traits.NatSeq
        <
            NatSeq<T1,T2,T3,T4,T5,T6,T7>,
            T1,T2,T3,T4,T5,T6,T7
        >
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
            where T5 : TypeNat, new()
            where T6 : TypeNat, new()
            where T7 : TypeNat, new()
    {
        public static readonly NatSeq<T1,T2,T3,T4,T5,T6,T7> Rep = default;

        public static readonly uint Value 
            = Nat.nat<T1>().value * 1000000
            + Nat.nat<T2>().value * 100000
            + Nat.nat<T3>().value * 10000
            + Nat.nat<T4>().value * 1000
            + Nat.nat<T5>().value * 100
            + Nat.nat<T6>().value * 10
            + Nat.nat<T7>().value;

        public static readonly byte[] Digits 
            = corefunc.digits(Value);

        public uint value 
            => Value;

        public NatSeq<T1, T2, T3, T4, T5, T6, T7> rep 
            => Rep;

        public byte[] digits()
            => Digits;

        public override string ToString() 
            => Value.ToString();    
    }
   
}