namespace Core
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using static corefunc;
    

    /// <summary>
    /// Reifies nat primitives and common derivations thereof,
    /// provides an indexed source-of-truth for these reifications,
    /// and exposes the means by which additional reifications
    /// can be constructed
    /// </summary>
    public static class Nats
    {
        /// <summary>
        /// Specifies the type literal for the first natural number 0
        /// </summary>
        public static readonly N0 N0 = nat<N0>();

        /// <summary>
        /// Specifies the type literal for the natural number 1
        /// </summary>
        public static readonly N1 N1 = nat<N1>();

        /// <summary>
        /// Specifies the type literal for the natural number 2
        /// </summary>
        public static readonly N2 N2 = nat<N2>();

        /// <summary>
        /// Specifies the type literal for the natural number 3
        /// </summary>
        public static readonly N3 N3 = nat<N3>();
        
        /// <summary>
        /// Specifies the type literal for the natural number 4
        /// </summary>
        public static readonly N4 N4 = nat<N4>();
        
        /// <summary>
        /// Specifies the type literal for the natural number 5
        /// </summary>
        public static readonly N5 N5 = nat<N5>();
        
        /// <summary>
        /// Specifies the type literal for the natural number 6
        /// </summary>        
        public static readonly N6 N6 = nat<N6>();

        /// <summary>
        /// Specifies the type literal for the natural number 7
        /// </summary>
        public static readonly N7 N7 = nat<N7>();

        /// <summary>
        /// Specifies the type literal for the natural number 8
        /// </summary>
        public static readonly N8 N8 = nat<N8>();

        /// <summary>
        /// Specifies the type literal for the natural number 9
        /// </summary>
        public static readonly N9 N9 = nat<N9>();
        
        /// <summary>
        /// Specifies the type literal for the natural number 16
        /// </summary>
        public static readonly NatSeq<N1,N6> N16 = nat<N1,N6>();

        /// <summary>
        /// Specifies the type literal for the natural number 32
        /// </summary>
        public static readonly NatSeq<N3,N2> N32 = nat<N3,N2>();

        /// <summary>
        /// Specifies the type literal for the natural number 64
        /// </summary>
        public static readonly NatSeq<N6,N4> N64 = nat<N6,N4>();

        /// <summary>
        /// Specifies the type literal for the natural number 2*7 = 128
        /// </summary>
        public static readonly NatSeq<N2,N5,N6> N128 = nat<N2,N5,N6>();

        /// <summary>
        /// Specifies the type literal for the natural number 2^8 = 256
        /// </summary>
        public static readonly NatSeq<N2,N5,N6> N256 = nat<N2,N5,N6>();

        /// <summary>
        /// Specifies the type literal for the natural number 2^9 = 512
        /// </summary>
        public static readonly NatSeq<N5,N1,N2> N512 = nat<N5,N1,N2>();

        /// <summary>
        /// Specifies the type literal for the natural number 2^10 = 1024
        /// </summary>
        public static readonly NatSeq<N1,N0,N2,N4> N1024 = nat<N1,N0,N2,N4>();

        /// <summary>
        /// Specifies the type literal for the natural number 2^11 = 2058
        /// </summary>
        public static readonly NatSeq<N2,N4,N0,N8> N2048 = nat<N2,N4,N0,N8>();

        /// <summary>
        /// Specifies the type literal for the natural number 2^12 = 4096
        /// </summary>
        public static readonly NatSeq<N4,N0,N2,N6> N4096 = nat<N4,N0,N2,N6>();

        

        public static T nat<T>()
            where T : TypeNat,new()
             => new T(); 
                    
        public static NatSeq<T0,T1> nat<T0,T1>()
            where T0 : TypeNat, new()        
            where T1 : TypeNat, new()
                => NatSeq<T0,T1>.Rep;

        public static NatSeq<T0,T1,T2> nat<T0,T1,T2>()
            where T0 : TypeNat, new()        
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
                => NatSeq<T0,T1,T2>.Rep;
        
        public static NatSeq<T0,T1,T2,T3> nat<T0,T1,T2,T3>()
            where T0 : TypeNat, new()        
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
                => NatSeq<T0,T1,T2,T3>.Rep;

        public static NatSeq<T0,T1,T2,T3,T4> nat<T0,T1,T2,T3,T4>()
            where T0 : TypeNat, new()        
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
                => NatSeq<T0,T1,T2,T3,T4>.Rep;

        public static NatSeq<T0,T1,T2,T3,T4,T5> nat<T0,T1,T2,T3,T4,T5>()
            where T0 : TypeNat, new()        
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
            where T5 : TypeNat, new()
                => NatSeq<T0,T1,T2,T3,T4,T5>.Rep;

    }

}