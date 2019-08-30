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

    public static class BitMasks
    {        
        /// <summary>
        /// Identifies a bit in a 1-bit segment
        /// </summary>
        public enum Seg1x1 : byte
        {
            Bit0 = 0b1
        }
        
        /// <summary>
        /// Identifies the bits in a 3-bit segment
        /// </summary>
        [Flags]
        public enum Seg3x1 : byte
        {
            
            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Bit0 = Seg1x1.Bit0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Bit1 = Bit0 << 1,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Bit2 = Bit1 << 1,

            /// <summary>
            /// Selects all bits of a 3-bit segment
            /// </summary>
            Select = Bit0 | Bit1 | Bit2
        }

        /// <summary>
        /// Identifies the bits in a 4-bit segment
        /// </summary>
        [Flags]
        public enum Seg4x1 : byte
        {
            
            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Bit0 = Seg1x1.Bit0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Bit1 = Bit0 << 1,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Bit2 = Bit1 << 1,

            /// <summary>
            /// Identifies the fourth bit
            /// </summary>
            Bit3 = Bit2 << 1,

            /// <summary>
            /// Selects all bits of a 4-bit segment
            /// </summary>
            Select = Bit0 | Bit1 | Bit2 | Bit3
        }


        /// <summary>
        /// Identifies the least significant bit in a nibble
        /// </summary>
        [Flags]
        public enum Lsb4x1 : byte
        {

            Select = Seg4x1.Bit0

        }

        /// <summary>
        /// Identifies the most significant bit in a nibble
        /// </summary>
        [Flags]
        public enum Msb4x1 : byte
        {

            Select = Seg4x1.Bit3,

        }

        /// <summary>
        /// Identifies segments of length two in a 2-bit segment
        /// </summary>        
        [Flags]
        public enum Seg4x2 : byte
        {
            
            /// <summary>
            /// Identifies the first 2-bit group
            /// </summary>
            Seg0 = Seg4x1.Bit0 | Seg4x1.Bit1,

            /// <summary>
            /// Identifies the second 2-bit group
            /// </summary>
            Seg1 = Seg0 << 2,
            
            /// <summary>
            /// Selects two 2-bit segments
            /// </summary>
            Select = Seg0 | Seg1,

        }

        /// <summary>
        /// Identifies segments of length three in a 6-bit segment
        /// </summary>
        public enum Seg6x3 : ushort
        {
            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Seg0 = Seg3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Seg1 = Seg0 << 3,

            /// <summary>
            /// Selects two 3-bit segments
            /// </summary>
            Select = Seg0 | Seg1

        }


        /// <summary>
        /// Identifies the bits in a byte
        /// </summary>
        [Flags]
        public enum Seg8x1 : byte
        {
            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Bit0 = Seg1x1.Bit0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Bit1 = Bit0 << 1,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Bit2 = Bit1 << 1,

            /// <summary>
            /// Identifies the fourth bit
            /// </summary>
            Bit3 = Bit2 << 1,            

            /// <summary>
            /// Identifies the fifth bit
            /// </summary>
            Bit4 = Bit3 << 1,

            /// <summary>
            /// Identifies the sixth bit
            /// </summary>
            Bit5 = Bit4 << 1,            

            /// <summary>
            /// Identifies the seventh bit
            /// </summary>
            Bit6 = Bit5 << 1,                    
            
            /// <summary>
            /// Identifies the eighth bit
            /// </summary>
            Bit7 = Bit6 << 1,
            
            /// <summary>
            /// Selects all bits of a byte
            /// </summary>
            Select = Bit0 | Bit1 | Bit2 | Bit4 | Bit5 | Bit6 | Bit7

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
        /// Identifies the most significant bit in a byte
        /// </summary>
        [Flags]
        public enum Msb8x1 : byte
        {            
            
            Select = Seg8x1.Bit7

        }

        /// <summary>
        /// Identifies the even bits in a byte
        /// </summary>
        [Flags]
        public enum Even8x1 : byte
        {
            /// <summary>
            /// Identifies the first even bit
            /// </summary>
            Bit0 = Seg8x1.Bit0,
            
            /// <summary>
            /// Identifies the second even bit
            /// </summary>
            Bit2 = Bit0 << 2,
                        
            /// <summary>
            /// Identifies third even bit
            /// </summary>
            Bit4 = Bit2 << 2,
                        
            /// <summary>
            /// Identifies the fourth even bit
            /// </summary>
            Bit6 = Bit4 << 2,
                        
            /// <summary>
            /// Selects the even bits in a byte
            /// </summary>
            Select = Bit0 |  Bit2 |  Bit4 | Bit6 

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
            /// Selects the odd bits
            /// </summary>
            Select = Bit1 |  Bit3 |  Bit5 |  Bit7

        }

        /// <summary>
        /// Identifies the bits in a 9-bit group
        /// </summary>
        [Flags]
        public enum Seg9x1 : ushort
        {
            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Bit0 = Seg1x1.Bit0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Bit1 = Bit0 << 1,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Bit2 = Bit1 << 1,

            /// <summary>
            /// Identifies the fourth bit
            /// </summary>
            Bit3 = Bit2 << 1,            

            /// <summary>
            /// Identifies the fifth bit
            /// </summary>
            Bit4 = Bit3 << 1,

            /// <summary>
            /// Identifies the sixth bit
            /// </summary>
            Bit5 = Bit4 << 1,            

            /// <summary>
            /// Identifies the seventh bit
            /// </summary>
            Bit6 = Bit5 << 1,                    
            
            /// <summary>
            /// Identifies the eighth bit
            /// </summary>
            Bit7 = Bit6 << 1,

            /// <summary>
            /// Identifies the ninth bit
            /// </summary>
            Bit8 = Bit7 << 1,
            
            /// <summary>
            /// Selects all bits of a byte
            /// </summary>
            Select = Bit0 | Bit1 | Bit2 | Bit4 | Bit5 | Bit6 | Bit7 | Bit8

        }


        /// <summary>
        /// Identifies segments of length three in a 9-bit segment
        /// </summary>
        public enum Seg9x3 : ushort
        {
            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Seg0 = Seg3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Seg1 = Seg0 << 3,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Seg2 = Seg1 << 3,

        }

        /// <summary>
        /// Identifies segments of length four in a 16 bit segment
        /// </summary>
        [Flags]
        public enum Seg16x4 : ushort
        {            
            /// <summary>
            /// Identifies the first 4-bit group
            /// </summary>
            Seg0 = Seg4x1.Select,

            /// <summary>
            /// Identifies the second 4-bit group
            /// </summary>
            Seg1 = Seg0 << 4,

            /// <summary>
            /// Identifies the third 4-bit group
            /// </summary>
            Seg2 = Seg1 << 4,

            /// <summary>
            /// Identifies the fourth four bits
            /// </summary>
            Seg3 = Seg2 << 4,

            /// <summary>
            /// Identifies the first byte
            /// </summary>
            Lower = Seg0 | Seg1,
            
            /// <summary>
            /// Identifies the second byte
            /// </summary>
            Upper = Seg2 | Seg3,

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
            Nib0 = Lsb4x1.Select,
            
            Nib1 = Nib0 << 4,            

            Nib2 = Nib1 << 4,

            Nib3 = Nib2 << 4,

            Select = Nib0 | Nib1 | Nib2 | Nib3
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
            Byte0 = Seg8x1.Bit7,
            
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
        /// Identifies even bits in a 16-bit segment
        /// </summary>
        [Flags]
        public enum Even16x8 : ushort
        {
            /// <summary>
            /// Identifies the even bits in the first byte
            /// </summary>
            Byte0 = Even8x1.Select,
            
            /// <summary>
            /// Identifies the even bits in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Selects the even bits in a 16-bit segment
            /// </summary>
            Select = Byte0 | Byte1
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
        /// Identifies segments of length three in an 18-bit segment
        /// </summary>
        public enum Seg18x3 : uint
        {
            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Seg0 = Seg3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Seg1 = Seg0 << 3,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Seg2 = Seg1 << 3,

            /// <summary>
            /// Identifies the fourth 3-bit group
            /// </summary>
            Seg3 = Seg2 << 3,

            /// <summary>
            /// Identifies the fifth 3-bit group
            /// </summary>
            Seg4 = Seg3 << 3,

            /// <summary>
            /// Identifies the sixth 3-bit group
            /// </summary>
            Seg5 = Seg4 << 3,

            /// <summary>
            /// Selects all bits in an 18-bit segment
            /// </summary>
            Select = Seg0 | Seg1 | Seg2 | Seg3 | Seg4 | Seg5,

        }

        /// <summary>
        /// Identifies segments of length three in an 21-bit segment
        /// </summary>
        public enum Seg21x3 : uint
        {
            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Seg0 = Seg3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Seg1 = Seg0 << 3,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Seg2 = Seg1 << 3,

            /// <summary>
            /// Identifies the fourth 3-bit group
            /// </summary>
            Seg3 = Seg2 << 3,

            /// <summary>
            /// Identifies the fifth 3-bit group
            /// </summary>
            Seg4 = Seg3 << 3,

            /// <summary>
            /// Identifies the sixth 3-bit group
            /// </summary>
            Seg5 = Seg4 << 3,

            /// <summary>
            /// Identifies the seventh 3-bit group
            /// </summary>
            Seg6 = Seg5 << 3,


            /// <summary>
            /// Selects all bits in an 18-bit segment
            /// </summary>
            Select = Seg0 | Seg1 | Seg2 | Seg3 | Seg4 | Seg5 | Seg6,
        }


        /// <summary>
        /// Identifies segments of length three in an 24-bit segment
        /// </summary>
        public enum Seg24x3 : uint
        {
            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Seg0 = Seg3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Seg1 = Seg0 << 3,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Seg2 = Seg1 << 3,

            /// <summary>
            /// Identifies the fourth 3-bit group
            /// </summary>
            Seg3 = Seg2 << 3,

            /// <summary>
            /// Identifies the fifth 3-bit group
            /// </summary>
            Seg4 = Seg3 << 3,

            /// <summary>
            /// Identifies the sixth 3-bit group
            /// </summary>
            Seg5 = Seg4 << 3,

            /// <summary>
            /// Identifies the seventh 3-bit group
            /// </summary>
            Seg6 = Seg5 << 3,

            /// <summary>
            /// Identifies the eighth 3-bit group
            /// </summary>
            Seg7 = Seg6 << 3,

            /// <summary>
            /// Selects all bits in an 18-bit segment
            /// </summary>
            Select = Seg0 | Seg1 | Seg2 | Seg3 | Seg4 | Seg5 | Seg6 | Seg7,

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
        /// Identifies most significant bits of bytes in a 24-bit segment
        /// </summary>
        [Flags]
        public enum Msb24x8 : uint
        {            
            /// <summary>
            /// Identifies the most significant bit in the first byte
            /// </summary>
            Byte0 = Seg8x1.Bit7,
            
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
        /// Identifies most significant bits of bytes in a 32-bit segment
        /// </summary>
        [Flags]
        public enum Msb32x8 : uint
        {            
            /// <summary>
            /// Identifies the most significant bit in the first byte
            /// </summary>
            Byte0 = Seg8x1.Bit7,

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
        /// Identifies even bits in a 32-bit segment
        /// </summary>
        [Flags]
        public enum Even32x8 : uint
        {
            /// <summary>
            /// Identifies the even bits in the first byte
            /// </summary>
            Byte0 = Even8x1.Select,
            
            /// <summary>
            /// Identifies the even bits in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Identifies the even bits in the third byte
            /// </summary>
            Byte2 = Byte1 << 8,

            /// <summary>
            /// Identifies the even bits in the fourth byte
            /// </summary>
            Byte3 = Byte2 << 8,

            /// <summary>
            /// Selects the even bits in a 32-bit segment
            /// </summary>
            Select = Byte0 | Byte1 | Byte2 | Byte3
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

        /// <summary>
        /// Identifies most significant bits of bytes in a 64-bit segment
        /// </summary>
        [Flags]
        public enum Msb64x8 : ulong
        {            
            /// <summary>
            /// Identifies the most significant bit in the first byte
            /// </summary>
            Byte0 = Seg8x1.Bit7,

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

        /// <summary>
        /// Identifies even bits in a 64-bit segment
        /// </summary>
        [Flags]
        public enum Even64x8 : ulong
        {
            /// <summary>
            /// Identifies the even bits in the first byte
            /// </summary>
            Byte0 = Even8x1.Select,
            
            /// <summary>
            /// Identifies the even bits in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Identifies the even bits in the third byte
            /// </summary>
            Byte2 = Byte1 << 8,

            /// <summary>
            /// Identifies the even bits in the fourth byte
            /// </summary>
            Byte3 = Byte2 << 8,

            /// <summary>
            /// Identifies the even bits in the fifth byte
            /// </summary>
            Byte4 = Byte3 << 8,

            /// <summary>
            /// Identifies the even bits in the sixth byte
            /// </summary>
            Byte5 = Byte4 << 8,

            /// <summary>
            /// Identifies the even bits in the seventh byte
            /// </summary>
            Byte6 = Byte5 << 8,

            /// <summary>
            /// Identifies the even bits in the eighth byte
            /// </summary>
            Byte7 = Byte6 << 8,

            Select = Byte0 | Byte1 | Byte2 | Byte3 | Byte4 | Byte5 | Byte6 | Byte7
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

            Byte3 = Byte2 << 8,

            Byte4 = Byte3 << 8,

            Byte5 = Byte4 << 8,

            Byte6 = Byte5 << 8,

            Byte7 = Byte6 << 8,

            Select = Byte0 | Byte1 | Byte2 | Byte3 | Byte4 | Byte5 | Byte6 | Byte7
        }
    }



    /// <summary>
    /// Defines common 8-bit masks
    /// </summary>
    [Flags]
    public enum BitMask8 : byte
    {
        /// <summary>
        /// Identifies the most significant bit 
        /// </summary>
        Msb8 = Msb8x1.Select,

        /// <summary>
        /// Identifies the least significant bit 
        /// </summary>
        Lsb8 = Lsb8x1.Select,

        /// <summary>
        /// Identifies every other even bit
        /// </summary>
        Even = Even8x1.Select,

        /// <summary>
        /// Identifies every other odd bit
        /// </summary>
        Odd = Odd8x1.Select,

        /// <summary>
        /// Identifies every bit
        /// </summary>
        Ones = Odd | Even
    }

    /// <summary>
    /// Defines common 16-bit masks
    /// </summary>
    [Flags]
    public enum BitMask16 : ushort
    {
        /// <summary>
        /// Identifies the most significant bit 
        /// </summary>
        Msb8 = Msb16x8.Select,

        /// <summary>
        /// Identifies the least significant bit 
        /// </summary>
        Lsb8 = Lsb16x8.Select,

        /// <summary>
        /// Identifies every other even bit
        /// </summary>
        Even = Even16x8.Select,

        /// <summary>
        /// Identifies every other odd bit
        /// </summary>
        Odd = Odd16x8.Select,

        /// <summary>
        /// Identifies every bit
        /// </summary>
        Ones = Odd | Even
    }


    /// <summary>
    /// Defines common 32-bit masks
    /// </summary>
    [Flags]
    public enum BitMask32 : uint
    {
        /// <summary>
        /// Identifies the most significant bit in each byte
        /// </summary>
        Msb8 = Msb32x8.Select,

        /// <summary>
        /// Identifies the least significant bit in each byte
        /// </summary>
        Lsb8 = Lsb32x8.Select,

        /// <summary>
        /// Identifies every other odd bit
        /// </summary>
        Odd = Odd32x8.Select,

        /// <summary>
        /// Identifies every other even bit
        /// </summary>
        Even = Even32x8.Select,

        /// <summary>
        /// Identifies every bit
        /// </summary>
        Ones = Odd | Even
    }

    /// <summary>
    /// Defines common 64-bit masks
    /// </summary>
    [Flags]
    public enum BitMask64 : ulong
    {
        /// <summary>
        /// Identifies the most significant bit of each byte
        /// </summary>
        Msb8 = Msb64x8.Select,

        /// <summary>
        /// Identifies the least significant bit of each byte
        /// </summary>
        Lsb8 = Lsb64x8.Select,

        /// <summary>
        /// Identifies every other odd bit in a 64-bit segment
        /// </summary>
        Odd = Odd64x8.Select,

        /// <summary>
        /// Identifies every other odd bit in a 64-bit segment
        /// </summary>
        Even = Even64x8.Select,

        /// <summary>
        /// Identifies every bit
        /// </summary>
        Ones = Odd | Even
    }

    public static class BitMaskX
    {
        public static BitVector8 ToBitVector(this BitMask8 src)
            => ((byte)src).ToBitVector();

        public static BitVector16 ToBitVector(this BitMask16 src)
            => ((ushort)src).ToBitVector();

        public static BitVector32 ToBitVector(this BitMask32 src)
            => ((uint)src).ToBitVector();

        public static BitVector64 ToBitVector(this BitMask64 src)
            => ((ulong)src).ToBitVector();


    }
}