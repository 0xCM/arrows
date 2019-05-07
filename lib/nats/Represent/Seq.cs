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
    using static mfunc;

    /// <summary>
    /// Characterizes a type-level sequence of typenats
    /// </summary>
    public interface NatSeq : ITypeNat
    {

    }

    /// <summary>
    /// Characterizes a natural sequence with an unspecified number of terms
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    public interface NatSeq<S> : TypeNat<S>, NatSeq
        where S : NatSeq<S>, new()
    {

    }


    /// <summary>
    /// Reifies a one-term natural sequence
    /// </summary>
    /// <typeparam name="K1">The type of the first term</typeparam>
    public readonly struct NatSeq1<K1> : NatSeq<NatSeq1<K1>>
        where K1 : NatPrimitive<K1>, new()
    {
        public static readonly NatSeq1<K1> Rep = default;
        
        public static readonly ulong Value 
            = Nat.nat<K1>().value;
        
        public static readonly byte[] Digits 
            = mfunc.digits(Value);
        
        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        byte[] ITypeNat.Digits()
            => Digits;

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// Reifies a two-term natural sequence
    /// </summary>
    /// <typeparam name="K1">The type of the first term</typeparam>
    /// <typeparam name="K2">The type of the second term</typeparam>
    public readonly struct NatSeq<K1,K2> : NatSeq<NatSeq<K1,K2>>
        where K1 : NatPrimitive<K1>, new()
        where K2 : NatPrimitive<K2>, new()
    {
        public static readonly NatSeq<K1,K2> Rep = default;

        public static readonly ulong Value 
            = Nat.nat<K1>().value * 10
            + Nat.nat<K2>().value;

        public static readonly byte[] Digits 
            = mfunc.digits(Value);

        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        byte[] ITypeNat.Digits()
            => Digits;

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// Reifies a three-term natural sequence
    /// </summary>
    /// <typeparam name="K1">The type of the first term</typeparam>
    /// <typeparam name="K2">The type of the second term</typeparam>
    /// <typeparam name="K3">The type of the third term</typeparam>
    public readonly struct NatSeq<K1,K2,K3> : NatSeq<NatSeq<K1,K2,K3>>
        where K1 : NatPrimitive<K1>, new()
        where K2 : NatPrimitive<K2>, new()
        where K3 : NatPrimitive<K3>, new()
    {
        public static readonly NatSeq<K1,K2,K3> Rep = default;
        
        public static readonly ulong Value 
            = Nat.nat<K1>().value * 100
            + Nat.nat<K2>().value * 10
            + Nat.nat<K3>().value;

        public static readonly byte[] Digits 
            = mfunc.digits(Value);

        public ulong value 
            => Value;

        byte[] ITypeNat.Digits()
            => Digits;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// Reifies a four-term natural sequence
    /// </summary>
    /// <typeparam name="K1">The type of the first term</typeparam>
    /// <typeparam name="K2">The type of the second term</typeparam>
    /// <typeparam name="K3">The type of the third term</typeparam>
    /// <typeparam name="K4">The type of the fourth term</typeparam>
    public readonly struct NatSeq<K1,K2,K3,K4> : NatSeq<NatSeq<K1,K2,K3,K4>>
        where K1 : NatPrimitive<K1>, new()
        where K2 : NatPrimitive<K2>, new()
        where K3 : NatPrimitive<K3>, new()
        where K4 : NatPrimitive<K4>, new()
    {
        public static readonly NatSeq<K1,K2,K3,K4> Rep = default;

        public static readonly ulong Value 
            = Nat.nat<K1>().value * 1000
            + Nat.nat<K2>().value * 100
            + Nat.nat<K3>().value * 10
            + Nat.nat<K4>().value;

        public static readonly byte[] Digits 
            = mfunc.digits(Value);

        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        byte[] ITypeNat.Digits()
            => Digits;

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// Reifies a five-term natural sequence
    /// </summary>
    /// <typeparam name="K1">The type of the first term</typeparam>
    /// <typeparam name="K2">The type of the second term</typeparam>
    /// <typeparam name="K3">The type of the third term</typeparam>
    /// <typeparam name="K4">The type of the fourth term</typeparam>
    /// <typeparam name="K5">The type of the fifth term</typeparam>
    public readonly struct NatSeq<K1,K2,K3,K4,K5> : NatSeq<NatSeq<K1,K2,K3,K4,K5>>
        where K1 : NatPrimitive<K1>, new()
        where K2 : NatPrimitive<K2>, new()
        where K3 : NatPrimitive<K3>, new()
        where K4 : NatPrimitive<K4>, new()
        where K5 : NatPrimitive<K5>, new()
    {
        public static readonly NatSeq<K1,K2,K3,K4,K5> Rep = default;

        public static readonly ulong Value 
            = Nat.nat<K1>().value * 10000
            + Nat.nat<K2>().value * 1000
            + Nat.nat<K3>().value * 100
            + Nat.nat<K4>().value * 10
            + Nat.nat<K5>().value;

        public static readonly byte[] Digits 
            = mfunc.digits(Value);

        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        byte[] ITypeNat.Digits()
            => Digits;

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// A nat sequence of length 6
    /// </summary>
    public readonly struct NatSeq<K1,K2,K3,K4,K5,K6> : NatSeq<NatSeq<K1,K2,K3,K4,K5,K6>>
        where K1 : NatPrimitive<K1>, new()
        where K2 : NatPrimitive<K2>, new()
        where K3 : NatPrimitive<K3>, new()
        where K4 : NatPrimitive<K4>, new()
        where K5 : NatPrimitive<K5>, new()
        where K6 : NatPrimitive<K6>, new()
    {
        public static readonly NatSeq<K1,K2,K3,K4,K5,K6> Rep = default;

        public static readonly ulong Value 
            = Nat.nat<K1>().value * 100000
            + Nat.nat<K2>().value * 10000
            + Nat.nat<K3>().value * 1000
            + Nat.nat<K4>().value * 100
            + Nat.nat<K5>().value * 10
            + Nat.nat<K6>().value;

        public static readonly byte[] Digits 
            = mfunc.digits(Value);
    
        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        byte[] ITypeNat.Digits()
            => Digits;

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// Reifies a seven-term natural sequence
    /// </summary>
    /// <typeparam name="K1">The type of the first term</typeparam>
    /// <typeparam name="K2">The type of the second term</typeparam>
    /// <typeparam name="K3">The type of the third term</typeparam>
    /// <typeparam name="K4">The type of the fourth term</typeparam>
    /// <typeparam name="K5">The type of the fifth term</typeparam>
    /// <typeparam name="K6">The type of the sixth term</typeparam>
    /// <typeparam name="K7">The type of the seventh term</typeparam>
    public readonly struct NatSeq<K1,K2,K3,K4,K5,K6,K7> : NatSeq<NatSeq<K1,K2,K3,K4,K5,K6,K7>>
        where K1 : NatPrimitive<K1>, new()
        where K2 : NatPrimitive<K2>, new()
        where K3 : NatPrimitive<K3>, new()
        where K4 : NatPrimitive<K4>, new()
        where K5 : NatPrimitive<K5>, new()
        where K6 : NatPrimitive<K6>, new()
        where K7 : NatPrimitive<K7>, new()
    {
        public static readonly NatSeq<K1,K2,K3,K4,K5,K6,K7> Rep = default;

        public static readonly ulong Value 
            = Nat.nat<K1>().value * 1000000
            + Nat.nat<K2>().value * 100000
            + Nat.nat<K3>().value * 10000
            + Nat.nat<K4>().value * 1000
            + Nat.nat<K5>().value * 100
            + Nat.nat<K6>().value * 10
            + Nat.nat<K7>().value;

        public static readonly byte[] Digits 
            = mfunc.digits(Value);

        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        byte[] ITypeNat.Digits()
            => Digits;

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// Reifies an eight-term natural sequence
    /// </summary>
    /// <typeparam name="K1">The type of the first term</typeparam>
    /// <typeparam name="K2">The type of the second term</typeparam>
    /// <typeparam name="K3">The type of the third term</typeparam>
    /// <typeparam name="K4">The type of the fourth term</typeparam>
    /// <typeparam name="K5">The type of the fifth term</typeparam>
    /// <typeparam name="K6">The type of the sixth term</typeparam>
    /// <typeparam name="K7">The type of the seventh term</typeparam>
    /// <typeparam name="K8">The type of the eight term</typeparam>
    public readonly struct NatSeq<K1,K2,K3,K4,K5,K6,K7,K8> : NatSeq<NatSeq<K1,K2,K3,K4,K5,K6,K7,K8>>
        where K1 : NatPrimitive<K1>, new()
        where K2 : NatPrimitive<K2>, new()
        where K3 : NatPrimitive<K3>, new()
        where K4 : NatPrimitive<K4>, new()
        where K5 : NatPrimitive<K5>, new()
        where K6 : NatPrimitive<K6>, new()
        where K7 : NatPrimitive<K7>, new()
        where K8 : NatPrimitive<K8>, new()
    {
        public static readonly NatSeq<K1,K2,K3,K4,K5,K6,K7,K8> Rep = default;

        public static readonly ulong Value 
            = Nat.nat<K1>().value * 10000000
            + Nat.nat<K2>().value * 1000000
            + Nat.nat<K3>().value * 100000
            + Nat.nat<K4>().value * 10000
            + Nat.nat<K5>().value * 1000
            + Nat.nat<K6>().value * 100
            + Nat.nat<K7>().value * 10
            + Nat.nat<K8>().value;

        public static readonly byte[] Digits 
            = mfunc.digits(Value);

        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        byte[] ITypeNat.Digits()
            => Digits;

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    } 

   /// <summary>
    /// Reifies an nine-term natural sequence
    /// </summary>
    /// <typeparam name="K1">The type of the first term</typeparam>
    /// <typeparam name="K2">The type of the second term</typeparam>
    /// <typeparam name="K3">The type of the third term</typeparam>
    /// <typeparam name="K4">The type of the fourth term</typeparam>
    /// <typeparam name="K5">The type of the fifth term</typeparam>
    /// <typeparam name="K6">The type of the sixth term</typeparam>
    /// <typeparam name="K7">The type of the seventh term</typeparam>
    /// <typeparam name="K8">The type of the eight term</typeparam>
    /// <typeparam name="K9">The type of the ningth term</typeparam>
    public readonly struct NatSeq<K1,K2,K3,K4,K5,K6,K7,K8,K9> : NatSeq<NatSeq<K1,K2,K3,K4,K5,K6,K7,K8,K9>>
        where K1 : NatPrimitive<K1>, new()
        where K2 : NatPrimitive<K2>, new()
        where K3 : NatPrimitive<K3>, new()
        where K4 : NatPrimitive<K4>, new()
        where K5 : NatPrimitive<K5>, new()
        where K6 : NatPrimitive<K6>, new()
        where K7 : NatPrimitive<K7>, new()
        where K8 : NatPrimitive<K8>, new()
        where K9 : NatPrimitive<K9>, new()
    {
        public static readonly NatSeq<K1,K2,K3,K4,K5,K6,K7,K8,K9> Rep = default;

        public static readonly ulong Value 
            = Nat.nat<K1>().value * 100000000
            + Nat.nat<K2>().value * 10000000
            + Nat.nat<K3>().value * 1000000
            + Nat.nat<K4>().value * 100000
            + Nat.nat<K5>().value * 10000
            + Nat.nat<K6>().value * 1000
            + Nat.nat<K7>().value * 100
            + Nat.nat<K8>().value * 10
            + Nat.nat<K9>().value; 

        public static readonly byte[] Digits 
            = mfunc.digits(Value);

        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        byte[] ITypeNat.Digits()
            => Digits;

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }     
}