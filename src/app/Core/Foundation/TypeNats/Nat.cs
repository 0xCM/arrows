namespace Core
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;

    using static corefunc;
    

    public static class Nat
    {        
        static Type primtype(byte value)
            => (value switch
                {                    
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

        static Type seqtype(uint args)
            => typedef(args switch
            {
                1 => typeof(NatSeq<>),
                2 => typeof(NatSeq<,>),
                3 => typeof(NatSeq<,,>),
                4 => typeof(NatSeq<,,,>),
                5 => typeof(NatSeq<,,,,>),
                6 => typeof(NatSeq<,,,,,>),
                _ => nosupport<Type>()
            });

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

        public static IEnumerable<NatSeq> reflect(uint min, uint max)
        {
            for(var i = min; i<= max; i++)
                yield return reflect(i);
        }
 
        /// <summary>
        /// Constructs a type natural from a sequence of digits
        /// </summary>
        /// <param name="digits">The source digits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]       
        public static NatSeq reflect(byte[] digits)
        {
            var dtypes = types(digits);
            var nattype = seqtype(dtypes.Length()).MakeGenericType(dtypes);
            return instance<NatSeq>(nattype);            
        }
        public static T nat<T>()
            where T : TypeNat,new()
             => new T(); 
    
        public static Mul<T1,T2> mul<T1,T2>()
            where T1 : TypeNat, new()        
            where T2 : TypeNat, new()
                => Mul<T1,T2>.Rep;

        public static Pow<B,E> exp<B,E>()
            where B : TypeNat, new()        
            where E : TypeNat, new()
                => Pow<B,E>.Rep;

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