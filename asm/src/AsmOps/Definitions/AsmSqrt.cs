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
    using System.Reflection;
    using System.Reflection.Emit;

    using static zfunc;
    using static AsmOps;

    partial class AsmOps
    {
    
        readonly struct SqrtHost<T>
            where T : struct
        {
            
            public static readonly SqrtHost<T> TheOnly = default;

            static readonly AsmUnaryOp<T> Reified = SqrtCode<T>().CreateUnaryOp();
            
            public AsmUnaryOp<T> Operator
                => Reified;
        }

        [MethodImpl(Inline)]
         public static AsmUnaryOp<T> Sqrt<T>()
            where T : struct
                => SqrtHost<T>.TheOnly.Operator;

        static AsmCode<T> SqrtCode<T>()
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return AsmCode.FromBytes<T>(SqrtF32Bytes);
            else if(typeof(T) == typeof(double))
                return AsmCode.FromBytes<T>(SqrtF64Bytes);
            else 
                throw unsupported<T>();
        }


        static ReadOnlySpan<byte> SqrtF32Bytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x51,0xC0,0xC3};      

        static ReadOnlySpan<byte> SqrtF64Bytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x51,0xC0,0xC3};  
    
   }

}



/*
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float SqrtF32(float src)
; location: [7FFC7CC13FE0h, 7FFC7CC13FE9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vsqrtss xmm0,xmm0,xmm0        ; VSQRTSS(VEX_Vsqrtss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 fa 51 c0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> SqrtF32Bytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x51,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double SqrtF64(double src)
; location: [7FFC7CC14000h, 7FFC7CC14009h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vsqrtsd xmm0,xmm0,xmm0        ; VSQRTSD(VEX_Vsqrtsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 fb 51 c0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> SqrtF64Bytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x51,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------

 */