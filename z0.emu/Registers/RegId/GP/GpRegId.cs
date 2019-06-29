//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.InteropServices;


    [Flags, Info(Desc.GpRegId)]
    public enum GpRegId : ulong
    {
        #region 8-bit registers
        al = GpRegId8.al,

        ah = GpRegId8.al,
        
        bl = GpRegId8.bl,

        bh = GpRegId8.bh,

        cl = GpRegId8.cl,

        ch = GpRegId8.ch,
        
        dl = GpRegId8.dl,

        dh = GpRegId8.dh,

        sil = GpRegId8.sil,

        dil = GpRegId8.dil,

        bpl = GpRegId8.bpl,

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

        #region 16-bit registers
        ax = GpRegId16.ax,

        bx = GpRegId16.bx,

        cx = GpRegId16.cx,

        dx = GpRegId16.dx,

        si = GpRegId16.si,

        di = GpRegId16.di,

        bp = GpRegId16.bp,

        sp = GpRegId16.sp,

        r8w = GpRegId16.r8w,

        r9w = GpRegId16.r9w,

        r10w = GpRegId16.r10w,

        r11w = GpRegId16.r11w,

        r12w = GpRegId16.r12w,

        r13w = GpRegId16.r13w,

        r14w = GpRegId16.r14w,

        r15w = GpRegId16.r15w,

        #endregion 16-bit registers

        #region 32-bit registers

        eax = GpRegId32.eax,

        ebx = GpRegId32.ebx,

        ecx = GpRegId32.ecx,

        edx = GpRegId32.edx,
        
        esi = GpRegId32.esi,

        edi = GpRegId32.edi,

        ebp = GpRegId32.ebp,

        esp = GpRegId32.esp,

        r8d = GpRegId32.r8d,

        r9d = GpRegId32.r9d,

        r10d = GpRegId32.r10d,

        r11d = GpRegId32.r11d,

        r12d = GpRegId32.r12d,

        r13d = GpRegId32.r13d,

        r14d = GpRegId32.r14d,

        r15d = GpRegId32.r15d,

        #endregion  32-bit registers

        #region 64-bit registers
        
        rax = GpRegId64.rax,

        rbx = GpRegId64.rbx,

        rcx = GpRegId64.rcx,

        rsi = GpRegId64.rsi,

        rdi = GpRegId64.rdi,

        rdx = GpRegId64.rdx,

        rbp = GpRegId64.rbp,

        rsp = GpRegId64.rsp,

        r8 = GpRegId64.r8,

        r9 = GpRegId64.r9,

        r10 = GpRegId64.r10,

        r11 = GpRegId64.r11,

        r12 = GpRegId64.r12,

        r13 = GpRegId64.r13,

        r14 = GpRegId64.r14,

        r15 = GpRegId64.r15,

        #endregion 64-bit registers    
   }

}