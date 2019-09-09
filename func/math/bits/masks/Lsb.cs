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
        /// Identifies the least significant bit in a nibble
        /// </summary>
        [Flags]
        public enum Lsb4x1 : byte
        {
            Select = Seg4x1.Bit0
        }

        /// <summary>
        /// Identifies the least significant bit in a byte
        /// </summary>
        [Flags]
        public enum Lsb8x1 : byte
        {            
            Select = Seg8x1.Bit0
        }

        /// <summary>
        /// Identifies the least significant bit of each byte of a 16-bit segment
        /// </summary>
        [Flags]
        public enum Lsb16x8 : ushort
        {                        
            /// <summary>
            /// Identifies the least significant bit of the first byte
            /// </summary>
            Byte0 = Seg8x1.Bit0,
            
            /// <summary>
            /// Identifies the least significant bit of the second byte
            /// </summary>
            Byte1 = Byte0 << 8,            

            /// <summary>
            /// Selects the least significant bits of two 1-byte segments
            /// </summary>
            Select = Byte0 | Byte1
        }

        /// <summary>
        /// Identifies the least significant bit of each nibble of a 16-bit segment
        /// </summary>
        [Flags]
        public enum Lsb16x4 : ushort
        {            
            /// <summary>
            /// Identifies the least significant bit of the first 4-bit segment
            /// </summary>
            Nib0 = Lsb4x1.Select,
            
            /// <summary>
            /// Identifies the least significant bit of the second 4-bit segment
            /// </summary>
            Nib1 = Nib0 << 4,            

            /// <summary>
            /// Identifies the least significant bit of the third 4-bit segment
            /// </summary>
            Nib2 = Nib1 << 4,

            /// <summary>
            /// Identifies the least significant bit of the fourth 4-bit segment
            /// </summary>
            Nib3 = Nib2 << 4,
            
            /// <summary>
            /// Identifies the least significant bit of each 4-bit segment
            /// </summary>
            Select = Nib0 | Nib1 | Nib2 | Nib3
        }


        /// <summary>
        /// Identifies least significant bits of bytes in a 24-bit segment
        /// </summary>
        [Flags]
        public enum Lsb24x8 : uint
        {                        
            /// <summary>
            /// Identifies the least significant bit in the first byte
            /// </summary>
            Byte0 = 0b00000001,
            
            /// <summary>
            /// Identifies the least significant bit in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Identifies the least significant bit in the third byte
            /// </summary>
            Byte2 = Byte1 << 8,

            /// <summary>
            /// Selects the least significant bit from each byte in a 24-bit segment
            /// </summary>
            Select = Byte0 | Byte1 | Byte2
        }

        /// <summary>
        /// Identifies least significant bits of bytes in a 32-bit segment
        /// </summary>
        [Flags]
        public enum Lsb32x8 : uint
        {            
            /// <summary>
            /// Identifies the least significant bit in the first byte
            /// </summary>
            Byte0 = Seg8x1.Bit0,

            /// <summary>
            /// Identifies the least significant bit in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Identifies the least significant bit in the third byte
            /// </summary>
            Byte2 = Byte1 << 8,

            /// <summary>
            /// Identifies the least significant bit in the fourth byte
            /// </summary>
            Byte3 = Byte2 << 8,

            /// <summary>
            /// Selects the least significant bit from each byte in a 32-bit segment
            /// </summary>
            Select = Byte0 | Byte1 | Byte2 | Byte3

        }


        /// <summary>
        /// Identifies least significant bits of bytes in a 64-bit segment
        /// </summary>
        [Flags]
        public enum Lsb64x8 : ulong
        {            
            /// <summary>
            /// Identifies the least significant bit in the first byte
            /// </summary>
            Byte0 = Seg8x1.Bit0,

            /// <summary>
            /// Identifies the least significant bit in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Identifies the least significant bit in the third byte
            /// </summary>
            Byte2 = Byte1 << 8,

            /// <summary>
            /// Identifies the least significant bit in the fourth byte
            /// </summary>
            Byte3 = Byte2 << 8,

            /// <summary>
            /// Identifies the least significant bit in the fifth byte
            /// </summary>
            Byte4 = Byte3 << 8,

            /// <summary>
            /// Identifies the least significant bit in the sixth byte
            /// </summary>
            Byte5 = Byte4 << 8,

            /// <summary>
            /// Identifies the least significant bit in the seventh byte
            /// </summary>
            Byte6 = Byte5 << 8,

            /// <summary>
            /// Identifies the least significant bit in the eighth byte
            /// </summary>
            Byte7 = Byte6 << 8,

            /// <summary>
            /// Identifies the least significant bit in each byte of a 64-bit segment
            /// </summary>
            Select = Byte0 | Byte1 | Byte2 | Byte3 | Byte4 | Byte5 | Byte6 | Byte7
        }
    }
}