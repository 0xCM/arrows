//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    using static AsIn;
    
    partial class gbits
    {
        /// <summary>
        /// Creates a type-parametric fixed-length bitvector from a scalar value
        /// </summary>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="V">The nonparametric vector of fixed size</typeparam>
        /// <typeparam name="S">A supported scalar type</typeparam>
        public static FixedBits<V,S> fixedbits<V,S>(in S s, V rep = default)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
                => FixedBits.FromScalar<V,S>(in s);

        /// <summary>
        /// Creates a type-parametric fixed-length bitvector from a non-parametric bitvector
        /// </summary>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="V">The nonparametric vector of fixed size</typeparam>
        /// <typeparam name="S">A supported scalar type</typeparam>
        public static FixedBits<V,S> fixedbits<V,S>(in V v, S rep = default)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
                => FixedBits.FromVector(v,rep);

        /// <summary>
        /// Creates a primal bitvector from a fixed bitvector
        /// </summary>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="V">The nonparametric vector of fixed size</typeparam>
        /// <typeparam name="S">A supported scalar type</typeparam>
        public static V primalbits<V,S>(in FixedBits<V,S> bvfixed)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
                => bvfixed.PrimalBits;
        
        /// <summary>
        /// Creates a type-parametric fixed-length bitvector from a scalar source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="V">The nonparametric vector of fixed size</typeparam>
        /// <typeparam name="S">A supported scalar type</typeparam>
        [MethodImpl(Inline)]
        public static V bitvector<V,S>(in S src)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {
            if(typeof(S) == typeof(UInt4))
            {
                var bv = BitVector4.FromScalar(uInt4(in src));
                return bvgeneric<V>(ref bv);
            }
            else if (typeof(S) == typeof(byte))
            {
                var bv = BitVector8.FromScalar(uint8(in src));
                return bvgeneric<V>(ref bv);
            }
            else if (typeof(S) == typeof(ushort))
            {
                var bv = BitVector16.FromScalar(uint16(in src));
                return bvgeneric<V>(ref bv);
            }
            else if (typeof(S) == typeof(uint))
            {
                var bv = BitVector32.FromScalar(uint32(in src));
                return bvgeneric<V>(ref bv);
            }
            else if (typeof(S) == typeof(ulong))
            {
                var bv = BitVector64.FromScalar(uint64(in src));
                return bvgeneric<V>(ref bv);
            }
            else
                throw unsupported<S>();

        }

        [MethodImpl(Inline)]
        static UInt4 uInt4<T>(in T src)
            where T : unmanaged
                => Unsafe.As<T,UInt4>(ref asRef(in src));

        [MethodImpl(Inline)]
        static V bvgeneric<V>(ref BitVector64 src)
            where V : unmanaged
                =>   Unsafe.As<BitVector64,V>(ref src);


        [MethodImpl(Inline)]
        static V bvgeneric<V>(ref BitVector32 src)
            where V : unmanaged
                =>   Unsafe.As<BitVector32,V>(ref src);


        [MethodImpl(Inline)]
        static V bvgeneric<V>(ref BitVector16 src)
            where V : unmanaged
                =>   Unsafe.As<BitVector16,V>(ref src);

        [MethodImpl(Inline)]
        static V bvgeneric<V>(ref BitVector8 src)
            where V : unmanaged
                =>   Unsafe.As<BitVector8,V>(ref src);


        [MethodImpl(Inline)]
        static V bvgeneric<V>(ref BitVector4 src)
            where V : unmanaged
                =>   Unsafe.As<BitVector4,V>(ref src);



    }

}