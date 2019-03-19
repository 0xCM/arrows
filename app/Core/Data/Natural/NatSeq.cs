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

    /// <summary>
    /// A nat sequence of length 1
    /// </summary>
    public readonly struct nseq<T0> : C.NatSeq
        where T0 : C.TypeNat
    {
        public static readonly nseq<T0> Inhabitant = default(nseq<T0>);

        static readonly int SeqVal 
            = TypeNats.nat<T0>().natval;
        public int natval => SeqVal;
        
        public override string ToString() 
            => SeqVal.ToString();    
    }

    /// <summary>
    /// A nat sequence of length 2
    /// </summary>
    public readonly struct nseq<T0,T1>  : C.NatSeq
        where T0 : C.TypeNat
        where T1 : C.TypeNat
    {
        public static readonly nseq<T0,T1> Inhabitant = default(nseq<T0,T1>);

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
    public readonly struct nseq<T0,T1,T2>  : C.NatSeq
        where T0 : C.TypeNat
        where T1 : C.TypeNat
        where T2 : C.TypeNat
    {
        public static readonly nseq<T0,T1,T2> Inhabitant = default(nseq<T0,T1,T2>);
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
   public readonly struct nseq<T0,T1,T2,T3>  : C.NatSeq
        where T0 : C.TypeNat
        where T1 : C.TypeNat
        where T2 : C.TypeNat
        where T3 : C.TypeNat
    {
        public static readonly nseq<T0,T1,T2,T3> Inhabitant = default(nseq<T0,T1,T2,T3>);

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
    public readonly struct nseq<T0,T1,T2,T3,T4>  : C.NatSeq
        where T0 : C.TypeNat
        where T1 : C.TypeNat
        where T2 : C.TypeNat
        where T3 : C.TypeNat
        where T4 : C.TypeNat
    {
        public static readonly nseq<T0,T1,T2,T3,T4> Inhabitant = default(nseq<T0,T1,T2,T3,T4>);

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
    public readonly struct nseq<T0,T1,T2,T3,T4,T5>  : C.NatSeq
        where T0 : C.TypeNat
        where T1 : C.TypeNat
        where T2 : C.TypeNat
        where T3 : C.TypeNat
        where T4 : C.TypeNat
        where T5 : C.TypeNat
    {
        public static readonly nseq<T0,T1,T2,T3,T4,T5> Inhabitant = default(nseq<T0,T1,T2,T3,T4,T5>);

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