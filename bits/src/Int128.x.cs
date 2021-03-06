//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    public static class Int128X
    {
        [MethodImpl(Inline)]
        public static ref Int128 EnableBit(this ref Int128 src, int pos)
        {
            if(pos < 64)
                BitMask.enable(ref src.lo, pos);
            else
                BitMask.enable(ref src.hi, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static bool TestBit(this Int128 src, int pos)
            => pos < 64 ? BitMask.test(src.lo, pos) : BitMask.test(src.hi, pos) ;

        [MethodImpl(Inline)]
        public static BitString ToBitString(this Int128 src)
            => BitString.FromScalar(src.hi) + BitString.FromScalar(src.lo); 

        [MethodImpl(Inline)]
        public static Span<byte> ToBytes(this Int128 src)
            => new byte[]
                {
                    src.x0000, src.x0001, src.x0010, src.x0011,
                    src.x0100, src.x0101, src.x0110, src.x0111,                        
                    src.x1100, src.x1101, src.x1110, src.x1111,            
                    src.x1000, src.x1001, src.x1010, src.x1011
                };

        [MethodImpl(Inline)]
        public static ref Int128 DisableBit(this ref Int128 src, int pos)
        {
            if(pos < 64)
                BitMask.disable(ref src.lo, pos);
            else
                BitMask.disable(ref src.hi, pos);
            return ref src;               
        }
 
        [MethodImpl(Inline)]
        public static int PopCount(this Int128 src)
            => (int)(Bits.pop(src.lo) + Bits.pop(src.hi));

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static HexString ToHexString(this Int128 src, bool zpad = true, bool specifier = true)
            => src.hi.FormatHex(false, true) + src.lo.FormatHex(true,false);        
    }
}