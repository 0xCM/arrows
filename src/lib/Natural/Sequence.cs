//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Reflection;
    using static zcore;

    partial class Traits
    {
        /// <summary>
        /// Characterizes a natural sequence with an unspecified number of terms
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        public interface NatSeq<S> : TypeNat<S>, NatSeq
            where S : NatSeq<S>, new()
        {

        }

        /// <summary>
        /// Characterizes a one-term natural sequence 
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        /// <typeparam name="T1">The type of the singleton term</typeparam>
        public interface NatSeq<S,T1> : TypeNat<S>, NatSeq
            where S : NatSeq<S,T1>, new()
            where T1 : TypeNat, new()
        {

        }

        /// <summary>
        /// Characterizes a two-term natural sequence
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        /// <typeparam name="T1">The type of the first term</typeparam>
        /// <typeparam name="T2">The type of the second term</typeparam>
        public interface NatSeq<S,T1,T2> : TypeNat<S>, NatSeq
            where S : NatSeq<S,T1,T2>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
        {

        }

        /// <summary>
        /// Characterizes a three-term natural sequence
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        /// <typeparam name="T1">The type of the first term</typeparam>
        /// <typeparam name="T2">The type of the second term</typeparam>
        /// <typeparam name="T3">The type of the third term</typeparam>
        public interface NatSeq<S,T1,T2,T3> : TypeNat<S>
            where S : NatSeq<S,T1,T2,T3>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
        {

        }

        /// <summary>
        /// Characterizes a four-term natural sequence
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        /// <typeparam name="T1">The type of the first term</typeparam>
        /// <typeparam name="T2">The type of the second term</typeparam>
        /// <typeparam name="T3">The type of the third term</typeparam>
        /// <typeparam name="T4">The type of the fourth term</typeparam>
        public interface NatSeq<S,T1,T2,T3,T4> : TypeNat<S>
            where S : NatSeq<S,T1,T2,T3,T4>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
        {

        }

        /// <summary>
        /// Characterizes a five-term natural sequence
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        /// <typeparam name="T1">The type of the first term</typeparam>
        /// <typeparam name="T2">The type of the second term</typeparam>
        /// <typeparam name="T3">The type of the third term</typeparam>
        /// <typeparam name="T4">The type of the fourth term</typeparam>
        /// <typeparam name="T5">The type of the fifth term</typeparam>
        public interface NatSeq<S,T1,T2,T3,T4,T5> : TypeNat<S>
            where S : NatSeq<S,T1,T2,T3,T4,T5>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
            where T5 : TypeNat, new()        
        {

        }

        /// <summary>
        /// Characterizes a six-term natural sequence
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        /// <typeparam name="T1">The type of the first term</typeparam>
        /// <typeparam name="T2">The type of the second term</typeparam>
        /// <typeparam name="T3">The type of the third term</typeparam>
        /// <typeparam name="T4">The type of the fourth term</typeparam>
        /// <typeparam name="T5">The type of the fifth term</typeparam>
        /// <typeparam name="T6">The type of the sixth term</typeparam>
        public interface NatSeq<S,T1,T2,T3,T4,T5,T6> : TypeNat<S>
            where S : NatSeq<S,T1,T2,T3,T4,T5,T6>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
            where T5 : TypeNat, new()        
            where T6 : TypeNat, new()        
        {

        }

        /// <summary>
        /// Characterizes a seven-term natural sequence
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        /// <typeparam name="T1">The type of the first term</typeparam>
        /// <typeparam name="T2">The type of the second term</typeparam>
        /// <typeparam name="T3">The type of the third term</typeparam>
        /// <typeparam name="T4">The type of the fourth term</typeparam>
        /// <typeparam name="T5">The type of the fifth term</typeparam>
        /// <typeparam name="T6">The type of the sixth term</typeparam>
        /// <typeparam name="T7">The type of the seventh term</typeparam>
        public interface NatSeq<S,T1,T2,T3,T4,T5,T6,T7> : TypeNat<S>
            where S : NatSeq<S,T1,T2,T3,T4,T5,T6,T7>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
            where T5 : TypeNat, new()        
            where T6 : TypeNat, new()        
            where T7 : TypeNat, new()        
        {

        }

        /// <summary>
        /// Characterizes an eight-term natural sequence
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        /// <typeparam name="T1">The type of the first term</typeparam>
        /// <typeparam name="T2">The type of the second term</typeparam>
        /// <typeparam name="T3">The type of the third term</typeparam>
        /// <typeparam name="T4">The type of the fourth term</typeparam>
        /// <typeparam name="T5">The type of the fifth term</typeparam>
        /// <typeparam name="T6">The type of the sixth term</typeparam>
        /// <typeparam name="T7">The type of the seventh term</typeparam>
        /// <typeparam name="T8">The type of the eight term</typeparam>
        public interface NatSeq<S,T1,T2,T3,T4,T5,T6,T7,T8> : TypeNat<S>
            where S : NatSeq<S,T1,T2,T3,T4,T5,T6,T7,T8>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
            where T5 : TypeNat, new()        
            where T6 : TypeNat, new()        
            where T7 : TypeNat, new()        
            where T8 : TypeNat, new()        
        {

        }


    }

    /// <summary>
    /// Reifies a one-term natural sequence
    /// </summary>
    /// <typeparam name="T1">The type of the first term</typeparam>
    public readonly struct NatSeq<T1> : Traits.NatSeq<NatSeq<T1>,T1>
        where T1 : TypeNat, new()
    {
        public static readonly NatSeq<T1> Rep = default;
        
        public static readonly uint Value 
            = Nat.nat<T1>().value;
        
        public static readonly byte[] Digits 
            = zcore.digits(Value);
        
        public uint value 
            => Value;

        public TypeNat rep
            => Rep; 

        public byte[] digits()
            => Digits;

        public override string ToString() 
            => Value.ToString();    
    }

    /// <summary>
    /// Reifies a two-term natural sequence
    /// </summary>
    /// <typeparam name="T1">The type of the first term</typeparam>
    /// <typeparam name="T2">The type of the second term</typeparam>
    public readonly struct NatSeq<T1,T2> : Traits.NatSeq<NatSeq<T1,T2>,T1,T2>  
        where T1 : TypeNat, new()
        where T2 : TypeNat, new()
    {
        public static readonly NatSeq<T1,T2> Rep = default;

        public static readonly uint Value 
            = Nat.nat<T1>().value * 10
            + Nat.nat<T2>().value;

        public static readonly byte[] Digits 
            = zcore.digits(Value);

        public uint value 
            => Value;

        public TypeNat rep 
            => Rep;

        public byte[] digits()
            => Digits;

        public override string ToString() 
            => Value.ToString();            
    }

    /// <summary>
    /// Reifies a three-term natural sequence
    /// </summary>
    /// <typeparam name="T1">The type of the first term</typeparam>
    /// <typeparam name="T2">The type of the second term</typeparam>
    /// <typeparam name="T3">The type of the third term</typeparam>
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
            = zcore.digits(Value);

        public uint value 
            => Value;

        public byte[] digits() 
            => Digits;

        public TypeNat rep 
            => Rep;

        public override string ToString() 
            => Value.ToString();    
    }

    /// <summary>
    /// Reifies a four-term natural sequence
    /// </summary>
    /// <typeparam name="T1">The type of the first term</typeparam>
    /// <typeparam name="T2">The type of the second term</typeparam>
    /// <typeparam name="T3">The type of the third term</typeparam>
    /// <typeparam name="T4">The type of the fourth term</typeparam>
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
            = zcore.digits(Value);

        public uint value 
            => Value;

        public TypeNat rep 
            => Rep;

        public byte[] digits()
            => Digits;

        public override string ToString() 
            => Value.ToString();    
    }

    /// <summary>
    /// Reifies a five-term natural sequence
    /// </summary>
    /// <typeparam name="T1">The type of the first term</typeparam>
    /// <typeparam name="T2">The type of the second term</typeparam>
    /// <typeparam name="T3">The type of the third term</typeparam>
    /// <typeparam name="T4">The type of the fourth term</typeparam>
    /// <typeparam name="T5">The type of the fifth term</typeparam>
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
            = zcore.digits(Value);

        public uint value 
            => Value;

        public TypeNat rep 
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
            = zcore.digits(Value);
    
        public uint value 
            => Value;

        public TypeNat rep 
            => Rep;

        public byte[] digits()
            => Digits;

        public override string ToString() 
            => Value.ToString();    
    }

    /// <summary>
    /// Reifies a seven-term natural sequence
    /// </summary>
    /// <typeparam name="T1">The type of the first term</typeparam>
    /// <typeparam name="T2">The type of the second term</typeparam>
    /// <typeparam name="T3">The type of the third term</typeparam>
    /// <typeparam name="T4">The type of the fourth term</typeparam>
    /// <typeparam name="T5">The type of the fifth term</typeparam>
    /// <typeparam name="T6">The type of the sixth term</typeparam>
    /// <typeparam name="T7">The type of the seventh term</typeparam>
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
            = zcore.digits(Value);

        public uint value 
            => Value;

        public TypeNat rep 
            => Rep;

        public byte[] digits()
            => Digits;

        public override string ToString() 
            => Value.ToString();    
    }

    /// <summary>
    /// Reifies an eight-term natural sequence
    /// </summary>
    /// <typeparam name="T1">The type of the first term</typeparam>
    /// <typeparam name="T2">The type of the second term</typeparam>
    /// <typeparam name="T3">The type of the third term</typeparam>
    /// <typeparam name="T4">The type of the fourth term</typeparam>
    /// <typeparam name="T5">The type of the fifth term</typeparam>
    /// <typeparam name="T6">The type of the sixth term</typeparam>
    /// <typeparam name="T7">The type of the seventh term</typeparam>
    /// <typeparam name="T8">The type of the eight term</typeparam>
    public readonly struct NatSeq<T1,T2,T3,T4,T5,T6,T7,T8> 
        : Traits.NatSeq
        <
            NatSeq<T1,T2,T3,T4,T5,T6,T7,T8>,
            T1,T2,T3,T4,T5,T6,T7,T8
        >
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
            where T5 : TypeNat, new()
            where T6 : TypeNat, new()
            where T7 : TypeNat, new()
            where T8 : TypeNat, new()
    {
        public static readonly NatSeq<T1,T2,T3,T4,T5,T6,T7,T8> Rep = default;

        public static readonly uint Value 
            = Nat.nat<T1>().value * 10000000
            + Nat.nat<T2>().value * 1000000
            + Nat.nat<T3>().value * 100000
            + Nat.nat<T4>().value * 10000
            + Nat.nat<T5>().value * 1000
            + Nat.nat<T6>().value * 100
            + Nat.nat<T7>().value * 10
            + Nat.nat<T8>().value;

        public static readonly byte[] Digits 
            = zcore.digits(Value);

        public uint value 
            => Value;

        public TypeNat rep 
            => Rep;

        public byte[] digits()
            => Digits;

        public override string ToString() 
            => Value.ToString();    
    }
 
}