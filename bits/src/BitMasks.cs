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
        /// Identifies the lo bit out of two
        /// </summary>
        [Flags]
        public enum Lsb2x1 : byte
        {
            Select = 0b1

        }

        /// <summary>
        /// Identifies the hi bit out of two
        /// </summary>
        [Flags]
        public enum Msb2x1 : byte
        {

            Select = 0b10

        }

        /// <summary>
        /// Identifies the least significant bit in a nibble
        /// </summary>
        [Flags]
        public enum Lsb4x1 : byte
        {

            Select = 0b01

        }

        /// <summary>
        /// Identifies the most significant bit in a nibble
        /// </summary>
        [Flags]
        public enum Msb4x1 : byte
        {

            Select = 0b1000,

        }
        
        /// <summary>
        /// Identifies the most significant bit in a byte
        /// </summary>
        [Flags]
        public enum Lsb8x1 : byte
        {            
            Select = 0b1

        }

        /// <summary>
        /// Identifies the most significant bit in a byte
        /// </summary>
        [Flags]
        public enum Msb8x1 : byte
        {            
            
            Select = 0b10000000

        }

        /// <summary>
        /// Identifies the odd bits in a byte
        /// </summary>
        [Flags]
        public enum Odd8x1 : byte
        {
            /// <summary>
            /// Identifies the 1'st bit
            /// </summary>
            Bit1 = 0b00000010,
            
            /// <summary>
            /// Identifies the 3'rd bit
            /// </summary>
            Bit3 = Bit1 << 2,            
            
            /// <summary>
            /// Identifies the 5'th bit
            /// </summary>
            Bit5 = Bit3 << 2,            
            
            /// <summary>
            /// Identifies the 7'th bit
            /// </summary>
            Bit7 = Bit5 << 2,
            
            /// <summary>
            /// Selects the odd bits
            /// </summary>
            Select = Bit1 |  Bit3 |  Bit5 |  Bit7

        }

        /// <summary>
        /// Identifies the even bits in a byte
        /// </summary>
        [Flags]
        public enum Even8x1 : byte
        {
            /// <summary>
            /// Identifies the 0 bit
            /// </summary>
            Bit0 = 0b00000001,
            
            /// <summary>
            /// Identifies the 2'nd bit
            /// </summary>
            Bit2 = Bit0 << 2,
                        
            /// <summary>
            /// Identifies the 4'th bit
            /// </summary>
            Bit4 = Bit2 << 2,
                        
            /// <summary>
            /// Identifies the 6'th bit
            /// </summary>
            Bit6 = Bit4 << 2,
                        
            /// <summary>
            /// Selects the even bits
            /// </summary>
            Select = Bit0 |  Bit2 |  Bit4 | Bit6 

        }


        /// <summary>
        /// Identifies the least significant bit of each byte of a 16-bit segment
        /// </summary>
        [Flags]
        public enum Lsb16x8 : ushort
        {            
            Byte0 = Lsb8x1.Select,
            
            Byte1 = Byte0 << 8,            

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
            
            Byte0 = Msb8x1.Select,
            
            Byte1 = Byte0 << 8,            

            Select = Byte0 | Byte1

        }

        /// <summary>
        /// Identifies the most significant bit of each nibble of a 16-bit segment
        /// </summary>
        [Flags]
        public enum Msb16x4 : ushort
        {            
            Nib0 = Msb4x1.Select,
            
            Nib1 = Nib0 << 4,            

            Nib2 = Nib1 << 4,

            Nib3 = Nib2 << 4,

            Select = Nib0 | Nib1 | Nib2 | Nib3

        }

        /// <summary>
        /// Identifies every other even bit in a 16-bit segment
        /// </summary>
        [Flags]
        public enum Even16x8 : ushort
        {
            Byte0 = Even8x1.Select,
            
            Byte1 = Byte0 << 8,

            Select = Byte0 | Byte1
        }

        /// <summary>
        /// Identifies every other odd bit in a 16-bit segment
        /// </summary>
        [Flags]
        public enum Odd16x8 : ushort
        {
            Byte0 = Odd8x1.Select,
            
            Byte1 = Byte0 << 8,

            Select = Byte0 | Byte1
        }

        [Flags]
        public enum Lsb24x8 : uint
        {
            
            Byte0 = 0b00000001,
            
            Byte1 = Byte0 << 8,

            Byte2 = Byte1 << 8,

            Select = Byte0 | Byte1 | Byte2

        }

        [Flags]
        public enum Msb24x8 : uint
        {            
            Byte0 = 0b10000000,
            
            Byte1 = Byte0 << 8,

            Byte2 = Byte1 << 8,

            Select = Byte0 | Byte1 | Byte2

        }

        [Flags]
        public enum Lsb32x8 : uint
        {            
            Byte0 = 0b00000001,

            Byte1 = Byte0 << 8,

            Byte2 = Byte1 << 8,

            Byte3 = Byte2 << 8,

            Select = Byte0 | Byte1 | Byte2 | Byte3

        }

        [Flags]
        public enum Msb32x8 : uint
        {            
            Byte0 = 0b10000000,

            Byte1 = Byte0 << 8,

            Byte2 = Byte1 << 8,

            Byte3 = Byte2 << 8,

            Select = Byte0 | Byte1 | Byte2 | Byte3

        }

        /// <summary>
        /// Identifies every other even bit in a 32-bit segment
        /// </summary>
        [Flags]
        public enum Even32x8 : uint
        {
            Byte0 = Even16x8.Select,
            
            Byte1 = Byte0 << 8,

            Byte2 = Byte1 << 8,

            Byte3 = Byte2 << 8,

            Select = Byte0 | Byte1 | Byte2 | Byte3
        }

        /// <summary>
        /// Identifies every other odd bit in a 32-bit segment
        /// </summary>
        [Flags]
        public enum Odd32x8 : uint
        {
            Byte0 = Odd16x8.Select,
            
            Byte1 = Byte0 << 8,

            Byte2 = Byte1 << 8,

            Byte3 = Byte2 << 8,

            Select = Byte0 | Byte1 | Byte2 | Byte3
        }

        [Flags]
        public enum Lsb64x8 : ulong
        {            
            Byte0 = 0b00000001,

            Byte1 = Byte0 << 8,

            Byte2 = Byte1 << 8,

            Byte3 = Byte2 << 8,

            Byte4 = Byte3 << 8,

            Byte5 = Byte4 << 8,

            Byte6 = Byte5 << 8,

            Byte7 = Byte6 << 8,

            Select = Byte0 | Byte1 | Byte2 | Byte3 | Byte4 | Byte5 | Byte6 | Byte7

        }

        [Flags]
        public enum Msb64x8 : ulong
        {            
            Byte0 = 0b10000000,

            Byte1 = Byte0 << 8,

            Byte2 = Byte1 << 8,

            Byte3 = Byte2 << 8,

            Byte4 = Byte3 << 8,

            Byte5 = Byte4 << 8,

            Byte6 = Byte5 << 8,

            Byte7 = Byte6 << 8,

            Select = Byte0 | Byte1 | Byte2 | Byte3 | Byte4 | Byte5 | Byte6 | Byte7

        }

        /// <summary>
        /// Identifies every other even bit in a 64-bit segment
        /// </summary>
        [Flags]
        public enum Even64x8 : ulong
        {
            Byte0 = Even32x8.Select,
            
            Byte1 = Byte0 << 8,

            Byte2 = Byte1 << 8,

            Byte3 = Byte2 << 8,

            Byte4 = Byte3 << 8,

            Byte5 = Byte4 << 8,

            Byte6 = Byte5 << 8,

            Byte7 = Byte6 << 8,

            Select = Byte0 | Byte1 | Byte2 | Byte3 | Byte4 | Byte5 | Byte6 | Byte7
        }

        /// <summary>
        /// Identifies every other odd bit in a 64-bit segment
        /// </summary>
        [Flags]
        public enum Odd64x8 : ulong
        {
            Byte0 = Odd32x8.Select,
            
            Byte1 = Byte0 << 8,

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

}