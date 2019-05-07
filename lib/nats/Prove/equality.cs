//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;


    using static nats;

    partial class Prove
    {

        /// <summary>
        /// Retrieves the value of the natural number associated with a typenat
        /// and retuns the value if it agrees with a supplied expected value; othwise,
        /// raises an exception
        /// </summary>
        /// <param name="expected">The expected natural value</param>
        /// <typeparam name="K">The natural type</typeparam>
        [MethodImpl(Inline)]   
        public static ulong claim<K>(ulong expected)
            where K : ITypeNat, new()
                => natu<K>() == expected  ? expected : failure<K,ulong>("eq", expected);

        /// <summary>
        /// Retrieves the value of the natural number associated with a typenat
        /// and retuns the value if it agrees with a supplied expected value; othwise,
        /// raises an exception
        /// </summary>
        /// <param name="k">The reification of K</param>
        /// <param name="expected">The expected natural value</param>
        /// <typeparam name="K">The natural type</typeparam>
        [MethodImpl(Inline)]   
        public static ulong claim<K>(K k, ulong expected)
                where K : ITypeNat, new()
                    => k.value == expected  ? expected : failure<K,ulong>("eq", expected);

        /// <summary>
        /// Attempts to prove that k:K => k == expected
        /// Registers success by returning the expected value
        /// Registers failure by raising an error
        /// </summary>
        /// <param name="expected">The expected natural value</param>
        /// <typeparam name="K">The natural type</typeparam>
        [MethodImpl(Inline)]   
        public static uint claim<K>(int expected)
            where K : ITypeNat, new()
                => natu<K>() == (uint)expected ? (uint)expected : failure<K,uint>("eq", (uint)expected);

        /// <summary>
        /// Attempts to prove that k:K => k == expected
        /// Registers success by returning the expected value
        /// Registers failure by raising an error
        /// </summary>
        /// <param name="k">The reification of K</param>
        /// <param name="expected">The expected natural value</param>
        /// <typeparam name="K">The natural type</typeparam>
        [MethodImpl(Inline)]   
        public static uint claim<K>(K k, int expected)
                where K : ITypeNat, new()
                    => k.value == (uint)expected ? (uint)expected : failure<K,uint>("eq", (uint)expected);

        /// <summary>
        /// Prooves that a test value is equal to the value of a natural representative
        /// </summary>
        /// <param name="test">The value to test</param>
        /// <param name="raise">Specifies whether an error should be raised if the check fails</param>
        /// <typeparam name="K">The natural representative</typeparam>
        [MethodImpl(Inline)]   
        public static bool eq<K>(uint test, bool raise = true)
            where K : ITypeNat, new() 
                =>  natu<K>() == test ? true : failure<K>("eq", test, raise);


        /// <summary>
        /// If possible, constructs evidence that k1:K1 & k2:K2 => k1 = k2; otherwise
        /// raises an error
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        /// <returns></returns>
        public static Equal<K1,K2> equal<K1,K2>()
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => new Equal<K1,K2>(natrep<K1>(),natrep<K2>());                             

        /// <summary>
        /// If possible, constructs evidence that k1:K1 & k2:K2 => k1 = k2; otherwise
        /// raises an error
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        /// <returns></returns>
        public static Equal<K1,K2> equal<K1,K2>(K1 k1, K2 k2)
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => new Equal<K1,K2>(k1,k2);                             

        /// <summary>
        /// If possible, constructs evidence that k1:K1 & k2:K2 => k1 = k2; otherwise
        /// raises an error
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        /// <returns></returns>
        public static Option<Equal<K1,K2>> tryEqual<K1,K2>()
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => new Equal<K1,K2>(natrep<K1>(),natrep<K2>()));

        /// <summary>
        /// If possible, constructs evidence that k1:K1 & k2:K2 => k1 = k2; otherwise
        /// raises an error
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        /// <returns></returns>
        public static Option<Equal<K1,K2>> tryEqual<K1,K2>(K1 k1, K2 k2)
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => new Equal<K1,K2>(k1,k2));                             

        /// <summary>
        /// If possible, constructs evidence that k1:K1 & k2:K2 => k1 = k2; otherwise
        /// raises an error
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        /// <returns></returns>
        public static Different<K1,K2> different<K1,K2>()
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => new Different<K1,K2>(natrep<K1>(),natrep<K2>());                             

        /// <summary>
        /// If possible, constructs evidence that k1:K1 & k2:K2 => k1 = k2; otherwise
        /// raises an error
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        /// <returns></returns>
        public static Different<K1,K2> different<K1,K2>(K1 k1, K2 k2)
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => new Different<K1,K2>(k1,k2);


    }
}