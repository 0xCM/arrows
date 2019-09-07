//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [Flags]
    public enum GpRegId : ulong
    {

        #region 64-bit registers
                
        /// <summary>
        /// Identifies the 64-bit register RAX
        /// </summary>
        rax = GpRegId64.rax,

        /// <summary>
        /// Identifies the 64-bit register RBX
        /// </summary>
        rbx = GpRegId64.rbx,

        /// <summary>
        /// Identifies the 64-bit register RCX
        /// </summary>
        rcx = GpRegId64.rcx,

        /// <summary>
        /// Identifies the 64-bit register RSI
        /// </summary>
        rsi = GpRegId64.rsi,

        /// <summary>
        /// Identifies the 64-bit register RDI
        /// </summary>
        rdi = GpRegId64.rdi,

        /// <summary>
        /// Identifies the 64-bit register RDX
        /// </summary>
        rdx = GpRegId64.rdx,

        /// <summary>
        /// Identifies the 64-bit register RBP
        /// </summary>
        rbp = GpRegId64.rbp,

        /// <summary>
        /// Identifies the 64-bit register RSP
        /// </summary>
        rsp = GpRegId64.rsp,

        /// <summary>
        /// Identifies the 64-bit register R8
        /// </summary>
        r8 = GpRegId64.r8,

        /// <summary>
        /// Identifies the 64-bit register R9
        /// </summary>
        r9 = GpRegId64.r9,

        /// <summary>
        /// Identifies the 64-bit register R10
        /// </summary>
        r10 = GpRegId64.r10,

        /// <summary>
        /// Identifies the 64-bit register R11
        /// </summary>
        r11 = GpRegId64.r11,

        /// <summary>
        /// Identifies the 64-bit register R12
        /// </summary>
        r12 = GpRegId64.r12,

        /// <summary>
        /// Identifies the 64-bit register R13
        /// </summary>
        r13 = GpRegId64.r13,

        /// <summary>
        /// Identifies the 64-bit register R14
        /// </summary>
        r14 = GpRegId64.r14,

        /// <summary>
        /// Identifies the 64-bit register R15
        /// </summary>
        r15 = GpRegId64.r15,

        #endregion 64-bit registers    

        #region 32-bit registers

        /// <summary>
        /// Identifies RAX[31:0]
        /// </summary>
        eax = GpRegId32.eax,

        /// <summary>
        /// Identifies RBX[31:0]
        /// </summary>
        ebx = GpRegId32.ebx,

        /// <summary>
        /// Identifies RCX[31:0]
        /// </summary>
        ecx = GpRegId32.ecx,

        /// <summary>
        /// Identifies EDX[31:0]
        /// </summary>
        edx = GpRegId32.edx,
        
        /// <summary>
        /// Identifies RSI[31:0]
        /// </summary>
        esi = GpRegId32.esi,

        /// <summary>
        /// Identifies RDI[31:0]
        /// </summary>
        edi = GpRegId32.edi,

        /// <summary>
        /// Identifies RSP[31:0]
        /// </summary>
        esp = GpRegId32.esp,

        /// <summary>
        /// Identifies RBP[31:0]
        /// </summary>
        ebp = GpRegId32.ebp,

        /// <summary>
        /// Identifies R8[31:0]
        /// </summary>
        r8d = GpRegId32.r8d,

        /// <summary>
        /// Identifies R9[31:0]
        /// </summary>
        r9d = GpRegId32.r9d,

        /// <summary>
        /// Identifies R10[31:0]
        /// </summary>
        r10d = GpRegId32.r10d,

        /// <summary>
        /// Identifies R11[31:0]
        /// </summary>
        r11d = GpRegId32.r11d,

        /// <summary>
        /// Identifies R12[31:0]
        /// </summary>
        r12d = GpRegId32.r12d,

        /// <summary>
        /// Identifies R13[31:0]
        /// </summary>
        r13d = GpRegId32.r13d,

        /// <summary>
        /// Identifies R14[31:0]
        /// </summary>
        r14d = GpRegId32.r14d,

        /// <summary>
        /// Identifies R15[31:0]
        /// </summary>
        r15d = GpRegId32.r15d,

        #endregion  32-bit registers

        #region 16-bit registers

        /// <summary>
        /// Identifies RAX[15:0] or EAX[15:0]
        /// </summary>
        ax = GpRegId16.ax,

        /// <summary>
        /// Identifies RBX[15:0] or EBX[15:0]
        /// </summary>
        bx = GpRegId16.bx,

        /// <summary>
        /// Identifies RCX[15:0] or ECX[15:0]
        /// </summary>
        cx = GpRegId16.cx,

        /// <summary>
        /// Identifies RDX[15:0] or EDX[15:0]
        /// </summary>
        dx = GpRegId16.dx,

        /// <summary>
        /// Identifies RSI[15:0] or ESI[15:0]
        /// </summary>
        si = GpRegId16.si,

        /// <summary>
        /// Identifies RDI[15:0] or EDI[15:0]
        /// </summary>
        di = GpRegId16.di,

        /// <summary>
        /// Identifies RBP[15:0] or EBP[15:0]
        /// </summary>
        bp = GpRegId16.bp,

        /// <summary>
        /// Identifies RSP[15:0] or ESP[15:0]
        /// </summary>
        sp = GpRegId16.sp,

        /// <summary>
        /// Identifies R8[15:0] or R8d[15:0]
        /// </summary>
        r8w = GpRegId16.r8w,

        /// <summary>
        /// Identifies R9[15:0] or R9d[15:0]
        /// </summary>
        r9w = GpRegId16.r9w,

        /// <summary>
        /// Identifies R10[15:0] or R10d[15:0]
        /// </summary>
        r10w = GpRegId16.r10w,

        /// <summary>
        /// Identifies R11[15:0] or R11d[15:0]
        /// </summary>
        r11w = GpRegId16.r11w,

        /// <summary>
        /// Identifies R12[15:0] or R12d[15:0]
        /// </summary>
        r12w = GpRegId16.r12w,

        /// <summary>
        /// Identifies R13[15:0] or R13d[15:0]
        /// </summary>
        r13w = GpRegId16.r13w,

        /// <summary>
        /// Identifies R14[15:0] or R14d[15:0]
        /// </summary>
        r14w = GpRegId16.r14w,

        /// <summary>
        /// Identifies R15[15:0] or R15d[15:0]
        /// </summary>
        r15w = GpRegId16.r15w,

        #endregion 16-bit registers

         #region 8-bit registers

        /// <summary>
        /// Identifies RAX[7:0]
        /// </summary>
        al = GpRegId8.al,
        
        /// <summary>
        /// Identifies RAX[15:8]
        /// </summary>
        ah = GpRegId8.al,        
        
        /// <summary>
        /// Identifies RBX[7:0]
        /// </summary>
        bl = GpRegId8.bl,

        /// <summary>
        /// Identifies RBX[15:8]
        /// </summary>
        bh = GpRegId8.bh,

        /// <summary>
        /// Identifies RCX[7:0]
        /// </summary>
        cl = GpRegId8.cl,

        /// <summary>
        /// Identifies RCX[15:7]
        /// </summary>
        ch = GpRegId8.ch,
        
        /// <summary>
        /// Identifies RDX[7:0]
        /// </summary>
        dl = GpRegId8.dl,

        /// <summary>
        /// Identifies RDX[15:7]
        /// </summary>
        dh = GpRegId8.dh,

        /// <summary>
        /// Identifies RSI[7:0]
        /// </summary>
        sil = GpRegId8.sil,

        /// <summary>
        /// Identifies RDI[7:0]
        /// </summary>
        dil = GpRegId8.dil,

        /// <summary>
        /// Identifies RBP[7:0]
        /// </summary>
        bpl = GpRegId8.bpl,

        /// <summary>
        /// Identifies RSP[7:0]
        /// </summary>
        spl = GpRegId8.spl,

        r8b = GpRegId8.r8b,

        r9b = GpRegId8.r9b,

        r10b = GpRegId8.r10b,

        r11b = GpRegId8.r11b,

        r12b = GpRegId8.r12b,

        r13b = GpRegId8.r13b,

        r14b = GpRegId8.r14b,

        r15b = GpRegId8.r15b,

        #endregion 8-bit registers

   }

}