//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    /// <summary>
    /// Represents 20 bits with 20 8-bit values that may range over {0,1}
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size=20)]
    public struct BitBlock20 : IBitBlock
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
        ///  Bit 10
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
        ///  Bit 15
        /// </summary>
        [FieldOffset(15)]
        public byte Bit15;

        /// <summary>
        ///  Bit 16
        /// </summary>
        [FieldOffset(16)]
        public byte Bit16;

        /// <summary>
        ///  Bit 17
        /// </summary>
        [FieldOffset(17)]
        public byte Bit17;

        /// <summary>
        ///  Bit 18
        /// </summary>
        [FieldOffset(18)]
        public byte Bit18;

        /// <summary>
        ///  Bit 19
        /// </summary>
        [FieldOffset(19)]
        public byte Bit19;

         /// <summary>
        /// Block 0 of width 2
        /// </summary>
        [FieldOffset(0)]
        public BitBlock2 Block2x0;

        /// <summary>
        /// Block 1 of width 2
        /// </summary>
        [FieldOffset(2)]
        public BitBlock2 Block2x1;    

        /// <summary>
        /// Block 2 of width 2
        /// </summary>
        [FieldOffset(4)]
        public BitBlock2 Block2x2;    

        /// <summary>
        /// Block 3 of width 2
        /// </summary>
        [FieldOffset(6)]
        public BitBlock2 Block2x3;    

        /// <summary>
        /// Block 4 of width 2
        /// </summary>
        [FieldOffset(8)]
        public BitBlock2 Block2x4;    

        /// <summary>
        /// Block 5 of width 2
        /// </summary>
        [FieldOffset(10)]
        public BitBlock2 Block2x5;    

        /// <summary>
        /// Block 6 of width 2
        /// </summary>
        [FieldOffset(12)]
        public BitBlock2 Block2x6;    

        /// <summary>
        /// Block 7 of width 2
        /// </summary>
        [FieldOffset(14)]
        public BitBlock2 Block2x7;    

        /// <summary>
        /// Block 8 of width 2
        /// </summary>
        [FieldOffset(16)]
        public BitBlock2 Bloc2x8;    

        /// <summary>
        /// Block 9 of width 2
        /// </summary>
        [FieldOffset(18)]
        public BitBlock2 Block2x9;    

        /// <summary>
        /// Block 0 of width 4
        /// </summary>
        [FieldOffset(0)]
        public BitBlock4 Block4x0;    

        /// <summary>
        /// Block 1 of width 4
        /// </summary>
        [FieldOffset(4)]
        public BitBlock4 Block4x1;    

        /// <summary>
        /// Block 2 of width 4
        /// </summary>
        [FieldOffset(8)]
        public BitBlock4 Block4x2;    

        /// <summary>
        /// Block 3 of width 4
        /// </summary>
        [FieldOffset(12)]
        public BitBlock4 Block4x3;    

        /// <summary>
        /// Block 4 of width 4
        /// </summary>
        [FieldOffset(16)]
        public BitBlock4 Block4x4;    

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

        /// <summary>
        /// Block 3 of width 5
        /// </summary>
        [FieldOffset(15)]
        public BitBlock5 Block5x3;    

        /// <summary>
        /// Block 0 of width 10
        /// </summary>
        [FieldOffset(0)]
        public BitBlock10 Block10x0;    

        /// <summary>
        /// Block 1 of width 10
        /// </summary>
        [FieldOffset(10)]
        public BitBlock10 Block10x1;    

        [MethodImpl(Inline)]
        public Span<byte> AsSpan()
            => BitView.ViewBits(ref this).Bytes;        
                
        [MethodImpl(Inline)]
        public byte GetPart(int i)
            => Unsafe.Add(ref Unsafe.As<BitBlock20, byte>(ref this), i);

        [MethodImpl(Inline)]
        public void SetPart(int i, byte value)
            => Unsafe.Add(ref Unsafe.As<BitBlock20, byte>(ref this), i) = value;
        
        public byte this [int i]
        {
            [MethodImpl(Inline)]
            get => GetPart(i);
            
            [MethodImpl(Inline)]
            set => SetPart(i,value);
        }

        public string Format()
            => this.AsGeneric().Format(); 

        public override string ToString() 
            => Format();

    }

}