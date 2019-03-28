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




    /// <summary>
    /// Reifies a one-term natural sequence
    /// </summary>
    /// <typeparam name="T1">The type of the first term</typeparam>
    public readonly struct NatSeq1<T1> 
        : NatSeq<NatSeq1<T1>>
            where T1 : TypeNat, new()
    {
        public static readonly NatSeq1<T1> Rep = default;
        
        public static readonly uint Value 
            = Nat.nat<T1>().value;
        
        public static readonly byte[] Digits 
            = zcore.digits(Value);
        
        public uint value 
            => Value;

        public TypeNat rep
            => this; 

        public NatSeq seq
            => this; 

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
    public readonly struct NatSeq<T1,T2> 
        : NatSeq<NatSeq<T1,T2>>
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
            => this; 

        public NatSeq seq
            => this; 

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
        : NatSeq<NatSeq<T1,T2,T3>>
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
            => this; 

        public NatSeq seq
            => this; 

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
        : NatSeq<NatSeq<T1,T2,T3,T4>>
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
            => this; 

        public NatSeq seq
            => this; 

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
        : NatSeq<NatSeq<T1,T2,T3,T4,T5>>, NatSeq
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
            => this; 

        public NatSeq seq
            => this; 

        public byte[] digits()
            => Digits;

        public override string ToString() 
            => Value.ToString();    
    }

    /// <summary>
    /// A nat sequence of length 6
    /// </summary>
    public readonly struct NatSeq<T1,T2,T3,T4,T5,T6> 
        : NatSeq<NatSeq<T1,T2,T3,T4,T5,T6>>
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
            => this; 

        public NatSeq seq
            => this; 

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
        : NatSeq<NatSeq<T1,T2,T3,T4,T5,T6,T7>>
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
            => this; 

        public NatSeq seq
            => this; 

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
        : NatSeq<NatSeq<T1,T2,T3,T4,T5,T6,T7,T8>>
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
            => this; 

        public NatSeq seq
            => this; 

        public byte[] digits()
            => Digits;

        public override string ToString() 
            => Value.ToString();    
    } 

   /// <summary>
    /// Reifies an nine-term natural sequence
    /// </summary>
    /// <typeparam name="T1">The type of the first term</typeparam>
    /// <typeparam name="T2">The type of the second term</typeparam>
    /// <typeparam name="T3">The type of the third term</typeparam>
    /// <typeparam name="T4">The type of the fourth term</typeparam>
    /// <typeparam name="T5">The type of the fifth term</typeparam>
    /// <typeparam name="T6">The type of the sixth term</typeparam>
    /// <typeparam name="T7">The type of the seventh term</typeparam>
    /// <typeparam name="T8">The type of the eight term</typeparam>
    /// <typeparam name="T9">The type of the ningth term</typeparam>
    public readonly struct NatSeq<T1,T2,T3,T4,T5,T6,T7,T8,T9> 
        : NatSeq<NatSeq<T1,T2,T3,T4,T5,T6,T7,T8,T9>>
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
            where T5 : TypeNat, new()
            where T6 : TypeNat, new()
            where T7 : TypeNat, new()
            where T8 : TypeNat, new()
            where T9 : TypeNat, new()
    {
        public static readonly NatSeq<T1,T2,T3,T4,T5,T6,T7,T8,T9> Rep = default;

        public static readonly uint Value 
            = Nat.nat<T1>().value * 100000000
            + Nat.nat<T2>().value * 10000000
            + Nat.nat<T3>().value * 1000000
            + Nat.nat<T4>().value * 100000
            + Nat.nat<T5>().value * 10000
            + Nat.nat<T6>().value * 1000
            + Nat.nat<T7>().value * 100
            + Nat.nat<T8>().value * 10
            + Nat.nat<T9>().value; 

        public static readonly byte[] Digits 
            = zcore.digits(Value);

        public uint value 
            => Value;

        public TypeNat rep
            => this; 

        public NatSeq seq
            => this; 

        public byte[] digits()
            => Digits;

        public override string ToString() 
            => Value.ToString();    
    }     
}