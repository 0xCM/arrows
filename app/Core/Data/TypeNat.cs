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
    using static TypeNats;

    public static class NatValues
    {
        /// <summary>
        /// Specifies the type literal for the first natural number 0
        /// </summary>
        public static N0 N0 = nat<N0>();

        /// <summary>
        /// Specifies the type literal for the natural number 1
        /// </summary>
        public static N1 N1 = nat<N1>();

        /// <summary>
        /// Specifies the type literal for the natural number 2
        /// </summary>
        public static N2 N2 = nat<N2>();

        /// <summary>
        /// Specifies the type literal for the natural number 3
        /// </summary>
        public static N3 N3 = nat<N3>();
        
        /// <summary>
        /// Specifies the type literal for the natural number 4
        /// </summary>
        public static N4 N4 = nat<N4>();
        
        /// <summary>
        /// Specifies the type literal for the natural number 5
        /// </summary>
        public static N5 N5 = nat<N5>();
        
        /// <summary>
        /// Specifies the type literal for the natural number 6
        /// </summary>        
        public static N6 N6 = nat<N6>();

        /// <summary>
        /// Specifies the type literal for the natural number 7
        /// </summary>
        public static N7 N7 = nat<N7>();

        /// <summary>
        /// Specifies the type literal for the natural number 8
        /// </summary>
        public static N8 N8 = nat<N8>();

        /// <summary>
        /// Specifies the type literal for the natural number 9
        /// </summary>
        public static N9 N9 = nat<N9>();
        
        /// <summary>
        /// Specifies the type literal for the natural number 16
        /// </summary>
        public static NatSeq<N1,N6> N16 = natseq<N1,N6>();

        /// <summary>
        /// Specifies the type literal for the natural number 32
        /// </summary>
        public static NatSeq<N3,N2> N32 = natseq<N3,N2>();

        /// <summary>
        /// Specifies the type literal for the natural number 64
        /// </summary>
        public static NatSeq<N6,N4> N64 = natseq<N6,N4>();

        /// <summary>
        /// Specifies the type literal for the natural number 2*7 = 128
        /// </summary>
        public static NatSeq<N1,N2,N8> N128 = natseq<N1,N2,N8>();

        /// <summary>
        /// Specifies the type literal for the natural number 2^8 = 256
        /// </summary>
        public static NatSeq<N2,N5,N6> N256 = natseq<N2,N5,N6>();

        /// <summary>
        /// Specifies the type literal for the natural number 2^9 = 512
        /// </summary>
        public static NatSeq<N5,N1,N2> N512 = natseq<N5,N1,N2>();

        /// <summary>
        /// Specifies the type literal for the natural number 2^10 = 1024
        /// </summary>
        public static NatSeq<N1,N0,N2,N4> N1024 = natseq<N1,N0,N2,N4>();

        /// <summary>
        /// Specifies the type literal for the natural number 2^11 = 2058
        /// </summary>
        public static NatSeq<N2,N4,N0,N8> N2048 = natseq<N2,N4,N0,N8>();

        /// <summary>
        /// Specifies the type literal for the natural number 2^12 = 4096
        /// </summary>
        public static NatSeq<N4,N0,N2,N6> N4096 = natseq<N4,N0,N2,N6>();

        /// <summary>
        /// Specifies the type literal for the natural number 2^13 = 8192
        /// </summary>
        public static NatSeq<N8,N1,N9,N2> N48192 = natseq<N8,N1,N9,N2>();
        
        /// <summary>
        /// Specifies the type literal for the natural number 2^14 = 16384
        /// </summary>
        public static NatSeq<N1,N6,N3,N8,N4> N16384 = natseq<N1,N6,N3,N8,N4>();
    }

    public static class TypeNats
    {
        static readonly Dictionary<Type,C.TypeNat> natix 
            = new Dictionary<Type, C.TypeNat> {
                [type<N0>()] = N0.Inhabitant,
                [type<N1>()] = N1.Inhabitant,
                [type<N2>()] = N2.Inhabitant,
                [type<N3>()] = N3.Inhabitant,
                [type<N4>()] = N4.Inhabitant,
                [type<N5>()] = N5.Inhabitant,
                [type<N6>()] = N6.Inhabitant,
                [type<N7>()] = N7.Inhabitant,
                [type<N8>()] = N8.Inhabitant,
                [type<N9>()] = N9.Inhabitant,
            };

        static readonly ConcurrentDictionary<Type,C.NatSeq> seqix
            = new ConcurrentDictionary<Type, C.NatSeq> {};
        
        public static NatSeq<T0> natseq<T0>()
            where T0 : C.TypeNat        
                => (NatSeq<T0>)seqix.GetOrAdd(type<T0>(), t => NatSeq<T0>.Inhabitant);

        public static NatSeq<T0,T1> natseq<T0,T1>()
            where T0 : C.TypeNat        
            where T1 : C.TypeNat
                => (NatSeq<T0,T1>)seqix.GetOrAdd(type<(T0,T1)>(), 
                    t => NatSeq<T0,T1>.Inhabitant);
    
        public static NatSeq<T0,T1,T2> natseq<T0,T1,T2>()
            where T0 : C.TypeNat        
            where T1 : C.TypeNat
            where T2 : C.TypeNat
                => (NatSeq<T0,T1,T2>)seqix.GetOrAdd(type<(T0,T1,T2)>(), 
                    t => NatSeq<T0,T1,T2>.Inhabitant);
        
        public static NatSeq<T0,T1,T2,T3> natseq<T0,T1,T2,T3>()
            where T0 : C.TypeNat        
            where T1 : C.TypeNat
            where T2 : C.TypeNat
            where T3 : C.TypeNat
                => (NatSeq<T0,T1,T2,T3>)seqix.GetOrAdd(type<(T0,T1,T2,T3)>(), 
                    t => NatSeq<T0,T1,T2,T3>.Inhabitant);

        public static NatSeq<T0,T1,T2,T3,T4> natseq<T0,T1,T2,T3,T4>()
            where T0 : C.TypeNat        
            where T1 : C.TypeNat
            where T2 : C.TypeNat
            where T3 : C.TypeNat
            where T4 : C.TypeNat
                => (NatSeq<T0,T1,T2,T3,T4>) seqix.GetOrAdd(type<(T0,T1,T2,T3,T4)>(), 
                        t => NatSeq<T0,T1,T2,T3,T4>.Inhabitant);

        public static NatSeq<T0,T1,T2,T3,T4,T5> natseq<T0,T1,T2,T3,T4,T5>()
            where T0 : C.TypeNat        
            where T1 : C.TypeNat
            where T2 : C.TypeNat
            where T3 : C.TypeNat
            where T4 : C.TypeNat
            where T5 : C.TypeNat
                => (NatSeq<T0,T1,T2,T3,T4,T5>) seqix.GetOrAdd(type<(T0,T1,T2,T3,T4,T5)>(), 
                        t => NatSeq<T0,T1,T2,T3,T4,T5>.Inhabitant);

        public static T nat<T>()
            => (T)natix[type<T>()];            
    }

    public readonly struct N0 : C.TypeNat<N0,N1>
    {
        public static readonly N0 Inhabitant = new N0(0);
        public int natval {get;}
        public N1 next => N1.Inhabitant;
        N0(int natval)
            => this.natval = natval;        
    }

    public readonly struct N1 : C.TypeNat<N1,N2>
    {
        public static readonly N1 Inhabitant = new N1(1);        
        public int natval {get;}    
        public N2 next => N2.Inhabitant;
        N1(int natval)
            => this.natval = natval;        
        public override string ToString() => natval.ToString();    
    }

    public readonly struct N2 : C.TypeNat<N2,N3>
    {
        public static readonly N2 Inhabitant = new N2(2);        
        public int natval {get;}    
        public N3 next => N3.Inhabitant;
        N2(int natval)
            => this.natval = natval;        
        public override string ToString() => natval.ToString();    
    }

    public readonly struct N3 : C.TypeNat<N3,N4>
    {
        public static readonly N3 Inhabitant = new N3(3);        
        public int natval {get;}    
        public N4 next => N4.Inhabitant;
        N3(int natval)
            => this.natval = natval;        
        public override string ToString() => natval.ToString();    
    }

    public readonly struct N4 : C.TypeNat<N4,N5>
    {
        public static readonly N4 Inhabitant = new N4(4);        
        public int natval {get;}    
        public N5 next => N5.Inhabitant;
        N4(int natval)
            => this.natval = natval;        
        public override string ToString() => natval.ToString();    
    }

    public readonly struct N5 : C.TypeNat<N5,N6>
    {
        public static readonly N5 Inhabitant = new N5(5);        
        public int natval {get;}
        public N6 next => N6.Inhabitant;
        N5(int natval)
            => this.natval = natval;        
        public override string ToString() => natval.ToString();    
    }

    public readonly struct N6 : C.TypeNat<N6,N7>
    {
        public static readonly N6 Inhabitant = new N6(6);        
        public int natval {get;}    
        public N7 next => N7.Inhabitant;
        N6(int natval)
            => this.natval = natval;        
        public override string ToString() => natval.ToString();    
    }

    public readonly struct N7 : C.TypeNat<N7,N8>
    {
        public static readonly N7 Inhabitant = new N7(7);        
        public int natval {get;}    
        public N8 next => N8.Inhabitant;
        N7(int natval)
            => this.natval = natval;        
        public override string ToString() => natval.ToString();
    }

    public readonly struct N8 : C.TypeNat<N8,N9>
    {
        public static readonly N8 Inhabitant = new N8(8);        
        public int natval {get;}    
        public N9 next => N9.Inhabitant;
        N8(int natval)
            => this.natval = natval;        
        public override string ToString() => natval.ToString();    
    }

    public readonly struct N9 : C.TypeNat<N9,N0>
    {
        public static readonly N9 Inhabitant = new N9(9);        
        public int natval {get;}    
        public N0 next => N0.Inhabitant;
        N9(int natval)
            => this.natval = natval;      

        public override string ToString() => natval.ToString();    
    }

    /// <summary>
    /// A nat sequence of length 1
    /// </summary>
    public readonly struct NatSeq<T0> : C.NatSeq
        where T0 : C.TypeNat
    {
        public static readonly NatSeq<T0> Inhabitant = default(NatSeq<T0>);

        static readonly int SeqVal 
            = TypeNats.nat<T0>().natval;
        public int natval => SeqVal;
        
        public override string ToString() 
            => SeqVal.ToString();    
    }

    /// <summary>
    /// A nat sequence of length 2
    /// </summary>
    public readonly struct NatSeq<T0,T1>  : C.NatSeq
        where T0 : C.TypeNat
        where T1 : C.TypeNat
    {
        public static readonly NatSeq<T0,T1> Inhabitant = default(NatSeq<T0,T1>);

        static readonly int SeqVal 
            = TypeNats.nat<T0>().natval * 10
             + TypeNats.nat<T1>().natval;
        public int natval => SeqVal;


        public override string ToString() 
            => SeqVal.ToString();            
    }

    /// <summary>
    /// A nat sequence of length 3
    /// </summary>
    public readonly struct NatSeq<T0,T1,T2>  : C.NatSeq
        where T0 : C.TypeNat
        where T1 : C.TypeNat
        where T2 : C.TypeNat
    {
        public static readonly NatSeq<T0,T1,T2> Inhabitant = default(NatSeq<T0,T1,T2>);
        static readonly int SeqVal 
            = TypeNats.nat<T0>().natval * 100
             + TypeNats.nat<T1>().natval * 10
             + TypeNats.nat<T2>().natval;
        
        public int natval => SeqVal;
            
        public override string ToString() 
            => SeqVal.ToString();    

    }

    /// <summary>
   /// A nat sequence of length 4
   /// </summary>
   public readonly struct NatSeq<T0,T1,T2,T3>  : C.NatSeq
        where T0 : C.TypeNat
        where T1 : C.TypeNat
        where T2 : C.TypeNat
        where T3 : C.TypeNat
    {
        public static readonly NatSeq<T0,T1,T2,T3> Inhabitant = default(NatSeq<T0,T1,T2,T3>);

        static readonly int SeqVal 
            = TypeNats.nat<T0>().natval * 1000
             + TypeNats.nat<T1>().natval * 100
             + TypeNats.nat<T2>().natval * 10
             + TypeNats.nat<T3>().natval;
        
        public int natval => SeqVal;
        
        public override string ToString() 
            => SeqVal.ToString();    
    }

    /// <summary>
   /// A nat sequence of length 5
   /// </summary>
    public readonly struct NatSeq<T0,T1,T2,T3,T4>  : C.NatSeq
        where T0 : C.TypeNat
        where T1 : C.TypeNat
        where T2 : C.TypeNat
        where T3 : C.TypeNat
        where T4 : C.TypeNat
    {
        public static readonly NatSeq<T0,T1,T2,T3,T4> Inhabitant = default(NatSeq<T0,T1,T2,T3,T4>);

        static readonly int SeqVal 
            = TypeNats.nat<T0>().natval * 10000
             + TypeNats.nat<T1>().natval * 1000
             + TypeNats.nat<T2>().natval * 100
             + TypeNats.nat<T3>().natval * 10
             + TypeNats.nat<T4>().natval;
        
        public int natval => SeqVal;
        
        public override string ToString() 
            => SeqVal.ToString();    
    }

    /// <summary>
   /// A nat sequence of length 6
   /// </summary>
    public readonly struct NatSeq<T0,T1,T2,T3,T4,T5>  : C.NatSeq
        where T0 : C.TypeNat
        where T1 : C.TypeNat
        where T2 : C.TypeNat
        where T3 : C.TypeNat
        where T4 : C.TypeNat
        where T5 : C.TypeNat
    {
        public static readonly NatSeq<T0,T1,T2,T3,T4,T5> Inhabitant = default(NatSeq<T0,T1,T2,T3,T4,T5>);

        static readonly int SeqVal 
            = TypeNats.nat<T0>().natval * 100000
             + TypeNats.nat<T1>().natval * 10000
             + TypeNats.nat<T2>().natval * 1000
             + TypeNats.nat<T3>().natval * 100
             + TypeNats.nat<T4>().natval * 10
             + TypeNats.nat<T5>().natval;
        
        public int natval => SeqVal;
        
        public override string ToString() 
            => SeqVal.ToString();    
    }

}