//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static BitMasks;

    partial class BitMasks
    {        
        /// <summary>
        /// Identifies the even bits in a nibble
        /// </summary>
        [Flags]
        public enum Odd4x1 : byte
        {
            /// <summary>
            /// Identifies the first even bit
            /// </summary>
            Bit1 = Seg4x1.Bit1,
            
            /// <summary>
            /// Identifies the second even bit
            /// </summary>
            Bit4 = Bit1 << 2,
                        
                        
            /// <summary>
            /// Selects the odd bits in a nibble
            /// </summary>
            Select = Bit1 |  Bit4
        }


        /// <summary>
        /// Identifies the odd bits in a byte
        /// </summary>
        [Flags]
        public enum Odd8x1 : byte
        {
            /// <summary>
            /// Identifies the bit at position 1
            /// </summary>
            Bit1 = Seg8x1.Bit1,
            
            /// <summary>
            /// Identifies the bit at position 3
            /// </summary>
            Bit3 = Bit1 << 2,            
            
            /// <summary>
            /// Identifies the bit at position 5
            /// </summary>
            Bit5 = Bit3 << 2,            
            
            /// <summary>
            /// Identifies the bit at position 7
            /// </summary>
            Bit7 = Bit5 << 2,
            
            /// <summary>
            /// Selects the odd bits in the byte
            /// </summary>
            Select = Bit1 |  Bit3 |  Bit5 |  Bit7

        }

        /// <summary>
        /// Identifies odd bits in a 16-bit segment
        /// </summary>
        [Flags]
        public enum Odd16x8 : ushort
        {
            /// <summary>
            /// Identifies the odd bits in the first byte
            /// </summary>
            Byte0 = Odd8x1.Select,
            
            /// <summary>
            /// Identifies the odd bits in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Selects the odd bits in a 16-bit segment
            /// </summary>
            Select = Byte0 | Byte1
        }

        /// <summary>
        /// Identifies odd bits in a 32-bit segment
        /// </summary>
        [Flags]
        public enum Odd32x8 : uint
        {
            /// <summary>
            /// Identifies the odd bits in the first byte
            /// </summary>
            Byte0 = Odd8x1.Select,
            
            /// <summary>
            /// Identifies the odd bits in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Identifies the odd bits in the third byte
            /// </summary>
            Byte2 = Byte1 << 8,

            /// <summary>
            /// Identifies the odd bits in the fourth byte
            /// </summary>
            Byte3 = Byte2 << 8,

            /// <summary>
            /// Selects the odd bits in a 32-bit segment
            /// </summary>
            Select = Byte0 | Byte1 | Byte2 | Byte3
        }



        /// <summary>
        /// Identifies odd bits in a 64-bit segment
        /// </summary>
        [Flags]
        public enum Odd64x8 : ulong
        {
            /// <summary>
            /// Identifies the odd bits in the first byte
            /// </summary>
            Byte0 = Odd8x1.Select,
            
            /// <summary>
            /// Identifies the odd bits in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Identifies the odd bits in the third byte
            /// </summary>
            Byte2 = Byte1 << 8,

            /// <summary>
            /// Identifies the odd bits in the fourth byte
            /// </summary>
            Byte3 = Byte2 << 8,

            /// <summary>
            /// Identifies the odd bits in the fifth byte
            /// </summary>
            Byte4 = Byte3 << 8,

            /// <summary>
            /// Identifies the odd bits in the sixth byte
            /// </summary>
            Byte5 = Byte4 << 8,

            /// <summary>
            /// Identifies the odd bits in the seventh byte
            /// </summary>
            Byte6 = Byte5 << 8,

            /// <summary>
            /// Identifies the odd bits in the eight byte
            /// </summary>
            Byte7 = Byte6 << 8,

            /// <summary>
            /// Selects the od bits in a 64-bit segment
            /// </summary>
            Select = Byte0 | Byte1 | Byte2 | Byte3 | Byte4 | Byte5 | Byte6 | Byte7
        }


    }

}