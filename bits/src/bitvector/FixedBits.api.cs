//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static As;
    using static AsIn;
    using static FixedBitOps;

    public static class FixedBits
    {
        [MethodImpl(Inline)]
        public static FixedBits<BitVector8,byte> FromScalar(byte src)
            => FromScalar<BitVector8,byte>(in src);

        [MethodImpl(Inline)]
        public static FixedBits<BitVector16,ushort> FromScalar(ushort src)
            => FromScalar<BitVector16,ushort>(in src);

        [MethodImpl(Inline)]
        public static FixedBits<BitVector32,uint> FromScalar(uint src)
            => FromScalar<BitVector32,uint>(in src);

        [MethodImpl(Inline)]
        public static FixedBits<BitVector64,ulong> FromScalar(ulong src)
            => FromScalar<BitVector64,ulong>(in src);

        [MethodImpl(Inline)]
        public static FixedBits<V,S> FromScalar<V,S>(in S src)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {
            if(typeof(S) == typeof(UInt4))
                return new FixedBits<V,S>(uint4(in src));
            else if(typeof(S) == typeof(byte))
                return new FixedBits<V,S>(uint8(in src));
            else if(typeof(S) == typeof(ushort))
                return new FixedBits<V,S>(uint64(in src));
            else if(typeof(S) == typeof(uint))
                return new FixedBits<V,S>(uint32(in src));
            else if(typeof(S) == typeof(ulong))
                return new FixedBits<V,S>(uint64(in src));
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static ref FixedBits<V,S> FromScalar<V,S>(in S s, ref FixedBits<V,S> src)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {            
            src = FixedBits.FromScalar<V,S>(in s);
            return ref src;
        }

        /// <summary>
        /// Creates a type-parametric fixed-length bitvector from a non-parametric bitvector
        /// </summary>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="V">The nonparametric vector of fixed size</typeparam>
        /// <typeparam name="S">A supported scalar type</typeparam>
        public static FixedBits<V,S> FromVector<V,S>(in V v, S rep = default)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector4))
                return new FixedBits<V,S>(Unsafe.As<V,BitVector4>(ref asRef(in v)));
            else if(typeof(V) == typeof(BitVector8))
                return new FixedBits<V,S>(Unsafe.As<V,BitVector8>(ref asRef(in v)));
            else if(typeof(V) == typeof(BitVector16))
                return new FixedBits<V,S>(Unsafe.As<V,BitVector16>(ref asRef(in v)));
            else if(typeof(V) == typeof(BitVector32))
                return new FixedBits<V,S>(Unsafe.As<V,BitVector32>(ref asRef(in v)));
            else if(typeof(V) == typeof(BitVector64))
                return new FixedBits<V,S>(Unsafe.As<V,BitVector64>(ref asRef(in v)));
            else
                throw unsupported<S>();
        }



    }



}