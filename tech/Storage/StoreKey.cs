//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Storage
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;

    using FASTER.core;
    using static zfunc;
    using static KeyUtility;

    static class KeyUtility
    {
        [MethodImpl(Inline)]
        public static long hash64<T>(in T x)
            where T : struct
                => Utility.GetHashCode(convert<T,long>(x));

        [MethodImpl(Inline)]
        public static long hash64<S,T>(in S x, in T y)
            where S : struct
            where T : struct
                => hash64(x) ^ hash64(y);
    }

    public static class Keys
    {
        [MethodImpl(Inline)]
        public static StoreKeyComparer<K> Comparer<K>()
            where K: struct            
                => StoreKeyComparer<K>.TheOnly;

        [MethodImpl(Inline)]
        public static StoreKey<K> Key<K>(K keyVal)
            where K: struct            
                => new StoreKey<K>(keyVal);

        [MethodImpl(Inline)]
        public static StoreKey<K0,K1> Key<K0,K1>(K0 k0, K1 k1)
            where K0: struct            
            where K1: struct
                => new StoreKey<K0,K1>(k0, k1);

    }

    public interface IStoreKey<K0> : IFasterEqualityComparer<StoreKey<K0>>
        where K0 : struct
    {
        K0 Part0 {get;}
    }
    
    public interface IStoreKey<K0,K1> : IFasterEqualityComparer<StoreKey<K0,K1>>
        where K0 : struct
        where K1 : struct
    {

    }
    
    public readonly struct StoreKeyComparer<K> : IFasterEqualityComparer<K>
        where K : struct
    {
        public static readonly StoreKeyComparer<K> TheOnly = default;

        [MethodImpl(Inline)]
        public bool Equals(ref K lhs, ref K rhs)
            => gmath.eq(lhs, rhs);

        [MethodImpl(Inline)]
        public long GetHashCode64(ref K src)
            => hash64(in src);
    }


    public readonly struct StoreKey<K0> : IStoreKey<K0>
        where K0 : struct
    {
        [MethodImpl(Inline)]
        public StoreKey(K0 k0)
        {
            this.Part0 = k0;
        }
        
        public readonly K0 Part0 {get;}

        [MethodImpl(Inline)]
        public bool Equals(ref StoreKey<K0> lhs, ref StoreKey<K0> rhs)
            => gmath.eq(lhs.Part0,rhs.Part0);

        [MethodImpl(Inline)]
        public long GetHashCode64(ref StoreKey<K0> src)
            => hash64(src.Part0);
    }

    public readonly struct StoreKey<K0,K1> : IStoreKey<K0,K1>
        where K0 : struct
        where K1 : struct
    {
        [MethodImpl(Inline)]
        public StoreKey(K0 k0, K1 k1)
        {
            this.Part0 = k0;
            this.Part1 = k1;
        }

        public readonly K0 Part0 {get;}

        public readonly K1 Part1 {get;}

        [MethodImpl(Inline)]
        public long GetHashCode64(ref StoreKey<K0, K1> src)
            => hash64(src.Part0, src.Part1);

        [MethodImpl(Inline)]
        public bool Equals(ref StoreKey<K0, K1> lhs, ref StoreKey<K0, K1> rhs)
            => gmath.eq(lhs.Part0, rhs.Part0) && gmath.eq(lhs.Part1, rhs.Part1);
    }


    public struct Output<V>
        where V : struct
    {
        public V Value;
    }

    public struct Input<V>
        where V : struct
    {
        public V Value;
    }


    public readonly struct StoreContext
    {   
        public static readonly StoreContext Default = default;

    }

}