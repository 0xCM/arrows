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
    using static nfunc;
    using static As;
    using static AsIn;

    public static class FixedBitOps
    {
        [MethodImpl(Inline)]
        public static FixedBits<V,S> and<V,S>(in FixedBits<V,S> x, in FixedBits<V,S> y)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector4))
                return generic<V,S>(x.bv4 & y.bv4);
            else if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(x.bv8 & y.bv8);
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(x.bv16 & y.bv16);
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(x.bv32 & y.bv32);
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(x.data & y.data);
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static FixedBits<V,S> or<V,S>(in FixedBits<V,S> x, in FixedBits<V,S> y)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector4))
                return generic<V,S>(x.bv4 | y.bv4);
            else if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(x.bv8 | y.bv8);
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(x.bv16 | y.bv16);
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(x.bv32 | y.bv32);
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(x.data | y.data);
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static FixedBits<V,S> xor<V,S>(in FixedBits<V,S> x, in FixedBits<V,S> y)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector4))
                return generic<V,S>(x.bv4 ^ y.bv4);
            else if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(x.bv8 ^ y.bv8);
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(x.bv16 ^ y.bv16);
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(x.bv32 ^ y.bv32);
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(x.data ^ y.data);
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static FixedBits<V,S> sll<V,S>(in FixedBits<V,S> src, int offset)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector4))
                return generic<V,S>(src.bv4 << offset);
            else if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(src.bv8 << offset);
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(src.bv16 << offset);
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(src.bv32 << offset);
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(src.data << offset);
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static FixedBits<V,S> srl<V,S>(in FixedBits<V,S> src, int offset)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector4))
                return generic<V,S>(src.bv4 >> offset);
            else if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(src.bv8 >> offset);
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(src.bv16 >> offset);
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(src.bv32 >> offset);
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(src.data >> offset);
            else
                throw unsupported<S>();
        }


        [MethodImpl(Inline)]
        public static FixedBits<V,S> flip<V,S>(in FixedBits<V,S> x)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector4))
                return generic<V,S>(~x.bv4);
            else if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(~x.bv8);
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(~x.bv16);
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(~x.bv32);
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(~x.data);
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        internal static ref UInt4 uint4<S>(in S src)
            => ref Unsafe.As<S,UInt4>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref FixedBits<V,S> generic<V,S>(in BitVector4 bv)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
                => ref Unsafe.As<BitVector4,FixedBits<V,S>>(ref asRef(in bv));

        [MethodImpl(Inline)]
        internal static ref FixedBits<V,S> generic<V,S>(in BitVector8 bv)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
                => ref Unsafe.As<BitVector8,FixedBits<V,S>>(ref asRef(in bv));

        [MethodImpl(Inline)]
        internal static ref FixedBits<V,S> generic<V,S>(in BitVector16 bv)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
                => ref Unsafe.As<BitVector16,FixedBits<V,S>>(ref asRef(in bv));

        [MethodImpl(Inline)]
        internal static ref FixedBits<V,S> generic<V,S>(in BitVector32 bv)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
                => ref Unsafe.As<BitVector32,FixedBits<V,S>>(ref asRef(in bv));

        [MethodImpl(Inline)]
        internal static ref FixedBits<V,S> generic<V,S>(in BitVector64 bv)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
                => ref Unsafe.As<BitVector64,FixedBits<V,S>>(ref asRef(in bv));

        [MethodImpl(Inline)]
        internal static S scalar4<V,S>(in FixedBits<V,S> src)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {                
            var s = src.bv4.Scalar;
            return Unsafe.As<UInt4,S>(ref s);
        }

        [MethodImpl(Inline)]
        internal static S scalar8<V,S>(in FixedBits<V,S> src)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {                
            var s = src.bv8.Scalar;
            return Unsafe.As<byte,S>(ref s);
        }

        [MethodImpl(Inline)]
        internal static S scalar16<V,S>(in FixedBits<V,S> src)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {                
            var s = src.bv16.Scalar;
            return Unsafe.As<ushort,S>(ref s);
        }

        [MethodImpl(Inline)]
        internal static S scalar32<V,S>(in FixedBits<V,S> src)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {                
            var s = src.bv32.Scalar;                
            return Unsafe.As<uint,S>(ref s);
        }

        [MethodImpl(Inline)]
        internal static S scalar64<V,S>(in FixedBits<V,S> src)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {                
            var s = src.data.Scalar;                
            return Unsafe.As<ulong,S>(ref s);
        }
    
        [MethodImpl(Inline)]
        internal static S scalar<V,S>(in FixedBits<V,S> src)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {
            if(typeof(S) == typeof(UInt4))
                return scalar4(in src);
            else if (typeof(S) == typeof(byte))
                return scalar8(in src);
            else if (typeof(S) == typeof(ushort))
                return scalar16(in src);
            else if (typeof(S) == typeof(uint))
                return scalar32(in src);
            else if(typeof(S) == typeof(ulong))
                return scalar64(in src);
            else 
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        internal static V primalbits<V,S>(in FixedBits<V,S> src)
            where V : unmanaged, IFixedBits<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector4))
                return Unsafe.As<BitVector4,V>(ref asRef(in src.data.bv4));
            else if(typeof(V) == typeof(BitVector8))
                return Unsafe.As<BitVector8,V>(ref asRef(in src.data.bv8));
            else if(typeof(V) == typeof(BitVector16))
                return Unsafe.As<BitVector16,V>(ref asRef(in src.data.bv16));
            else if(typeof(V) == typeof(BitVector32))
                return Unsafe.As<BitVector32,V>(ref asRef(in src.data.bv32));
            else if(typeof(V) == typeof(BitVector64))
                return Unsafe.As<BitVector64,V>(ref asRef(in src.data));
            else 
                throw unsupported<V>();
        }
    }
}