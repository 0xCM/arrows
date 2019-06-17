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
        public static ref UInt128 EnableBit(this ref UInt128 src, int pos)
            => ref ZBits.enable(ref src, pos);

        [MethodImpl(Inline)]
        public static ref Int128 EnableBit(this ref Int128 src, int pos)
            => ref ZBits.enable(ref src,pos);

        [MethodImpl(Inline)]
        public static ref UInt128 DisableBit(this ref UInt128 src, int pos)
            => ref ZBits.disable(ref src, pos);
             
        [MethodImpl(Inline)]
        public static ref Int128 DisableBit(this ref Int128 src, int pos)
            => ref ZBits.disable(ref src, pos);
 
        [MethodImpl(Inline)]
        public static bool TestBit(this in UInt128 src, int pos)
            => ZBits.test(in src, pos);

        [MethodImpl(Inline)]
        public static bool TestBit(this in Int128 src, int pos)
            => ZBits.test(in src, pos);

        [MethodImpl(Inline)]
        public static BitString ToBitString(this in UInt128 src)
            => ZBits.bitstring(in src);

        [MethodImpl(Inline)]
        public static BitString ToBitString(this in Int128 src)
            => ZBits.bitstring(in src);

        [MethodImpl(Inline)]
        public static Span<byte> ToBytes(this in Int128 src)
            => ZBits.bytes(in src);

        [MethodImpl(Inline)]
        public static Span<byte> ToBytes(this in UInt128 src)
            => ZBits.bytes(in src);
        
        public static Span<Bit> ToBits(this in UInt128 src)
            => ZBits.bits(in src);

        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this in Int128 src)
            => ZBits.bits(in src);

        [MethodImpl(Inline)]
        public static int PopCount(this in UInt128 src)
            => ZBits.pop(in src);
 
        [MethodImpl(Inline)]
        public static int PopCount(this in Int128 src)
            => ZBits.pop(in src);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static HexString ToHexString(this UInt128 src, bool zpad = true, bool specifier = true)
            => src.hi.ToHexString(false, true) + src.lo.ToHexString(true,false);

       /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static HexString ToHexString(this Int128 src, bool zpad = true, bool specifier = true)
            => src.hi.ToHexString(false, true) + src.lo.ToHexString(true,false);

    }
}