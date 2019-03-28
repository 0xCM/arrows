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

    using static zcore;
    
    public static class Nat
    {        
        /// <summary>
        /// Registers constraint failure
        /// </summary>
        /// <param name="name">The name of the constraint that failed</param>
        /// <param name="value">The integral value for which the constraint was calculated</param>
        /// <param name="raise"></param>
        /// <typeparam name="K">The type of the natural representative for which the constraint was calculated</typeparam>
        [MethodImpl(Inline)]   
        static bool failure<K>(string name, uint value, bool raise)
            where K : TypeNat, new()
            => raise ? throw new NatConstraintException("eq", value, natval<K>())  : false;

        [MethodImpl(Inline)]   
        static bool failure<M,N>(string name, bool raise)
            where M : TypeNat, new()
            where N : TypeNat, new()
            => raise 
               ? throw new NatConstraintException("successor", pair<M,N>()) 
               : false;

        [MethodImpl(Inline)]   
        static Type primtype(byte value)
            => (value switch {                    
                    1 => N1.Rep as TypeNat, 
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
                _ => nosupport<Type>()}
                );

        [MethodImpl(Inline)]       
        static Type[] types(byte[] digits)
            => map(digits,primtype).ToArray();

        /// <summary>
        /// Constructs the natural type corresponding to an integral value
        /// </summary>
        /// <param name="digits">The source digits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]       
        public static NatSeq reflect(uint value)        
            => reflect(digits(value));

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
            var nattype = seqtype(dtypes.Length()).MakeGenericType(dtypes);
            return instance<NatSeq>(nattype);            
        }
        
        /// <summary>
        /// Constructs a natural representative for a specified parametric type
        /// </summary>
        /// <typeparam name="K">The representative type to construct</typeparam>
        [MethodImpl(Inline)]   
        public static K nat<K>()
            where K : TypeNat,new()
             => new K(); 

        /// <summary>
        /// Retrieves the value of the natural number associated with a typenat
        /// and retuns the value if it agrees with a supplied expected value; othwise,
        /// raises an exception
        /// </summary>
        /// <param name="expected">The expected natural value</param>
        /// <typeparam name="K">The nat type</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]   
        public static uint claim<K>(uint expected)
                where K : TypeNat, new()
            => natval<K>() == expected  ? expected 
                : throw new ArgumentException(); 

        /// <summary>
        /// Retrieves the value of the natural number associated with a typenat
        /// and retuns the value if it agrees with a supplied expected value; othwise,
        /// raises an exception
        /// </summary>
        /// <param name="expected">The expected natural value</param>
        /// <typeparam name="K">The nat type</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]   
        public static uint claim<K>(int expected)
                where K : TypeNat, new()
            => natval<K>() == (uint)expected 
                ? (uint)expected 
                : throw new ArgumentException(); 


        /// <summary>
        /// Verfies that the lengh of a list agrees with the parameterized natural
        /// If successful, the input list is returned; otherwise, an exception is
        /// raised
        /// </summary>
        /// <param name="src">The source list</param>
        /// <typeparam name="K">The nat type</typeparam>
        /// <typeparam name="T">The list element type</typeparam>
        [MethodImpl(Inline)]   
        public static IReadOnlyList<T> claim<K,T>(IReadOnlyList<T> src)
            where K : TypeNat, new()
            => natval<K>() == src.Count 
                ? src
                : throw new ArgumentException(); 

        /// <summary>
        /// Verfies that the lengh of an array agrees with the parameterized natural
        /// If successful, the input list is returned; otherwise, an exception is
        /// raised
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="K">The nat type</typeparam>
        /// <typeparam name="T">The list element type</typeparam>
        public static T[] claim<K,T>(params T[] src)
            where K : TypeNat, new()
            => natval<K>() == src.Length 
                ? src
                : throw new NatConstraintException("equality", natval<K>(), (uint)src.Length); 


        /// <summary>
        /// Retrieves the value of a pair of nats
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]   
        public static (uint k1, uint k2) pair<K1,K2>()
            where K2 : TypeNat, new()
            where K1 : TypeNat, new()
                => (natval<K1>(), natval<K2>());            

        /// <summary>
        /// Retrieves the value of a nat triple
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]   
        public static (uint k1, uint k2, uint k3) triple<K1,K2,K3>()
            where K2 : TypeNat, new()
            where K1 : TypeNat, new()
            where K3 : TypeNat, new()
                => (natval<K1>(),natval<K2>(), natval<K3>());            

        /// <summary>
        /// Returns the natural value as a generic integer
        /// </summary>
        /// <typeparam name="K">The nat type</typeparam>
        /// <typeparam name="Z">The underlying integral type</typeparam>
        [MethodImpl(Inline)]   
        public static intg<Z> gval<K,Z>()
            where K : TypeNat, new()
                => new K().value.ToIntG<Z>(); 

        /// <summary>
        /// Determines the canonical nat sequence representative
        /// </summary>
        /// <typeparam name="K">A representative type</typeparam>
        [MethodImpl(Inline)]   
        public static NatSeq natseq<K>()
            where K : TypeNat,new()
                => new K().seq;

        /// <summary>
        /// Constructs the canonical 2-element natural sequence for the 2-digit natural number k such that
        /// {k1:K1, k2:K2} => k = k1*10 + k2
        /// </summary>
        /// <typeparam name="K1">The first nat type, corresponding the first digit of the associated value</typeparam>
        /// <typeparam name="K2">The second nat type, corresponding the second digit of the associated value</typeparam>
        [MethodImpl(Inline)]   
        public static NatSeq<K1,K2> seq<K1,K2>()
            where K1 : TypeNat, new()        
            where K2 : TypeNat, new()
                => NatSeq<K1,K2>.Rep;

        /// <summary>
        /// Constructs a nondegenerate interval bounded by natural types
        /// </summary>
        /// <typeparam name="K1">The type of the left endpoint</typeparam>
        /// <typeparam name="K2">The type of the right endpoint</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]   
        public static Interval<K1,K2> interval<K1,K2>()
            where K1 : TypeNat, Demands.Smaller<K1,K2>, new()
            where K2 : TypeNat, new()
                => new Interval<K1,K2>(natrep<K1>(), natrep<K2>());

        /// <summary>
        /// Constructs a natural representative that encodes the product of two naturals
        /// </summary>
        /// <typeparam name="K1">The first operand type</typeparam>
        /// <typeparam name="K2">The second operand type</typeparam>
        [MethodImpl(Inline)]   
        public static Mul<K1,K2> mul<K1,K2>()
            where K1 : TypeNat, new()        
            where K2 : TypeNat, new()
                => Mul<K1,K2>.Rep;

        /// <summary>
        /// Constructs a natural representative that encodes a natural base raised to a
        /// natural power
        /// </summary>
        /// <typeparam name="B">The base type</typeparam>
        /// <typeparam name="E">The exponent type</typeparam>
        [MethodImpl(Inline)]   
        public static Pow<B,E> pow<B,E>()
            where B : TypeNat, new()        
            where E : TypeNat, new()
                => Pow<B,E>.Rep;

        /// <summary>
        /// Constructs a natural representative that encodes a natural prime base raised to a
        /// natural power
        /// </summary>
        /// <typeparam name="P">The prime base type</typeparam>
        /// <typeparam name="E">The exponent type</typeparam>
        [MethodImpl(Inline)]   
        public static PrimePow<P,E> primepow<P,E>()
            where P : TypeNat, Demands.Prime<P>, new()        
            where E : TypeNat, new()
                => PrimePow<P,E>.Rep;


        /// <summary>
        /// Constructs the natural dimension (k1,k2) where k1:K1 & k2:K2 
        /// </summary>
        /// <typeparam name="K1">The first dimensional factor</typeparam>
        /// <typeparam name="K2">The second dimensional factor</typeparam>
        [MethodImpl(Inline)]   
        public static Dim<K1,K2> dim<K1,K2>()
            where K1 : TypeNat, new()        
            where K2 : TypeNat, new()
                => Dim<K1,K2>.Rep;

        /// <summary>
        /// Constructs the natural dimension (k1,k2,k3) where k1:K1 & k2:K2 & k3:K3
        /// </summary>
        /// <typeparam name="K1">The first dimensional factor</typeparam>
        /// <typeparam name="K2">The second dimensional factor</typeparam>
        /// <typeparam name="K3">The third dimensional factor</typeparam>
        [MethodImpl(Inline)]   
        public static Dim<K1,K2,K3> dim<K1,K2,K3>()
            where K1 : TypeNat, new()        
            where K2 : TypeNat, new()
            where K3 : TypeNat, new()
                => Dim<K1,K2,K3>.Rep;

        /// <summary>
        /// Checks that a test value is equal to the value of a natural representative
        /// </summary>
        /// <param name="test">The value to test</param>
        /// <param name="raise">Specifies whether an error should be raised if the check fails</param>
        /// <typeparam name="K">The natural representative</typeparam>
        [MethodImpl(Inline)]   
        public static bool eq<K>(uint test, bool raise = true)
            where K : TypeNat, new() 
                =>  natval<K>() == test ? true : failure<K>("eq", test, raise);

        /// <summary>
        /// Checks that a test value is smaller than the value of a natural representative
        /// </summary>
        /// <param name="test">The value to test</param>
        /// <param name="raise">Specifies whether an error should be raised if the check fails</param>
        /// <typeparam name="K">The natural representative</typeparam>
        [MethodImpl(Inline)]   
        public static bool lt<K>(uint test, bool raise = true)
            where K : TypeNat, new() 
                =>  natval<K>() < test ? true : failure<K>("lt", test, raise);

        /// <summary>
        /// Checks that a test value is lesser or equal to the value of a natural representative
        /// </summary>
        /// <param name="test">The value to test</param>
        /// <param name="raise">Specifies whether an error should be raised if the check fails</param>
        /// <typeparam name="K">The natural representative</typeparam>
        [MethodImpl(Inline)]   
        public static bool lteq<K>(uint test, bool raise = true)
            where K : TypeNat, new() 
                =>  natval<K>() <= test ? true : failure<K>("lteq", test, raise);

        /// <summary>
        /// Checks that a test value is larger than the value of a natural representative
        /// </summary>
        /// <param name="test">The value to test</param>
        /// <param name="raise">Specifies whether an error should be raised if the check fails</param>
        /// <typeparam name="K">The natural representative</typeparam>
        [MethodImpl(Inline)]   
        public static bool gt<K>(uint test, bool raise = true)
            where K : TypeNat, new() 
                =>  natval<K>() > test ? true : failure<K>("gt", test, raise);

        /// <summary>
        /// Checks that a test value is greater or equal to the value of a natural representative
        /// </summary>
        /// <param name="test">The value to test</param>
        /// <param name="raise">Specifies whether an error should be raised if the check fails</param>
        /// <typeparam name="K">The natural representative</typeparam>
        [MethodImpl(Inline)]   
        public static bool gteq<K>(uint test, bool raise = true)
            where K : TypeNat, new() 
                =>  natval<K>() >= test ? true : failure<K>("gteq", test, raise);

        /// <summary>
        /// Checks that the first type is a successor to the second
        /// </summary>
        /// <param name="raise">Specifies whether an error should be raised if the check fails</param>
        /// <typeparam name="K1">The claimed successor</typeparam>
        /// <typeparam name="K2">The claimed predecessor</typeparam>
        [MethodImpl(Inline)]   
        public static bool successor<K1,K2>(bool raise = true)
            where K1 : TypeNat, new() 
            where K2 : TypeNat, new()
                =>  natval<K1>() == natval<K2>() + 1 ? true : failure<K1,K2>("successor", raise);
 

        /// <summary>
        /// Constructs the canonical 3-element natural sequence for the 3-digit natural number k such that
        /// {k1:K1, k2:K2, k3:K3} => k = k1*10^2 + k2*10^1 + k3
        /// </summary>
        /// <typeparam name="K1">The first nat type, corresponding the first digit of the associated value</typeparam>
        /// <typeparam name="K2">The second nat type, corresponding the second digit of the associated value</typeparam>
        /// <typeparam name="K3">The third nat type, corresponding the third digit of the associated value</typeparam>
        [MethodImpl(Inline)]   
        public static NatSeq<K1,K2,K3> seq<K1,K2,K3>()
            where K1 : TypeNat, new()        
            where K2 : TypeNat, new()
            where K3 : TypeNat, new()
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
            where K1 : TypeNat, new()        
            where K2 : TypeNat, new()
            where K3 : TypeNat, new()
            where K4 : TypeNat, new()
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
            where K1 : TypeNat, new()        
            where K2 : TypeNat, new()
            where K3 : TypeNat, new()
            where K4 : TypeNat, new()
            where K5 : TypeNat, new()
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
            where K1 : TypeNat, new()        
            where K2 : TypeNat, new()
            where K3 : TypeNat, new()
            where K4 : TypeNat, new()
            where K5 : TypeNat, new()
            where K6 : TypeNat, new()
                => default;

    }
}