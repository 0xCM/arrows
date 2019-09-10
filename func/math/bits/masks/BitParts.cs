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

    /// <summary>
    /// Defines bitwise partition structures and functions
    /// </summary>
    public static class BitParts
    {        

        /// <summary>
        /// Identifies the single bit in a segment with 1 bit
        /// </summary>
        [Flags]
        public enum Part1x1 : byte
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 1,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            Part0 = 0b1,


            Select = Part0,
        }

        /// <summary>
        /// Partitions bits in a 2-bit segment
        /// </summary>
        [Flags]
        public enum Part2x1 : byte
        {                    
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 2,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Part0 = Part1x1.Part0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Selects all bits of a 3-bit segment
            /// </summary>
            Select = Part0 | Part1
        }

        /// <summary>
        /// Partitions bits in a 3-bit segment
        /// </summary>
        [Flags]
        public enum Part3x1 : byte
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 3,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Part0 = Part1x1.Part0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Selects all bits of a 3-bit segment
            /// </summary>
            Select = Part0 | Part1 | Part2
        }

        /// <summary>
        /// Partitions bits in a 4-bit segment
        /// </summary>
        [Flags]
        public enum Part4x1 : byte
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 4,
            
            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Part0 = Part1x1.Part0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth bit
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Selects all bits of a 4-bit segment
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3
        }

        /// <summary>
        /// Paritions a 4-bit container by 2-bit segments as described by
        /// the partition function part(4,2) = [[0,1], [2,3]]
        /// </summary>
        [Flags]
        public enum Part4x2 : byte
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 4,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 2,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 2-bit group
            /// </summary>
            Part0 = Part2x1.Select,

            /// <summary>
            /// Identifies the second 2-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,
            
            /// <summary>
            /// Selects two 2-bit segments
            /// </summary>
            Select = Part0 | Part1,
        }

        /// <summary>
        /// Partitions a 5-bit container by 1-bit segments as described by the
        /// partition function part(5,1) = [{0},{1},...,{4}]
        /// </summary>
        [Flags]
        public enum Part5x1 : byte
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 5,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Part0 = Part1x1.Part0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth bit
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fifth bit
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Selects all bits of a 5-bit segment
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4
        }

        /// <summary>
        /// Partitions a 6-bit container by 1-bit segments as described by the
        /// partition function part(5,1) = [{0},{1},...,{5}]
        /// </summary>
        [Flags]
        public enum Part6x1 : byte
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 6,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Part0 = Part1x1.Part0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth bit
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fifth bit
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth bit
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Selects all bits of a 5-bit segment
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5
        }

        /// <summary>
        /// Partitions a 6-bit container into 3 segments of length 2 as described
        /// by the partition function part(6,2) = [[0,1], [2,3], [4,5]]
        /// </summary>
        [Flags]
        public enum Part6x2 : ushort
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 6,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 2,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 2-bit group
            /// </summary>
            Part0 = Part2x1.Select,

            /// <summary>
            /// Identifies the second 2-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 2-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Selects all 2-bit segments
            /// </summary>
            Select = Part0 | Part1 | Part2
        }


        /// <summary>
        /// Partitions a 6-bit container into 2 segments of length 3 as described
        /// by the partition function part(6,3) = [[0,1,2], [3,4,5]]
        /// </summary>
        [Flags]
        public enum Part6x3 : ushort
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 6,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Selects two 3-bit segments
            /// </summary>
            Select = Part0 | Part1
        }

        /// <summary>
        /// Identifies 1-bit partitions in a byte, thus effecting the partition
        /// p(8,1) = [{0},{1},...,{7}]
        /// </summary>
        [Flags]
        public enum Part8x1 : byte
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 8,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Part0 = Part1x1.Part0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth bit
            /// </summary>
            Part3 = Part2 << (int)Width,            

            /// <summary>
            /// Identifies the fifth bit
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth bit
            /// </summary>
            Part5 = Part4 << (int)Width,            

            /// <summary>
            /// Identifies the seventh bit
            /// </summary>
            Part6 = Part5 << (int)Width,                    
            
            /// <summary>
            /// Identifies the eighth bit
            /// </summary>
            Part7 = Part6 << (int)Width,
            
            /// <summary>
            /// Selects all bits in the partition
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part4 | Part5 | Part6 | Part7
        }

        /// <summary>
        /// Identifies 2-bit segments in a byte thus reifying
        /// the partition part(8,2) = [[0,1], [2,3], [4,5], [6,7]]
        /// </summary>
        [Flags]
        public enum Part8x2 : byte
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 8,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 2,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 2-bit group
            /// </summary>
            Part0 = Part2x1.Select,

            /// <summary>
            /// Identifies the second 2-bit group
            /// </summary>
            Part1 = Part0 << 2,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Part2 = Part1 << 2,

            /// <summary>
            /// Identifies the fourth 3-bit group
            /// </summary>
            Part3 = Part2 << 2,

            /// <summary>
            /// Selects all bits in the partition
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3,
        }

        /// <summary>
        /// Identifies 4-bit segments in a byte thus reifying
        /// the partition part(8,4) = [[0..3], [4..7]]
        /// </summary>
        [Flags]
        public enum Part8x4 : byte
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 8,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 4,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 2-bit group
            /// </summary>
            Part0 = Part4x1.Select,

            /// <summary>
            /// Identifies the second 2-bit group
            /// </summary>
            Part1 = Part0 << 4,

            /// <summary>
            /// Selects all bits in the partition
            /// </summary>
            Select = Part0 | Part1
        }

        /// <summary>
        /// Identifies each bit in a 9-bit group, effecting the partition
        /// p(9,1) = [{0},{1},...,{8}]
        /// </summary>
        [Flags]
        public enum Part9x1 : ushort
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 9,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Part0 = Part1x1.Part0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth bit
            /// </summary>
            Part3 = Part2 << (int)Width,            

            /// <summary>
            /// Identifies the fifth bit
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth bit
            /// </summary>
            Part5 = Part4 << (int)Width,            

            /// <summary>
            /// Identifies the seventh bit
            /// </summary>
            Part6 = Part5 << (int)Width,                    
            
            /// <summary>
            /// Identifies the eighth bit
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Identifies the ninth bit
            /// </summary>
            Part8 = Part7 << (int)Width,
            
            /// <summary>
            /// Selects all bits in the partition
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part4 | Part5 | Part6 | Part7 | Part8

        }

        /// <summary>
        /// Identifies 3-bit segments in a 9-bit container, thus reifying
        /// the partition part(9,3) = [[0..2], [3..5], [6..8]]
        /// </summary>
        [Flags]
        public enum Part9x3 : ushort
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 9,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Selects all bits in the partition
            /// </summary>
            Select = Part0 |  Part1 |  Part2

        }

        /// <summary>
        /// Identifies each bit in a 10-bit group, effecting the partition
        /// p(10,1) = [{0},{1},...,{9}]
        /// </summary>
        [Flags]
        public enum Part10x1 : ushort
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 10,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Part0 = Part1x1.Part0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth bit
            /// </summary>
            Part3 = Part2 << (int)Width,            

            /// <summary>
            /// Identifies the fifth bit
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth bit
            /// </summary>
            Part5 = Part4 << (int)Width,            

            /// <summary>
            /// Identifies the seventh bit
            /// </summary>
            Part6 = Part5 << (int)Width,                    
            
            /// <summary>
            /// Identifies the eighth bit
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Identifies the ninth bit
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Identifies the tenth bit
            /// </summary>
            Part9 = Part8 << (int)Width,

            /// <summary>
            /// Selects all bits of a byte
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part4 | Part5 | Part6 | Part7 | Part8 | Part9
        }

        /// <summary>
        /// Identifies each bit in a 11-bit group, effecting the partition
        /// p(11,1) = [{0},{1},...,{10}]
        /// </summary>
        [Flags]
        public enum Part11x1 : ushort
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 11,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first bit
            /// </summary>
            Part0 = Part1x1.Part0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third bit
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth bit
            /// </summary>
            Part3 = Part2 << (int)Width,            

            /// <summary>
            /// Identifies the fifth bit
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth bit
            /// </summary>
            Part5 = Part4 << (int)Width,            

            /// <summary>
            /// Identifies the seventh bit
            /// </summary>
            Part6 = Part5 << (int)Width,                    
            
            /// <summary>
            /// Identifies the eighth bit
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Identifies the ninth bit
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Identifies the tenth bit
            /// </summary>
            Part9 = Part8 << (int)Width,

            /// <summary>
            /// Identifies the eleventh bit
            /// </summary>
            Part10 = Part9 << (int)Width,

            /// <summary>
            /// Selects all bits in the partition
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part4 | Part5 | Part6 | Part7 | Part8 | Part9 | Part10
        }

        /// <summary>
        /// Identifies each bit in a 12-bit group, effecting the partition
        /// p(12,1) = [{0},{1},...,{11}]
        /// </summary>
        [Flags]
        public enum Part12x1 : ushort
        {
            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 12,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies bit 1
            /// </summary>
            Part0 = Part1x1.Part0,

            /// <summary>
            /// Identifies bit 2
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies bit 3
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies bit 4
            /// </summary>
            Part3 = Part2 << (int)Width,            

            /// <summary>
            /// Identifies tbit 5
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies bit 6
            /// </summary>
            Part5 = Part4 << (int)Width,            

            /// <summary>
            /// Identifies bit 7
            /// </summary>
            Part6 = Part5 << (int)Width,                    
            
            /// <summary>
            /// Identifies bit 8
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Identifies bit 9
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Identifies bit 10
            /// </summary>
            Part9 = Part8 << (int)Width,

            /// <summary>
            /// Identifies bit 11
            /// </summary>
            Part10 = Part9 << (int)Width,

            /// <summary>
            /// Identifies bit 12
            /// </summary>
            Part11 = Part10 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part11,

            /// <summary>
            /// Selects all bits in the partition
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part4 | Part5 | Part6 | Part7 | Part8 | Part9 | Part10 | Part11
        }


        /// <summary>
        /// Identifies 3-bit segments in a 12-bit container thus reifying
        /// the partition part(12,3) = [[0..2], [3..5], [6..8], [9..11]] 
        /// </summary>
        [Flags]
        public enum Part12x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 12,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth 3-bit group
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part3,

            /// <summary>
            /// Selects all bits in the partition
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3
        }

        /// <summary>
        /// Identifies 3-bit segments in a 15-bit container, thus reifying 
        /// the partition part(15,3) = [[0..2], [3..5], [6..8], [9..11], [12..14]]
        /// </summary>
        [Flags]
        public enum Part15x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 15,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth 3-bit group
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fifth 3-bit group
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part4,

            /// <summary>
            /// Selects all bits in the partition
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4
        }

        /// <summary>
        /// Identifies 4-bit segments in a 16-bit container, thus reifying
        /// the partition part(16,4) = [[0..3], [4..7], [8..11], [12..15]]
        /// </summary>
        [Flags]
        public enum Part16x4 : ushort
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 16,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 4,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 4-bit group
            /// </summary>
            Part0 = Part4x1.Select,

            /// <summary>
            /// Identifies the second 4-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 4-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth four bits
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part3,


            /// <summary>
            /// Selects the four groups of four bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3

        }

        /// <summary>
        /// Identifies 3-bit segments in a 15-bit container, thus reifying 
        /// the partition part(15,3) = [[0..2], [3..5], [6..8], [9..11], [12..14], [15..17]]
        /// </summary>
        [Flags]
        public enum Part18x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 18,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth 3-bit group
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fifth 3-bit group
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth 3-bit group
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part5,

            /// <summary>
            /// Selects all bits in an 18-bit segment
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5,
        }

        /// <summary>
        /// Identifies five segments of length four in a 20 bit segment
        /// </summary>
        [Flags]
        public enum Part20x4 : uint
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 20,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 4,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 4-bit group
            /// </summary>
            Part0 = Part4x1.Select,

            /// <summary>
            /// Identifies the second 4-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 4-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth four bits
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fourth four bits
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part4,


            /// <summary>
            /// Selects the five groups of four bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4

        }

        /// <summary>
        /// Identifies segments of length three in an 21-bit segment
        /// </summary>
        [Flags]
        public enum Part21x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 21,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth 3-bit group
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fifth 3-bit group
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth 3-bit group
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies the seventh 3-bit group
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part6,

            /// <summary>
            /// Selects all bits in an 21-bit segment
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6,
        }


        /// <summary>
        /// Identifies segments of length three in an 24-bit segment
        /// </summary>
        [Flags]
        public enum Part24x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 24,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth 3-bit group
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fifth 3-bit group
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth 3-bit group
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies the seventh 3-bit group
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Identifies the eighth 3-bit group
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part7,

            /// <summary>
            /// Selects all bits in a 24-bit segment
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7,

        }

        /// <summary>
        /// Identifies blocks of length four in an 24-bit segment
        /// </summary>
        [Flags]
        public enum Part24x4 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 24,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 4,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 4-bit group
            /// </summary>
            Part0 = Part4x1.Select,

            /// <summary>
            /// Identifies the second 4-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 4-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth 4-bit group
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fifth 4-bit group
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth 4-bit group
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part5,

            /// <summary>
            /// Selects all bits in a 24-bit segment
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5

        }

        /// <summary>
        /// Identifies blocks of length 6 in an 24-bit segment
        /// </summary>
        [Flags]
        public enum Part24x6 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 24,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 6,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 6-bit group
            /// </summary>
            Part0 = Part6x1.Select,

            /// <summary>
            /// Identifies the second 6-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 6-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth 6-bit group
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part3,

            /// <summary>
            /// Selects all bits in a 24-bit segment
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3

        }

        /// <summary>
        /// Identifies blocks of length 8 in an 24-bit segment
        /// </summary>
        [Flags]
        public enum Part24x8 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 24,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 8,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 8-bit group
            /// </summary>
            Part0 = Part6x1.Select,

            /// <summary>
            /// Identifies the second 8-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 8-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part2,

            /// <summary>
            /// Selects all bits in a 24-bit segment
            /// </summary>
            Select = Part0 | Part1 | Part2
        }

        /// <summary>
        /// Identifies blocks of length 12 in an 24-bit segment
        /// </summary>
        [Flags]
        public enum Part24x12 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 24,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 12,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 8-bit group
            /// </summary>
            Part0 = Part12x1.Select,

            /// <summary>
            /// Identifies the second 8-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part1,

            /// <summary>
            /// Selects all bits in a 24-bit segment
            /// </summary>
            Select = Part0 | Part1

        }


        /// <summary>
        /// Identifies segments of length three in an 27-bit segment
        /// </summary>
        [Flags]
        public enum Part27x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 27,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth 3-bit group
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fifth 3-bit group
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth 3-bit group
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies the seventh 3-bit group
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Identifies the eighth 3-bit group
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Identifies the ninth 3-bit group
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part8,

            /// <summary>
            /// Selects all bits in an 27-bit segment
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7 | Part8,
        }

       /// <summary>
       /// Partitions a 30-bit container into 10 segments of length 3 as described
       /// by the partition function part(30,3) = [[0,1,2], ..., [27,28,29]]
       /// </summary>
        [Flags]
        public enum Part30x3 : uint
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 30,

            /// <summary>
            /// The width of each segment
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth 3-bit group
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fifth 3-bit group
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth 3-bit group
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies the seventh 3-bit group
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Identifies the eighth 3-bit group
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Identifies the ninth 3-bit group
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Identifies the tenth 3-bit group
            /// </summary>
            Part9 = Part8 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part9,

            /// <summary>
            /// Selects all bits in an 30-bit segment
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7 | Part8 | Part9,
        }

        /// <summary>
        /// Partitions a 64-bit container into 8 segments of length 8 as described
        /// by the partition function part(64,8) = [[0..7], .., [56..63]]
        /// </summary>
        [Flags]
        public enum Part64x8 : ulong
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 64,

            /// <summary>
            /// The width of each segment
            /// </summary>
            Width = 8,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 8-bit group
            /// </summary>
            Part0 = Part8x1.Select,

            /// <summary>
            /// Identifies the second 8-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 8-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth 8-bit group
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fifth 8-bit group
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth 8-bit group
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies the seventh 8-bit group
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Identifies the eighth 8-bit group
            /// </summary>
            Part7 = Part6 << (int)Width,
            
            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part7,

            /// <summary>
            /// Selects all bits in the partition
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7

        }
    }


}