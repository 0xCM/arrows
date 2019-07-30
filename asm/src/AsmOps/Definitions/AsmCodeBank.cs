//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class AsmCodeBank
    {
        public static AsmCode<byte> And8U
            => AddUInt8Bytes;

        public static AsmCode<sbyte> And8I
            => AddInt8Bytes;

        public static AsmCode<int> Add32I
            => AddInt32Bytes;

        public static AsmCode<int> DivRemI32        
            => DivRemI32Bytes;
        
 
        static ReadOnlySpan<byte> AddInt32Bytes
            => new byte[]{0x0f, 0x1f, 0x44, 0x00, 0x00, 0x8d, 0x04, 0x11, 0xc3};

        static ReadOnlySpan<byte> AddUInt8Bytes
            => new byte[]{0x0f, 0x1f, 0x44, 0x00, 0x00, 0x0f, 0xb6, 0xc1, 0x0f, 0xb6, 0xd2, 0x23, 0xc2, 0x0f, 0xb6, 0xc0, 0xc3};

        static ReadOnlySpan<byte> AddInt8Bytes
            => new byte[]{0x0f, 0x1f, 0x44, 0x00, 0x00, 0x48, 0x0f, 0xbe, 0xc1, 0x48, 0x0f, 0xbe, 0xd2, 0x23, 0xc2, 0x48, 0x0f, 0xbe, 0xc0, 0xc3};

        static ReadOnlySpan<byte> DivRemI32Bytes
            => new byte[]{0x0f,0x1f,0x44,0x00,0x00,0x44,0x8b,0xd2,0x8b,0xc1,0x99,0x41,0xf7,0xfa,0x41,0x89,0x00,0x41,0x89,0x11,0xc3};
    

    }

}