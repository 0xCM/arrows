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

    partial class BitParts
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
            
            /// <summary>
            /// Identifies the first and only bit in th partition
            /// </summary>
            Part0 = 0b1,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0,
        }

        /// <summary>
        /// Partitions a 2-bit container into 1-bit segments
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
            /// Specifies the first partition
            /// </summary>
            Part0 = Part1x1.Part0,

            /// <summary>
            /// Identifies the second bit
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1
        }


        /// <summary>
        /// Partitions a 3 bit containter into 1-bit segments
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
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part2,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2
        }

        /// <summary>
        /// Partitions a 4 bit containter into 1-bit segments
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
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part3,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3
        }

        /// <summary>
        /// Partitions a 5-bit container into 1-bit segments
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
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part4,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2  | Part3  | Part4
        }



        /// <summary>
        /// Partitions a 6-bit container into 1-bit segments
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
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part5,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2  | Part3  | Part4  | Part5
        }

        /// <summary>
        /// Partitions an 8-bit container into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part7x1 : byte
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 7,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part1x1.Part0,

            /// <summary>
            /// Specifies partition 2
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Specifies partition 3
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Specifies partition 4
            /// </summary>
            Part3 = Part2 << (int)Width,            

            /// <summary>
            /// Specifies partition 5
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Specifies partition 6
            /// </summary>
            Part5 = Part4 << (int)Width,            

            /// <summary>
            /// Specifies partition 7
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
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2  | Part3  | Part4  | Part5  | Part6
        }

        /// <summary>
        /// Partitions an 8-bit container into 1-bit segments
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
            /// Specifies partition 1
            /// </summary>
            Part0 = Part1x1.Part0,

            /// <summary>
            /// Specifies partition 2
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Specifies partition 3
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Specifies partition 4
            /// </summary>
            Part3 = Part2 << (int)Width,            

            /// <summary>
            /// Specifies partition 5
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Specifies partition 6
            /// </summary>
            Part5 = Part4 << (int)Width,            

            /// <summary>
            /// Specifies partition 7
            /// </summary>
            Part6 = Part5 << (int)Width,                    
            
            /// <summary>
            /// Specifies partition 8
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
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2  | Part3  | Part4  | Part5  | Part6  | Part7 
        }

        /// <summary>
        /// Partitions a 9-bit container into 1-bit segments
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
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part8,

            
            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2  | Part3  | Part4  | Part5  | Part6  | Part7 
                   | Part8

        }

        /// <summary>
        /// Partitions an 10-bit container into 1-bit segments
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
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part9,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2  | Part3  | Part4  | Part5  | Part6  | Part7 
                   | Part8 | Part9
        }
        

        /// <summary>
        /// Partitions an 11-bit container into 1-bit segments
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
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2  | Part3  | Part4  | Part5  | Part6  | Part7 
                   | Part8 | Part9 | Part10 
        }

        /// <summary>
        /// Partitions a 12-bit container into 1-bit segments
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
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2  | Part3  | Part4  | Part5  | Part6  | Part7 
                   | Part8 | Part9 | Part10 | Part11
        }

        /// <summary>
        /// Partitions a 13-bit container into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part13x1 : ushort
        {
            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 13,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies bit 0
            /// </summary>
            Part0 = Part1x1.Part0,

            /// <summary>
            /// Identifies bit 1
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies bit 2
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies bit 3
            /// </summary>
            Part3 = Part2 << (int)Width,            

            /// <summary>
            /// Identifies tbit 4
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies bit 5
            /// </summary>
            Part5 = Part4 << (int)Width,            

            /// <summary>
            /// Identifies bit 6
            /// </summary>
            Part6 = Part5 << (int)Width,                    
            
            /// <summary>
            /// Identifies bit 7
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Identifies bit 8
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Identifies bit 9
            /// </summary>
            Part9 = Part8 << (int)Width,

            /// <summary>
            /// Identifies bit 10
            /// </summary>
            Part10 = Part9 << (int)Width,

            /// <summary>
            /// Identifies bit 11
            /// </summary>
            Part11 = Part10 << (int)Width,

            /// <summary>
            /// Identifies bit 12
            /// </summary>
            Part12 = Part11 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part12,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2  | Part3  | Part4  | Part5  | Part6  | Part7 
                   | Part8 | Part9 | Part10 | Part11 | Part12
        }


        /// <summary>
        /// Partitions a 16-bit container into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part16x1 : ushort
        {
            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 16,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies bit 0
            /// </summary>
            Part0 = Part1x1.Part0,

            /// <summary>
            /// Identifies bit 1
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies bit 2
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies bit 3
            /// </summary>
            Part3 = Part2 << (int)Width,            

            /// <summary>
            /// Identifies tbit 4
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies bit 5
            /// </summary>
            Part5 = Part4 << (int)Width,            

            /// <summary>
            /// Identifies bit 6
            /// </summary>
            Part6 = Part5 << (int)Width,                    
            
            /// <summary>
            /// Identifies bit 7
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Identifies bit 8
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Identifies bit 9
            /// </summary>
            Part9 = Part8 << (int)Width,

            /// <summary>
            /// Identifies bit 10
            /// </summary>
            Part10 = Part9 << (int)Width,

            /// <summary>
            /// Identifies bit 11
            /// </summary>
            Part11 = Part10 << (int)Width,

            /// <summary>
            /// Identifies bit 12
            /// </summary>
            Part12 = Part11 << (int)Width,

            /// <summary>
            /// Identifies bit 13
            /// </summary>
            Part13 = Part12 << (int)Width,

            /// <summary>
            /// Identifies bit 14
            /// </summary>
            Part14 = Part13 << (int)Width,

            /// <summary>
            /// Identifies bit 15
            /// </summary>
            Part15 = Part14 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part15,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2  | Part3  | Part4  | Part5  | Part6  | Part7 
                   | Part8 | Part9 | Part10 | Part11 | Part12 | Part13 | Part14 | Part15
        }

 
        /// <summary>
        /// Partitions a 32-bit container into 1-bit segments
        /// </summary>
        [Flags]
        public enum Part32x1 : uint
        {
            /// <summary>
            /// The partition width
            /// </summary>
            Width = 1,

            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 32,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies bit 0
            /// </summary>
            Part0 = Part1x1.Part0,

            /// <summary>
            /// Identifies bit 1
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies bit 2
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies bit 3
            /// </summary>
            Part3 = Part2 << (int)Width,            

            /// <summary>
            /// Identifies tbit 4
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies bit 5
            /// </summary>
            Part5 = Part4 << (int)Width,            

            /// <summary>
            /// Identifies bit 6
            /// </summary>
            Part6 = Part5 << (int)Width,                    
            
            /// <summary>
            /// Identifies bit 7
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Identifies bit 8
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Identifies bit 9
            /// </summary>
            Part9 = Part8 << (int)Width,

            /// <summary>
            /// Identifies bit 10
            /// </summary>
            Part10 = Part9 << (int)Width,

            /// <summary>
            /// Identifies bit 11
            /// </summary>
            Part11 = Part10 << (int)Width,

            /// <summary>
            /// Identifies bit 12
            /// </summary>
            Part12 = Part11 << (int)Width,

            /// <summary>
            /// Identifies bit 13
            /// </summary>
            Part13 = Part12 << (int)Width,

            /// <summary>
            /// Identifies bit 14
            /// </summary>
            Part14 = Part13 << (int)Width,

            /// <summary>
            /// Identifies bit 15
            /// </summary>
            Part15 = Part14 << (int)Width,

            /// <summary>
            /// Identifies bit 16
            /// </summary>
            Part16 = Part15 << (int)Width,

            /// <summary>
            /// Identifies bit 17
            /// </summary>
            Part17 = Part16 << (int)Width,

            /// <summary>
            /// Identifies bit 18
            /// </summary>
            Part18 = Part17 << (int)Width,

            /// <summary>
            /// Identifies bit 19
            /// </summary>
            Part19 = Part18 << (int)Width,            

            /// <summary>
            /// Identifies tbit 20
            /// </summary>
            Part20 = Part19 << (int)Width,

            /// <summary>
            /// Identifies bit 21
            /// </summary>
            Part21 = Part20 << (int)Width,            

            /// <summary>
            /// Identifies bit 22
            /// </summary>
            Part22 = Part21 << (int)Width,                    
            
            /// <summary>
            /// Identifies bit 23
            /// </summary>
            Part23 = Part22 << (int)Width,

            /// <summary>
            /// Identifies bit 24
            /// </summary>
            Part24 = Part23 << (int)Width,

            /// <summary>
            /// Identifies bit 25
            /// </summary>
            Part25 = Part24 << (int)Width,

            /// <summary>
            /// Identifies bit 26
            /// </summary>
            Part26 = Part25 << (int)Width,

            /// <summary>
            /// Identifies bit 27
            /// </summary>
            Part27 = Part26 << (int)Width,

            /// <summary>
            /// Identifies bit 28
            /// </summary>
            Part28 = Part27 << (int)Width,

            /// <summary>
            /// Identifies bit 29
            /// </summary>
            Part29 = Part28 << (int)Width,

            /// <summary>
            /// Identifies bit 30
            /// </summary>
            Part30 = Part29 << (int)Width,

            /// <summary>
            /// Identifies bit 31
            /// </summary>
            Part31 = Part30 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part31,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0  | Part1  | Part2  | Part3  | Part4  | Part5  | Part6  | Part7 
                   | Part8  | Part9  | Part10 | Part11 | Part12 | Part13 | Part14 | Part15
                   | Part16 | Part17 | Part18 | Part19 | Part20 | Part21 | Part22 | Part23
                   | Part24 | Part25 | Part16 | Part27 | Part28 | Part29 | Part30 | Part31
        }
    }
}