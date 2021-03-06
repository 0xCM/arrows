//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;

    using static nfunc;
    using static constant;

    /// <summary>
    /// Constructs natural number prepresentatives and calculates related values
    /// </summary>
    public static class Nat
    {        
        const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline)]   
        static Type primtype(byte value)
            => (value switch {                    
                    1 => N1.Rep as ITypeNat, 
                    2 => N2.Rep, 
                    3 => N3.Rep,
                    4 => N4.Rep, 
                    5 => N5.Rep, 
                    6 => N6.Rep, 
                    7 => N7.Rep,
                    8 => N8.Rep,
                    9 => N9.Rep, 
                    _ => N0.Rep
                    }).GetType();


        [MethodImpl(Inline)]   
        static Type typedef(Type t)
            => t.GetGenericTypeDefinition();

        [MethodImpl(Inline)]   
        static Type seqtype(uint args)
            => typedef(args switch {
                1 => typeof(NatSeq1<>), 
                2 => typeof(NatSeq<,>), 
                3 => typeof(NatSeq<,,>),
                4 => typeof(NatSeq<,,,>), 
                5 => typeof(NatSeq<,,,,>), 
                6 => typeof(NatSeq<,,,,,>), 
                7 => typeof(NatSeq<,,,,,,>), 
                8 => typeof(NatSeq<,,,,,,,>), 
                9 => typeof(NatSeq<,,,,,,,,>), 
                _ => throw new NotSupportedException()
                });

        [MethodImpl(Inline)]       
        static Type[] types(byte[] digits)
            => digits.Select(primtype).ToArray();

        /// <summary>
        /// Constructs the natural type corresponding to an integral value
        /// </summary>
        /// <param name="digits">The source digits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]       
        public static NatSeq reflect(uint value)        
            => reflect(digits(value));

        public static int require<N>(int value)
            where N : ITypeNat, new()
                => nati<N>() == value ? value : throw new Exception();

        /// <summary>
        /// Consstructs the canonical sequence representatives for the natural numbers
        /// within an inclusive range
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        /// <returns></returns>
        public static IEnumerable<NatSeq> reflect(uint min, uint max)
        {
            for(var i = min; i<= max; i++)
                yield return reflect(i);
        }
 
        /// <summary>
        /// Constructs a type natural from a sequence of digits
        /// </summary>
        /// <param name="digits">The source digits</param>
        public static NatSeq reflect(byte[] digits)
        {
            var dtypes = types(digits);
            var nattype = seqtype((uint)dtypes.Length).MakeGenericType(dtypes);
            return  (NatSeq)Activator.CreateInstance(nattype);
        }
        
        /// <summary>
        /// Constructs a natural representative for a specified parametric type
        /// </summary>
        /// <typeparam name="K">The representative type to construct</typeparam>
        [MethodImpl(Inline)]   
        public static K nat<K>()
            where K : ITypeNat,new()
             => new K(); 

        [MethodImpl(Inline)]   
        public static Next<K> next<K>()
                where K : ITypeNat,new()
            => new Next<K>();

        /// <summary>
        /// Recuces the representation to canonical form
        /// </summary>
        /// <typeparam name="S">The source natural</typeparam>
        /// <typeparam name="T">The target natural</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]   
        public static T reduce<S,T>()
            where S : ITypeNat, new()
            where T : ITypeNat, new()
        {                        
            var tval = Nat.nat<T>();
            var sval = Nat.nat<S>();
            NatProve.eq(tval, sval);
            return tval;
        }


        [MethodImpl(Inline)]   
        public static Next<K> next<K>(K nat)
                where K : ITypeNat,new()
            => new Next<K>();

        [MethodImpl(Inline)]   
        public static Prior<K> prior<K>()
                where K : ITypeNat,new()
            => new Prior<K>();


        [MethodImpl(Inline)]   
        public static Prior<K> prior<K>(K nat)
                where K : ITypeNat,new()
            => new Prior<K>();

        /// <summary>
        /// Constructs (k1,k2) where k1:K2 & k2:K2 
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        [MethodImpl(Inline)]   
        public static (ulong k1, ulong k2) pair<K1,K2>()
            where K2 : ITypeNat, new()
            where K1 : ITypeNat, new()
                => (natu<K1>(), natu<K2>());            

        [MethodImpl(Inline)]   
        public static (int k1, int k2) pairi<K1,K2>()
            where K2 : ITypeNat, new()
            where K1 : ITypeNat, new()
                => (nati<K1>(), nati<K2>());            

        /// <summary>
        /// Constructs (k1,k2,k3) where k1:K2 & k2:K2 & k3:K3
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        /// <typeparam name="K3">The thrid type</typeparam>
        [MethodImpl(Inline)]   
        public static (ulong k1, ulong k2, ulong k3) triple<K1,K2,K3>()
            where K2 : ITypeNat, new()
            where K1 : ITypeNat, new()
            where K3 : ITypeNat, new()
                => (natu<K1>(),natu<K2>(), natu<K3>());            

        /// <summary>
        /// Contructs the canonical 1-element natural sequence for a primitive natural
        /// </summary>
        /// <typeparam name="K">A representative type</typeparam>
        [MethodImpl(Inline)]   
        public static NatSeq natseq<K>()
            where K : INatPrimitive<K>,new()
                => new K().seq;

        /// <summary>
        /// Constructs the canonical 2-element natural sequence for the 2-digit natural number k such that
        /// {k1:K1, k2:K2} => k = k1*10 + k2
        /// </summary>
        /// <typeparam name="K1">The first nat type, corresponding the first digit of the associated value</typeparam>
        /// <typeparam name="K2">The second nat type, corresponding the second digit of the associated value</typeparam>
        [MethodImpl(Inline)]   
        public static NatSeq<K1,K2> seq<K1,K2>()
            where K1 : INatPrimitive<K1>, new()        
            where K2 : INatPrimitive<K2>, new()
                => NatSeq<K1,K2>.Rep;

        /// <summary>
        /// Constructs a nondegenerate interval bounded by natural types
        /// </summary>
        /// <typeparam name="K1">The type of the left endpoint</typeparam>
        /// <typeparam name="K2">The type of the right endpoint</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]   
        public static NatInterval<K1,K2> interval<K1,K2>()
            where K1 : ITypeNat, INatLt<K1,K2>, new()
            where K2 : ITypeNat, new()
                => new NatInterval<K1,K2>(natrep<K1>(), natrep<K2>());

        /// <summary>
        /// Constructs a natural representative that encodes the sum of two naturals
        /// </summary>
        /// <typeparam name="K1">The first operand type</typeparam>
        /// <typeparam name="K2">The second operand type</typeparam>
        [MethodImpl(Inline)]   
        public static NatSum<K1,K2> add<K1,K2>()
            where K1 : ITypeNat, new()        
            where K2 : ITypeNat, new()
                => NatSum<K1,K2>.Rep;

        /// <summary>
        /// Constructs a natural representative that encodes the sum of two naturals
        /// </summary>
        /// <typeparam name="K1">The first operand type</typeparam>
        /// <typeparam name="K2">The second operand type</typeparam>
        [MethodImpl(Inline)]   
        public static NatSum<K1,K2> add<K1,K2>(K1 k1, K2 k2)
            where K1 : ITypeNat, new()        
            where K2 : ITypeNat, new()
                => NatSum<K1,K2>.Rep;

        /// <summary>
        /// Constructs a natural representative that encodes the product of two naturals
        /// </summary>
        /// <typeparam name="K1">The first operand type</typeparam>
        /// <typeparam name="K2">The second operand type</typeparam>
        [MethodImpl(Inline)]   
        public static Product<K1,K2> mul<K1,K2>()
            where K1 : ITypeNat, new()        
            where K2 : ITypeNat, new()
                => Product<K1,K2>.Rep;

        /// <summary>
        /// Constructs a natural representative that encodes a natural base raised to a
        /// natural power
        /// </summary>
        /// <typeparam name="B">The base type</typeparam>
        /// <typeparam name="E">The exponent type</typeparam>
        [MethodImpl(Inline)]   
        public static Pow<B,E> pow<B,E>()
            where B : ITypeNat, new()        
            where E : ITypeNat, new()
                => Pow<B,E>.Rep;

        /// <summary>
        /// Constructs a natural representative that encodes a natural prime base raised to a
        /// natural power
        /// </summary>
        /// <typeparam name="P">The prime base type</typeparam>
        /// <typeparam name="E">The exponent type</typeparam>
        [MethodImpl(Inline)]   
        public static PrimePow<P,E> primepow<P,E>()
            where P : ITypeNat, INatPrime<P>, new()        
            where E : ITypeNat, new()
                => PrimePow<P,E>.Rep;

        /// <summary>
        /// Constructs the natural dimension (k1,k2) where k1:K1 & k2:K2 
        /// </summary>
        /// <typeparam name="K1">The first dimensional factor</typeparam>
        /// <typeparam name="K2">The second dimensional factor</typeparam>
        [MethodImpl(Inline)]   
        public static Dim<K1,K2> dim<K1,K2>()
            where K1 : ITypeNat, new()        
            where K2 : ITypeNat, new()
                => Dim<K1,K2>.Rep;

        /// <summary>
        /// Constructs the natural dimension (k1,k2) where k1:K1 & k2:K2 
        /// </summary>
        /// <typeparam name="K1">The first dimensional factor</typeparam>
        /// <typeparam name="K2">The second dimensional factor</typeparam>
        [MethodImpl(Inline)]   
        public static Dim<K1,K2> dim<K1,K2>(K1 k1, K2 k2)
            where K1 : ITypeNat, new()        
            where K2 : ITypeNat, new()
                => Dim<K1,K2>.Rep;

        /// <summary>
        /// Constructs the natural dimension (k1,k2,k3) where k1:K1 & k2:K2 & k3:K3
        /// </summary>
        /// <typeparam name="K1">The first dimensional factor</typeparam>
        /// <typeparam name="K2">The second dimensional factor</typeparam>
        /// <typeparam name="K3">The third dimensional factor</typeparam>
        [MethodImpl(Inline)]   
        public static Dim<K1,K2,K3> dim<K1,K2,K3>()
            where K1 : ITypeNat, new()        
            where K2 : ITypeNat, new()
            where K3 : ITypeNat, new()
                => Dim<K1,K2,K3>.Rep;

        /// <summary>
        /// Constructs the canonical 3-element natural sequence for the 3-digit natural number k such that
        /// {k1:K1, k2:K2, k3:K3} => k = k1*10^2 + k2*10^1 + k3
        /// </summary>
        /// <typeparam name="K1">The first nat type, corresponding the first digit of the associated value</typeparam>
        /// <typeparam name="K2">The second nat type, corresponding the second digit of the associated value</typeparam>
        /// <typeparam name="K3">The third nat type, corresponding the third digit of the associated value</typeparam>
        [MethodImpl(Inline)]   
        public static NatSeq<K1,K2,K3> seq<K1,K2,K3>()
            where K1 : INatPrimitive<K1>, new()        
            where K2 : INatPrimitive<K2>, new()
            where K3 : INatPrimitive<K3>, new()
                => NatSeq<K1,K2,K3>.Rep;
        
        /// <summary>
        /// Constructs the canonical 4-element natural sequence for the 4-digit natural number k such that
        /// {k1:K1, ..., k4:K4} => k = k1*10^3 + k2*10^2 + k3*10 + K4
        /// </summary>
        /// <typeparam name="K1">The first nat type, corresponding the first digit of the associated value</typeparam>
        /// <typeparam name="K2">The second nat type, corresponding the second digit of the associated value</typeparam>
        /// <typeparam name="K3">The third nat type, corresponding the third digit of the associated value</typeparam>
        /// <typeparam name="K4">The fourth nat type, corresponding the fourth digit of the associated value</typeparam>
        [MethodImpl(Inline)]   
        public static NatSeq<K1,K2,K3,K4> seq<K1,K2,K3,K4>()
            where K1 : INatPrimitive<K1>, new()        
            where K2 : INatPrimitive<K2>, new()
            where K3 : INatPrimitive<K3>, new()
            where K4 : INatPrimitive<K4>, new()
                => default;

        /// <summary>
        /// Constructs the canonical 5-element natural sequence for the 5-digit natural number k such that
        /// {k1:K1 ... k5:K5} => k = k1*10^4 + k2*10^3 + k3*10^2 + K4*10 + k5
        /// </summary>
        /// <typeparam name="K1">The first nat type, corresponding the first digit of the associated value</typeparam>
        /// <typeparam name="K2">The second nat type, corresponding the second digit of the associated value</typeparam>
        /// <typeparam name="K3">The third nat type, corresponding the third digit of the associated value</typeparam>
        /// <typeparam name="K4">The fourth nat type, corresponding the fourth digit of the associated value</typeparam>
        /// <typeparam name="K5">The fifth nat type, corresponding the fifth digit of the associated value</typeparam>
        [MethodImpl(Inline)]   
        public static NatSeq<K1,K2,K3,K4,K5> seq<K1,K2,K3,K4,K5>()
            where K1 : INatPrimitive<K1>, new()        
            where K2 : INatPrimitive<K2>, new()
            where K3 : INatPrimitive<K3>, new()
            where K4 : INatPrimitive<K4>, new()
            where K5 : INatPrimitive<K5>, new()
                => default;

        /// <summary>
        /// Constructs the canonical 6-element natural sequence for the 6-digit natural number k such that
        /// {k1:K1, ..., k6:K6} => k = k1*10^5 + k2*10^4 + k3*10^3 + K4*10^2 + k5*10 + k6
        /// </summary>
        /// <typeparam name="K1">The first nat type, corresponding the first digit of the associated value</typeparam>
        /// <typeparam name="K2">The second nat type, corresponding the second digit of the associated value</typeparam>
        /// <typeparam name="K3">The third nat type, corresponding the third digit of the associated value</typeparam>
        /// <typeparam name="K4">The fourth nat type, corresponding the fourth digit of the associated value</typeparam>
        /// <typeparam name="K5">The fifth nat type, corresponding the fifth digit of the associated value</typeparam>
        /// <typeparam name="K6">The sixth nat type, corresponding the sixth digit of the associated value</typeparam>
        [MethodImpl(Inline)]   
        public static NatSeq<K1,K2,K3,K4,K5,K6> seq<K1,K2,K3,K4,K5,K6>()
            where K1 : INatPrimitive<K1>, new()        
            where K2 : INatPrimitive<K2>, new()
            where K3 : INatPrimitive<K3>, new()
            where K4 : INatPrimitive<K4>, new()
            where K5 : INatPrimitive<K5>, new()
            where K6 : INatPrimitive<K6>, new()
                => default;
   
   
        /// <summary>
        /// Partitions a seequence into segments of a specified natural width
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="W">The width type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<IReadOnlyList<T>> partition<W,T>(IEnumerable<T> src)
            where W : ITypeNat, new()
        {
            var width = natu<W>();
            var sement = new T[width];
            var current = 0UL;
            foreach(var item in src)
            {
                if(current == width)
                {
                    current = 0;
                    yield return sement;
                    sement = new T[width];
                }
                    
                sement[current++] = item;
            }

            for(var i = current; i < width; i++)
                sement[i] = default(T);
            
            yield return sement;
        }

    }
}