//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    /// <summary>
    /// Represents 15 bits with 15 8-bit values that may range over {0,1}
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size=15)]
    public struct BitBlock15 : IBitBlock
    {
        /// <summary>
        ///  Bit 0
        /// </summary>
        [FieldOffset(0)]
        public byte Bit0;

        /// <summary>
        ///  Bit 1
        /// </summary>
        [FieldOffset(1)]
        public byte Bit1;

        /// <summary>
        ///  Bit 2
        /// </summary>
        [FieldOffset(2)]
        public byte Bit2;

        /// <summary>
        ///  Bit 2
        /// </summary>
        [FieldOffset(3)]
        public byte Bit3;
        
        /// <summary>
        ///  Bit 4
        /// </summary>
        [FieldOffset(4)]
        public byte Bit4;

        /// <summary>
        ///  Bit 5
        /// </summary>
        [FieldOffset(5)]
        public byte Bit5;

        /// <summary>
        ///  Bit 6
        /// </summary>
        [FieldOffset(6)]
        public byte Bit6;

        /// <summary>
        ///  Bit 7
        /// </summary>
        [FieldOffset(7)]
        public byte Bit7;

        /// <summary>
        ///  Bit 8
        /// </summary>
        [FieldOffset(8)]
        public byte Bit8;

        /// <summary>
        ///  Bit 9
        /// </summary>
        [FieldOffset(9)]
        public byte Bit9;

        /// <summary>
        ///  Bit 9
        /// </summary>
        [FieldOffset(10)]
        public byte Bit10;

        /// <summary>
        ///  Bit 11
        /// </summary>
        [FieldOffset(11)]
        public byte Bit11;

        /// <summary>
        ///  Bit 12
        /// </summary>
        [FieldOffset(12)]
        public byte Bit12;

        /// <summary>
        ///  Bit 13
        /// </summary>
        [FieldOffset(13)]
        public byte Bit13;

        /// <summary>
        ///  Bit 14
        /// </summary>
        [FieldOffset(14)]
        public byte Bit14;

        /// <summary>
        /// Block 0 of width 3
        /// </summary>
        [FieldOffset(0)]
        public BitBlock3 Block3x0;

        /// <summary>
        /// Block 1 of width 3
        /// </summary>
        [FieldOffset(3)]
        public BitBlock3 Block3x1;

        /// <summary>
        /// Block 2 of width 3
        /// </summary>
        [FieldOffset(6)]
        public BitBlock3 Block3x2;

        /// <summary>
        /// Block 3 of width 3
        /// </summary>
        [FieldOffset(9)]
        public BitBlock3 Block3x3;

        /// <summary>
        /// Block 4 of width 3
        /// </summary>
        [FieldOffset(12)]
        public BitBlock3 Block3x4;

        /// <summary>
        /// Block 0 of width 5
        /// </summary>
        [FieldOffset(0)]
        public BitBlock5 Block5x0;    

        /// <summary>
        /// Block 1 of width 5
        /// </summary>
        [FieldOffset(5)]
        public BitBlock5 Block5x1;    

        /// <summary>
        /// Block 2 of width 5
        /// </summary>
        [FieldOffset(10)]
        public BitBlock5 Block5x2;    


        [MethodImpl(Inline)]
        public byte GetPart(int i)
            => Unsafe.Add(ref Unsafe.As<BitBlock15, byte>(ref this), i);

        [MethodImpl(Inline)]
        public void SetPart(int i, byte value)
            => Unsafe.Add(ref Unsafe.As<BitBlock15, byte>(ref this), i) = value;
        
        public byte this [int i]
        {
            [MethodImpl(Inline)]
            get => GetPart(i);
            
            [MethodImpl(Inline)]
            set => SetPart(i,value);
        }

        public string Format()
            => BitBlock.AsGeneric(ref this).Format();

        public override string ToString() 
            => Format();

    }

}