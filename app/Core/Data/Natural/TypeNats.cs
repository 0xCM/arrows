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
    /// Reifies nat primitives and common derivations thereof,
    /// provides an indexed source-of-truth for these reifications,
    /// and exposes the means by which additional reifications
    /// can be constructed
    /// </summary>
    public static class TypeNats
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
        public static NatSeq<N8,N1,N9,N2> N8192 = natseq<N8,N1,N9,N2>();
        
        /// <summary>
        /// Specifies the type literal for the natural number 2^14 = 16384
        /// </summary>
        public static NatSeq<N1,N6,N3,N8,N4> N16384 = natseq<N1,N6,N3,N8,N4>();
 
        /// <summary>
        /// Finds the singleton value of a known typenat
        /// </summary>
        /// <typeparam name="T">The nattype type</typeparam>
        /// <returns></returns>
        public static T nat<T>()
            where T : C.TypeNat
            => (T)nats[type<T>()];            

        static readonly ConcurrentDictionary<Type,C.TypeNat> nats
            = new ConcurrentDictionary<Type, C.TypeNat> {};

        static void record(params C.TypeNat[] reified)
            =>  map(reified, nat => nats.TryAdd(nat.GetType(), nat));

        static TypeNats()
        {
            //Primitives
            record(N0, N1, N2, N3, N4, N5, N6, N7, N8, N9);
 
            //Powers of two
            record(N16, N32, N64, N128, N256, N512, N1024);
            record(N2048, N4096,N8192,N16384);
        
        }        

        public static NatSeq<T0> natseq<T0>()
            where T0 : C.TypeNat        
                => (NatSeq<T0>)nats.GetOrAdd(type<T0>(), t => NatSeq<T0>.Inhabitant);

        public static NatSeq<T0,T1> natseq<T0,T1>()
            where T0 : C.TypeNat        
            where T1 : C.TypeNat
                => (NatSeq<T0,T1>)nats.GetOrAdd(type<(T0,T1)>(), 
                    t => NatSeq<T0,T1>.Inhabitant);
    
        public static NatSeq<T0,T1,T2> natseq<T0,T1,T2>()
            where T0 : C.TypeNat        
            where T1 : C.TypeNat
            where T2 : C.TypeNat
                => (NatSeq<T0,T1,T2>)nats.GetOrAdd(type<(T0,T1,T2)>(), 
                    t => NatSeq<T0,T1,T2>.Inhabitant);
        
        public static NatSeq<T0,T1,T2,T3> natseq<T0,T1,T2,T3>()
            where T0 : C.TypeNat        
            where T1 : C.TypeNat
            where T2 : C.TypeNat
            where T3 : C.TypeNat
                => (NatSeq<T0,T1,T2,T3>)nats.GetOrAdd(type<(T0,T1,T2,T3)>(), 
                    t => NatSeq<T0,T1,T2,T3>.Inhabitant);

        public static NatSeq<T0,T1,T2,T3,T4> natseq<T0,T1,T2,T3,T4>()
            where T0 : C.TypeNat        
            where T1 : C.TypeNat
            where T2 : C.TypeNat
            where T3 : C.TypeNat
            where T4 : C.TypeNat
                => (NatSeq<T0,T1,T2,T3,T4>) nats.GetOrAdd(type<(T0,T1,T2,T3,T4)>(), 
                        t => NatSeq<T0,T1,T2,T3,T4>.Inhabitant);

        public static NatSeq<T0,T1,T2,T3,T4,T5> natseq<T0,T1,T2,T3,T4,T5>()
            where T0 : C.TypeNat        
            where T1 : C.TypeNat
            where T2 : C.TypeNat
            where T3 : C.TypeNat
            where T4 : C.TypeNat
            where T5 : C.TypeNat
                => (NatSeq<T0,T1,T2,T3,T4,T5>) nats.GetOrAdd(type<(T0,T1,T2,T3,T4,T5)>(), 
                        t => NatSeq<T0,T1,T2,T3,T4,T5>.Inhabitant);

    }

}