//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class ZIntX
    {
        [MethodImpl(Inline)]
        public static ref u128 EnableBit(this ref u128 src, int pos)
            => ref ZBits.enable(ref src, pos);

        [MethodImpl(Inline)]
        public static ref i128 EnableBit(this ref i128 src, int pos)
            => ref ZBits.enable(ref src,pos);

        [MethodImpl(Inline)]
        public static ref u128 DisableBit(this ref u128 src, int pos)
            => ref ZBits.disable(ref src, pos);
             
        [MethodImpl(Inline)]
        public static ref i128 DisableBit(this ref i128 src, int pos)
            => ref ZBits.disable(ref src, pos);
 
        [MethodImpl(Inline)]
        public static bool TestBit(this in u128 src, int pos)
            => ZBits.test(in src, pos);

        [MethodImpl(Inline)]
        public static bool TestBit(this in i128 src, int pos)
            => ZBits.test(in src, pos);

        [MethodImpl(Inline)]
        public static string ToBitString(this in u128 src)
            => ZBits.bitstring(in src);

        [MethodImpl(Inline)]
        public static string ToBitString(this in i128 src)
            => ZBits.bitstring(in src);

        [MethodImpl(Inline)]
        public static Span<byte> ToBytes(this in i128 src)
            => ZBits.bytes(in src);

        [MethodImpl(Inline)]
        public static Span<byte> ToBytes(this in u128 src)
            => ZBits.bytes(in src);
        
        public static Span<Bit> ToBits(this in u128 src)
            => ZBits.bits(in src);

        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this in i128 src)
            => ZBits.bits(in src);

        [MethodImpl(Inline)]
        public static int PopCount(this in u128 src)
            => ZBits.pop(in src);
 
        [MethodImpl(Inline)]
        public static int PopCount(this in i128 src)
            => ZBits.pop(in src);


    }
}