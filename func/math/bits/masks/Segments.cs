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

    public static partial class BitMasks
    {        

        /// <summary>
        /// Identifies a bit in a 1-bit segment
        /// </summary>
        public enum Seg1x1 : byte
        {
            Bit0 = 0b1
        }

        /// <summary>
        /// Identifies the bits in a 2-bit segment
        /// </summary>
        [Flags]
        public enum Seg2x1 : byte
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
            /// Selects all bits of a 3-bit segment
            /// </summary>
            Select = Bit0 | Bit1
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
        /// Identifies 2-bit segments in a 4-bit container thus reifying
        /// the partition part(4,2) = [[0,1], [2,3]]
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
        /// Identifies each bit in a 5-bit container, effecting the partition
        /// part(5,1) = [{0},{1},...,{4}]
        /// </summary>
        [Flags]
        public enum Seg5x1 : byte
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
            /// Selects all bits of a 5-bit segment
            /// </summary>
            Select = Bit0 | Bit1 | Bit2 | Bit3 | Bit4
        }

        /// <summary>
        /// Identifies each bit in a 6-bit container, effecting the partition
        /// part(5,1) = [{0},{1},...,{4},{5}]
        /// </summary>
        [Flags]
        public enum Seg6x1 : byte
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
            /// Selects all bits of a 5-bit segment
            /// </summary>
            Select = Bit0 | Bit1 | Bit2 | Bit3 | Bit4 | Bit5
        }

        /// <summary>
        /// Identifies 3-bit segments in a 6-bit container, thus reifying
        /// the partition part(6,3) = [[0,1], [2,3] [4,5]]
        /// </summary>
        public enum Seg6x2 : ushort
        {
            /// <summary>
            /// Identifies the first 2-bit group
            /// </summary>
            Seg0 = Seg2x1.Select,

            /// <summary>
            /// Identifies the second 2-bit group
            /// </summary>
            Seg1 = Seg0 << 2,

            /// <summary>
            /// Identifies the third 2-bit group
            /// </summary>
            Seg2 = Seg1 << 2,

            /// <summary>
            /// Selects all 2-bit segments
            /// </summary>
            Select = Seg0 | Seg1 | Seg2
        }


        /// <summary>
        /// Identifies 3-bit segments in a 6-bit container, thus reifying
        /// the partition part(6,3) = [[0..2], [3..5]]
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
        /// Identifies each bit in a byte, effecting the partition
        /// p(8,1) = [{0},{1},...,{7}]
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
            /// Selects all bits from the container
            /// </summary>
            Select = Bit0 | Bit1 | Bit2 | Bit4 | Bit5 | Bit6 | Bit7
        }

        /// <summary>
        /// Identifies 2-bit segments in a byte thus reifying
        /// the partition part(8,2) = [[0,1], [2,3], [4,5], [6,7]]
        /// </summary>
        [Flags]
        public enum Seg8x2 : byte
        {            
            /// <summary>
            /// Identifies the first 2-bit group
            /// </summary>
            Seg0 = Seg2x1.Select,

            /// <summary>
            /// Identifies the second 2-bit group
            /// </summary>
            Seg1 = Seg0 << 2,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Seg2 = Seg1 << 2,

            /// <summary>
            /// Identifies the fourth 3-bit group
            /// </summary>
            Seg3 = Seg2 << 2,

            /// <summary>
            /// Selects all 2-bit segments from the container
            /// </summary>
            Select = Seg0 | Seg1 | Seg2 | Seg3,
        }

        /// <summary>
        /// Identifies 4-bit segments in a byte thus reifying
        /// the partition part(8,4) = [[0..3], [4..7]]
        /// </summary>
        [Flags]
        public enum Seg8x4 : byte
        {            
            /// <summary>
            /// Identifies the first 2-bit group
            /// </summary>
            Seg0 = Seg4x1.Select,

            /// <summary>
            /// Identifies the second 2-bit group
            /// </summary>
            Seg1 = Seg0 << 2,

            /// <summary>
            /// Selects all 2-bit segments from the container
            /// </summary>
            Select = Seg0 | Seg1
        }


        /// <summary>
        /// Identifies each bit in a 9-bit group, effecting the partition
        /// p(9,1) = [{0},{1},...,{8}]
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
        /// Identifies 3-bit segments in a 9-bit container, thus reifying
        /// the partition part(9,3) = [[0..2], [3..5], [6..8]]
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

            /// <summary>
            /// Selects the three groups of three bits
            /// </summary>
            Select = Seg0 |  Seg1 |  Seg2

        }

        /// <summary>
        /// Identifies each bit in a 10-bit group, effecting the partition
        /// p(10,1) = [{0},{1},...,{9}]
        /// </summary>
        [Flags]
        public enum Seg10x1 : ushort
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
            /// Identifies the ninth bit
            /// </summary>
            Bit9 = Bit8 << 1,

            /// <summary>
            /// Selects all bits of a byte
            /// </summary>
            Select = Bit0 | Bit1 | Bit2 | Bit4 | Bit5 | Bit6 | Bit7 | Bit8 | Bit9
        }

        /// <summary>
        /// Identifies 3-bit segments in a 12-bit container thus reifying
        /// the partition part(12,3) = [[0..2], [3..5], [6..8], [9..11]] 
        /// </summary>
        public enum Seg12x3 : uint
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
            /// Selects all bits in an 18-bit segment
            /// </summary>
            Select = Seg0 | Seg1 | Seg2 | Seg3
        }

        /// <summary>
        /// Identifies 3-bit segments in a 15-bit container, thus reifying 
        /// the partition part(15,3) = [[0..2], [3..5], [6..8], [9..11], [12..14]]
        /// </summary>
        public enum Seg15x3 : uint
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
            /// Selects all bits in an 18-bit segment
            /// </summary>
            Select = Seg0 | Seg1 | Seg2 | Seg3 | Seg4
        }

        /// <summary>
        /// Identifies 4-bit segments in a 16-bit container, thus reifying
        /// the partition part(16,4) = [[0..3], [4..7], [8..11], [12..15]]
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
            /// Selects the four groups of four bits
            /// </summary>
            Select = Seg0 | Seg1 | Seg2 | Seg3

        }

        /// <summary>
        /// Identifies 3-bit segments in a 15-bit container, thus reifying 
        /// the partition part(15,3) = [[0..2], [3..5], [6..8], [9..11], [12..14], [15..17]]
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
        /// Identifies five segments of length four in a 20 bit segment
        /// </summary>
        [Flags]
        public enum Seg20x4 : uint
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
            /// Identifies the fourth four bits
            /// </summary>
            Seg4 = Seg3 << 4,

            /// <summary>
            /// Selects the five groups of four bits
            /// </summary>
            Select = Seg0 | Seg1 | Seg2 | Seg3 | Seg4

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
            /// Selects all bits in an 21-bit segment
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
            /// Selects all bits in a 24-bit segment
            /// </summary>
            Select = Seg0 | Seg1 | Seg2 | Seg3 | Seg4 | Seg5 | Seg6 | Seg7,

        }

        /// <summary>
        /// Identifies segments of length three in an 27-bit segment
        /// </summary>
        public enum Seg27x3 : uint
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
            /// Identifies the ninth 3-bit group
            /// </summary>
            Seg8 = Seg7 << 3,

            /// <summary>
            /// Selects all bits in an 27-bit segment
            /// </summary>
            Select = Seg0 | Seg1 | Seg2 | Seg3 | Seg4 | Seg5 | Seg6 | Seg7 | Seg8,
        }

        /// <summary>
        /// Identifies segments of length three in an 30-bit segment
        /// </summary>
        public enum Seg30x3 : uint
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
            /// Identifies the ninth 3-bit group
            /// </summary>
            Seg8 = Seg7 << 3,

            /// <summary>
            /// Identifies the tenth 3-bit group
            /// </summary>
            Seg9 = Seg8 << 3,

            /// <summary>
            /// Selects all bits in an 30-bit segment
            /// </summary>
            Select = Seg0 | Seg1 | Seg2 | Seg3 | Seg4 | Seg5 | Seg6 | Seg7 | Seg8,
        }


    }

}