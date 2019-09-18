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

    partial class BitMasks
    {        
        /// <summary>
        /// Identifies the most significant bit in a nibble
        /// </summary>
        [Flags]
        public enum Msb4x1 : byte
        {

            Select = 8,
        }

        /// <summary>
        /// Identifies the most significant bit in a byte
        /// </summary>
        [Flags]
        public enum Msb8x1 : byte
        {                        
            Select = 128
        }

        /// <summary>
        /// Identifies the most significant bit of each byte of a 16-bit segment
        /// </summary>
        [Flags]
        public enum Msb16x8 : ushort
        {            
            /// <summary>
            /// Identifies the most significant bit in the first byte
            /// </summary>
            Byte0 = 128,
            
            /// <summary>
            /// Identifies the most significant bit in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,            

            /// <summary>
            /// Selects the most significant bits of each byte in a 16-bit segment
            /// </summary>
            Select = Byte0 | Byte1
        }

        /// <summary>
        /// Identifies most significant bits of nibbles in a 16-bit segment
        /// </summary>
        [Flags]
        public enum Msb16x4 : ushort
        {            
            /// <summary>
            /// Identifies the most significant bit in the first nibble
            /// </summary>
            Nib0 = Msb4x1.Select,
            
            /// <summary>
            /// Identifies the most significant bit in the second nibble
            /// </summary>
            Nib1 = Nib0 << 4,            

            /// <summary>
            /// Identifies the most significant bit in the third nibble
            /// </summary>
            Nib2 = Nib1 << 4,

            /// <summary>
            /// Identifies the most significant bit in the fourth nibble
            /// </summary>
            Nib3 = Nib2 << 4,

            /// <summary>
            /// Selects the most significant bits of each nibble in a 16-bit segment
            /// </summary>
            Select = Nib0 | Nib1 | Nib2 | Nib3
        }

        /// <summary>
        /// Identifies most significant bits of bytes in a 24-bit segment
        /// </summary>
        [Flags]
        public enum Msb24x8 : uint
        {            
            /// <summary>
            /// Identifies the most significant bit in the first byte
            /// </summary>
            Byte0 = 128,
            
            /// <summary>
            /// Identifies the most significant bit in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Identifies the most significant bit in the third byte
            /// </summary>
            Byte2 = Byte1 << 8,

            /// <summary>
            /// Selects the most significant bit from each byte in a 24-bit segment
            /// </summary>
            Select = Byte0 | Byte1 | Byte2
        }

        /// <summary>
        /// Identifies most significant bits of bytes in a 32-bit segment
        /// </summary>
        [Flags]
        public enum Msb32x8 : uint
        {            
            /// <summary>
            /// Identifies the most significant bit in the first byte
            /// </summary>
            Byte0 = 128,

            /// <summary>
            /// Identifies the most significant bit in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Identifies the most significant bit in the third byte
            /// </summary>
            Byte2 = Byte1 << 8,

            /// <summary>
            /// Identifies the most significant bit in the fourth byte
            /// </summary>
            Byte3 = Byte2 << 8,

            /// <summary>
            /// Selects the most significant bit from each byte in a 32-bit segment
            /// </summary>
            Select = Byte0 | Byte1 | Byte2 | Byte3

        }

        /// <summary>
        /// Identifies most significant bits of bytes in a 64-bit segment
        /// </summary>
        [Flags]
        public enum Msb64x8 : ulong
        {            
            /// <summary>
            /// Identifies the most significant bit in the first byte
            /// </summary>
            Byte0 = 128,

            /// <summary>
            /// Identifies the most significant bit in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Identifies the most significant bit in the third byte
            /// </summary>
            Byte2 = Byte1 << 8,

            /// <summary>
            /// Identifies the most significant bit in the fourth byte
            /// </summary>
            Byte3 = Byte2 << 8,

            /// <summary>
            /// Identifies the most significant bit in the fifth byte
            /// </summary>
            Byte4 = Byte3 << 8,

            /// <summary>
            /// Identifies the most significant bit in the sixth byte
            /// </summary>
            Byte5 = Byte4 << 8,

            /// <summary>
            /// Identifies the most significant bit in the seventh byte
            /// </summary>
            Byte6 = Byte5 << 8,

            /// <summary>
            /// Identifies the most significant bit in the eighth byte
            /// </summary>
            Byte7 = Byte6 << 8,
            
            /// <summary>
            /// Identifies the most significant bit in each byte of a 64-bit segment
            /// </summary>
            Select = Byte0 | Byte1 | Byte2 | Byte3 | Byte4 | Byte5 | Byte6 | Byte7
        }

    }

}