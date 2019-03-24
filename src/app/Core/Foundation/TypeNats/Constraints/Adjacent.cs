//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using static corefunc;

    partial class Traits
    {
        /// <summary>
        /// Requires n1:T1, n2:T2 => n1 + 1 = n2
        /// </summary>
        /// <typeparam name="T1">The first nat type</typeparam>
        /// <typeparam name="T2">The second nat type</typeparam>
        public interface Adjacent<T1,T2> : LT<T1,T2> 
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
        {

        }        

    }

    /// <summary>
    /// Provides evidence that n1:T1, n2:T2 => n1 + 1 = n2
    /// </summary>
    /// <typeparam name="T1">The first nat type</typeparam>
    /// <typeparam name="T2">The second nat type</typeparam>
    public readonly struct Adjacent<T1,T2> : Traits.Adjacent<T1,T2>
        where T1: TypeNat, new()
        where T2: TypeNat, new()
    {

    }

    public static class Adjacent
    {
        public static Adjacent<K1,K2> require<K1,K2>()
            where K1: TypeNat, new()
            where K2: TypeNat, new()
        {
            var k1 = natval<K1>();
            var k2 = natval<K2>();
            demand(k1 + 1 == k2);
            return new Adjacent<K1,K2>();                             
        }

    }

}