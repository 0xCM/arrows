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
    /// Represents 32 bits with 32 8-bit values that may range over {0,1}
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size=32)]
    public struct BitBlock32
    {
        [MethodImpl(Inline)]
        public static BitBlock32 FromSpan(Span<byte> src)
            => MemoryMarshal.AsRef<BitBlock32>(src);

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
        ///  Bit 20
        /// </summary>
        [FieldOffset(20)]
        public byte Bit20;

        /// <summary>
        ///  Bit 21
        /// </summary>
        [FieldOffset(21)]
        public byte Bit21;

        /// <summary>
        ///  Bit 22
        /// </summary>
        [FieldOffset(22)]
        public byte Bit22;

        /// <summary>
        ///  Bit 23
        /// </summary>
        [FieldOffset(23)]
        public byte Bit23;

        /// <summary>
        ///  Bit 24
        /// </summary>
        [FieldOffset(24)]
        public byte Bit24;

        /// <summary>
        ///  Bit 25
        /// </summary>
        [FieldOffset(25)]
        public byte Bit25;

        /// <summary>
        ///  Bit 26
        /// </summary>
        [FieldOffset(26)]
        public byte Bit26;

        /// <summary>
        ///  Bit 27
        /// </summary>
        [FieldOffset(27)]
        public byte Bit27;

        /// <summary>
        ///  Bit 28
        /// </summary>
        [FieldOffset(28)]
        public byte Bit28;

        /// <summary>
        ///  Bit 29
        /// </summary>
        [FieldOffset(29)]
        public byte Bit29;

        /// <summary>
        ///  Bit 30
        /// </summary>
        [FieldOffset(30)]
        public byte Bit30;

        /// <summary>
        ///  Bit 31
        /// </summary>
        [FieldOffset(31)]
        public byte Bit31;

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
        /// Block 10 of width 2
        /// </summary>
        [FieldOffset(20)]
        public BitBlock2 Block2x10;    

        /// <summary>
        /// Block 11 of width 2
        /// </summary>
        [FieldOffset(22)]
        public BitBlock2 Block2x11;    

        /// <summary>
        /// Block 12 of width 2
        /// </summary>
        [FieldOffset(24)]
        public BitBlock2 Block2x12;    

        /// <summary>
        /// Block 13 of width 2
        /// </summary>
        [FieldOffset(26)]
        public BitBlock2 Block2x13;    

        /// <summary>
        /// Block 14 of width 2
        /// </summary>
        [FieldOffset(28)]
        public BitBlock2 Block2x14;    

        /// <summary>
        /// Block 15 of width 2
        /// </summary>
        [FieldOffset(30)]
        public BitBlock2 Block2x15;

        /// <summary>
        /// Block 0 of width 8
        /// </summary>
        [FieldOffset(0)]
        public BitBlock8 Block8x0;

        /// <summary>
        /// Block 1 of width 8
        /// </summary>
        [FieldOffset(8)]
        public BitBlock8 Block8x1;

        /// <summary>
        /// Block 2 of width 8
        /// </summary>
        [FieldOffset(16)]
        public BitBlock8 Block8x2;

        /// <summary>
        /// Block 3 of width 8
        /// </summary>
        [FieldOffset(24)]
        public BitBlock8 Block8x3;

        [MethodImpl(Inline)]
        public Span<byte> AsSpan()
            => BitView.ViewBits(ref this).Bytes;
        
        [MethodImpl(Inline)]
        public void CopyTo(Span<byte> dst)        
            => BitView.ViewBits(ref this).CopyTo(dst);            
        

    }

}