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
    using static Registers;

    [StructLayout(LayoutKind.Explicit)]
    public struct ZmmBank
    {
        const int SegLen = 64;
        
        //~ 00
        //~ ----------------------
        [FieldOffset(0)]
        public ZMM zmm0;

        [FieldOffset(0)]
        public YMM ymm0;

        [FieldOffset(0)]
        public XMM xmm0;

        //~ 01
        //~ ----------------------
        [FieldOffset(SegLen)]
        public ZMM zmm1;

        [FieldOffset(SegLen)]
        public YMM ymm1;

        [FieldOffset(SegLen)]
        public XMM xmm1;

        //~ 02
        //~ ----------------------
        [FieldOffset(SegLen*2)]
        public ZMM zmm2;

        [FieldOffset(SegLen*2)]
        public YMM ymm2;

        [FieldOffset(SegLen*2)]
        public XMM xmm2;


        //~ 03
        //~ ----------------------
        [FieldOffset(SegLen*3)]
        public ZMM zmm3;

        [FieldOffset(SegLen*3)]
        public YMM ymm3;

        [FieldOffset(SegLen*3)]
        public XMM xmm3;

        //~ 04
        //~ ----------------------
        [FieldOffset(SegLen*4)]
        public ZMM zmm4;

        [FieldOffset(SegLen*4)]
        public YMM ymm4;

        [FieldOffset(SegLen*4)]
        public XMM xmm4;

        //~ 05
        //~ ----------------------
        [FieldOffset(SegLen*5)]
        public ZMM zmm5;

        [FieldOffset(SegLen*5)]
        public YMM ymm5;

        [FieldOffset(SegLen*5)]
        public XMM xmm5;

        //~ 06
        //~ ----------------------
        [FieldOffset(SegLen*6)]
        public ZMM zmm6;

        [FieldOffset(SegLen*6)]
        public YMM ymm6;

        [FieldOffset(SegLen*6)]
        public XMM xmm6;

        //~ 07
        //~ ----------------------
        [FieldOffset(SegLen*7)]
        public ZMM zmm7;

        [FieldOffset(SegLen*7)]
        public YMM ymm7;

        [FieldOffset(SegLen*7)]
        public XMM xmm7;

        //~ 08
        //~ ----------------------
        [FieldOffset(SegLen*8)]
        public ZMM zmm8;

        [FieldOffset(SegLen*8)]
        public YMM ymm8;

        [FieldOffset(SegLen*8)]
        public XMM xmm8;

        //~ 09
        //~ ----------------------
        [FieldOffset(SegLen*9)]
        public ZMM zmm9;

        [FieldOffset(SegLen*9)]
        public YMM ymm9;

        [FieldOffset(SegLen*9)]
        public XMM xmm9;

        //~ 10
        //~ ----------------------
        [FieldOffset(SegLen*10)]
        public ZMM zmm10;

        [FieldOffset(SegLen*10)]
        public YMM ymm10;

        [FieldOffset(SegLen*10)]
        public XMM xmm10;


        //~ 11
        //~ ----------------------
        [FieldOffset(SegLen*11)]
        public ZMM zmm11;

        [FieldOffset(SegLen*11)]
        public YMM ymm11;

        [FieldOffset(SegLen*11)]
        public XMM xmm11;

        //~ 12
        //~ ----------------------
        [FieldOffset(SegLen*12)]
        public ZMM zmm12;

        [FieldOffset(SegLen*12)]
        public YMM ymm12;

        [FieldOffset(SegLen*12)]
        public XMM xmm12;


        //~ 13
        //~ ----------------------
        [FieldOffset(SegLen*13)]
        public ZMM zmm13;

        [FieldOffset(SegLen*13)]
        public YMM ymm13;

        [FieldOffset(SegLen*13)]
        public XMM xmm13;

        //~ 14
        //~ ----------------------
        [FieldOffset(SegLen*14)]
        public ZMM zmm14;

        [FieldOffset(SegLen*14)]
        public YMM ymm14;

        [FieldOffset(SegLen*14)]
        public XMM xmm14;

        //~ 15
        //~ ----------------------
        [FieldOffset(SegLen*15)]
        public ZMM zmm15;

        [FieldOffset(SegLen*15)]
        public YMM ymm15;

        [FieldOffset(SegLen*15)]
        public XMM xmm15;

        //~ 16
        //~ ----------------------

        [FieldOffset(SegLen*16)]
        public ZMM zmm16;

        [FieldOffset(SegLen*16)]
        public YMM ymm16;

        [FieldOffset(SegLen*16)]
        public XMM xmm16;

        //~ 17
        //~ ----------------------
        [FieldOffset(SegLen*17)]
        public ZMM zmm17;

        [FieldOffset(SegLen*17)]
        public YMM ymm17;

        [FieldOffset(SegLen*17)]
        public XMM xmm17;

        //~ 18
        //~ ----------------------
        [FieldOffset(SegLen*18)]
        public ZMM zmm18;

        [FieldOffset(SegLen*18)]
        public YMM ymm18;

        [FieldOffset(SegLen*18)]
        public XMM xmm18;

        //~ 19
        //~ ----------------------
        [FieldOffset(SegLen*19)]
        public ZMM zmm19;

        [FieldOffset(SegLen*19)]
        public YMM ymm19;

        [FieldOffset(SegLen*19)]
        public XMM xmm19;

        //~ 20
        //~ ----------------------
        [FieldOffset(SegLen*20)]
        public ZMM zmm20;

        [FieldOffset(SegLen*20)]
        public YMM ymm20;

        [FieldOffset(SegLen*20)]
        public XMM xmm20;

        //~ 21
        //~ ----------------------
        
        [FieldOffset(SegLen*21)]
        public ZMM zmm21;

        [FieldOffset(SegLen*21)]
        public YMM ymm21;

        [FieldOffset(SegLen*21)]
        public XMM xmm21;


        //~ 22
        //~ ----------------------

        [FieldOffset(SegLen*22)]
        public ZMM zmm22;

        [FieldOffset(SegLen*22)]
        public YMM ymm22;

        [FieldOffset(SegLen*22)]
        public XMM xmm22;


        //~ 23
        //~ ----------------------

        [FieldOffset(SegLen*23)]
        public ZMM zmm23;

        [FieldOffset(SegLen*23)]
        public YMM ymm23;

        [FieldOffset(SegLen*23)]
        public XMM xmm23;

        //~ 24
        //~ ----------------------
        [FieldOffset(SegLen*24)]
        public ZMM zmm24;

        [FieldOffset(SegLen*24)]
        public YMM ymm24;

        [FieldOffset(SegLen*24)]
        public XMM xmm24;

        //~ 25
        //~ ----------------------
        [FieldOffset(SegLen*25)]
        public ZMM zmm25;

        [FieldOffset(SegLen*25)]
        public YMM ymm25;

        [FieldOffset(SegLen*25)]
        public XMM xmm25;

        //~ 26
        //~ ----------------------
        [FieldOffset(SegLen*26)]
        public ZMM zmm26;

        [FieldOffset(SegLen*26)]
        public YMM ymm26;

        [FieldOffset(SegLen*26)]
        public XMM xmm26;

        //~ 27
        //~ ----------------------
        [FieldOffset(SegLen*27)]
        public ZMM zmm27;

        [FieldOffset(SegLen*27)]
        public YMM ymm27;

        [FieldOffset(SegLen*27)]
        public XMM xmm27;

        //~ 28
        //~ ----------------------
        [FieldOffset(SegLen*28)]
        public ZMM zmm28;

        [FieldOffset(SegLen*28)]
        public YMM ymm28;

        [FieldOffset(SegLen*28)]
        public XMM xmm28;

        //~ 29
        //~ ----------------------
        [FieldOffset(SegLen*29)]
        public ZMM zmm29;

        [FieldOffset(SegLen*29)]
        public YMM ymm29;

        [FieldOffset(SegLen*29)]
        public XMM xmm29;

        //~ 30
        //~ ----------------------
        [FieldOffset(SegLen*30)]
        public ZMM zmm30;

        [FieldOffset(SegLen*30)]
        public YMM ymm30;

        [FieldOffset(SegLen*30)]
        public XMM xmm30;

        //~ 31
        //~ ----------------------
        [FieldOffset(SegLen*31)]
        public ZMM zmm31;

        [FieldOffset(SegLen*31)]
        public YMM ymm31;

        [FieldOffset(SegLen*31)]
        public XMM xmm31;


    }
}