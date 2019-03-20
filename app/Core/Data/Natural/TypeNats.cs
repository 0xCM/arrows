namespace Core
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using static corefunc;
    using static Reify;

    /// <summary>
    /// Reifies nat primitives and common derivations thereof,
    /// provides an indexed source-of-truth for these reifications,
    /// and exposes the means by which additional reifications
    /// can be constructed
    /// </summary>
    public static class TypeNats
    {
         static readonly ConcurrentDictionary<Type,TypeNat> nats
            = new ConcurrentDictionary<Type, TypeNat>();

        /// <summary>
        /// Specifies the type literal for the first natural number 0
        /// </summary>
        public static readonly N0 N0 = record(N0.Inhabitant);

        /// <summary>
        /// Specifies the type literal for the natural number 1
        /// </summary>
        public static readonly N1 N1 = record(N1.Inhabitant);

        /// <summary>
        /// Specifies the type literal for the natural number 2
        /// </summary>
        public static readonly N2 N2 = record(N2.Inhabitant);

        /// <summary>
        /// Specifies the type literal for the natural number 3
        /// </summary>
        public static readonly N3 N3 = record(N3.Inhabitant);
        
        /// <summary>
        /// Specifies the type literal for the natural number 4
        /// </summary>
        public static readonly N4 N4 = record(N4.Inhabitant);
        
        /// <summary>
        /// Specifies the type literal for the natural number 5
        /// </summary>
        public static readonly N5 N5 = record(N5.Inhabitant);
        
        /// <summary>
        /// Specifies the type literal for the natural number 6
        /// </summary>        
        public static readonly N6 N6 = record(N6.Inhabitant);

        /// <summary>
        /// Specifies the type literal for the natural number 7
        /// </summary>
        public static readonly N7 N7 = record(N7.Inhabitant);

        /// <summary>
        /// Specifies the type literal for the natural number 8
        /// </summary>
        public static readonly N8 N8 = record(N8.Inhabitant);

        /// <summary>
        /// Specifies the type literal for the natural number 9
        /// </summary>
        public static readonly N9 N9 = record(N9.Inhabitant);
        
 
        static TypeNats()
        {
            
        }        
        
        static T record<T>(T inhabitant) 
            where T : TypeNat
        {
            nats.TryAdd(type<T>(), inhabitant);
            return inhabitant;
        }

        /// <summary>
        /// Finds the singleton value of a known typenat
        /// </summary>
        /// <typeparam name="T">The nattype type</typeparam>
        /// <returns></returns>
        public static T nat<T>()
            where T : TypeNat
            => (T)nats[type<T>()];            

        public static nseq<T0> natseq<T0>()
            where T0 : TypeNat        
                => (nseq<T0>)nats.GetOrAdd(type<T0>(), t => nseq<T0>.Inhabitant);

        public static nseq<T0,T1> natseq<T0,T1>()
            where T0 : TypeNat        
            where T1 : TypeNat
                => (nseq<T0,T1>)nats.GetOrAdd(type<nseq<T0,T1>>(), 
                    t => nseq<T0,T1>.Inhabitant);
    
        public static nseq<T0,T1,T2> natseq<T0,T1,T2>()
            where T0 : TypeNat        
            where T1 : TypeNat
            where T2 : TypeNat
                => (nseq<T0,T1,T2>)nats.GetOrAdd(type<nseq<T0,T1,T2>>(), 
                    t => nseq<T0,T1,T2>.Inhabitant);
        
        public static nseq<T0,T1,T2,T3> natseq<T0,T1,T2,T3>()
            where T0 : TypeNat        
            where T1 : TypeNat
            where T2 : TypeNat
            where T3 : TypeNat
                => (nseq<T0,T1,T2,T3>)nats.GetOrAdd(type<nseq<T0,T1,T2,T3>>(), 
                    t => nseq<T0,T1,T2,T3>.Inhabitant);

 
 
        /// <summary>
        /// Specifies the type literal for the natural number 16
        /// </summary>
        public static readonly nseq<N1,N6> N16 = natseq<N1,N6>();

        /// <summary>
        /// Specifies the type literal for the natural number 32
        /// </summary>
        public static readonly nseq<N3,N2> N32 = natseq<N3,N2>();

        /// <summary>
        /// Specifies the type literal for the natural number 64
        /// </summary>
        public static readonly nseq<N6,N4> N64 = natseq<N6,N4>();

        /// <summary>
        /// Specifies the type literal for the natural number 2*7 = 128
        /// </summary>
        public static readonly nseq<N1,N2,N8> N128 = natseq<N1,N2,N8>();

        /// <summary>
        /// Specifies the type literal for the natural number 2^8 = 256
        /// </summary>
        public static readonly nseq<N2,N5,N6> N256 = natseq<N2,N5,N6>();

        /// <summary>
        /// Specifies the type literal for the natural number 2^9 = 512
        /// </summary>
        public static readonly nseq<N5,N1,N2> N512 = natseq<N5,N1,N2>();

        /// <summary>
        /// Specifies the type literal for the natural number 2^10 = 1024
        /// </summary>
        public static readonly nseq<N1,N0,N2,N4> N1024 = natseq<N1,N0,N2,N4>();

        /// <summary>
        /// Specifies the type literal for the natural number 2^11 = 2058
        /// </summary>
        public static readonly nseq<N2,N4,N0,N8> N2048 = natseq<N2,N4,N0,N8>();

        /// <summary>
        /// Specifies the type literal for the natural number 2^12 = 4096
        /// </summary>
        public static readonly nseq<N4,N0,N2,N6> N4096 = natseq<N4,N0,N2,N6>();
 
    }

}