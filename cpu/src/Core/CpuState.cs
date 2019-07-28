//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    using R = Registers;

    #pragma warning disable 0414
    #pragma warning disable 0169 // Disables "The field 'X' is never used

    partial class CpuCore
    {
        public void Reset()
        {
            rax = 0ul; 
            rcx = 0ul;           
            rbx = 0ul;
            rdx = 0ul;
            rsi = 0ul;
            rdi = 0ul;
            rsp = 0ul;
            rbp = 0ul;
            r8 = 0ul;
            r9 = 0ul;
            r10 = 0ul;
            r11 = 0ul;
            r12 = 0ul;
            r13 = 0ul;
            r14 = 0ul;
            r15 = 0ul;
    
        }

        public void Start()
        {

        }

        /// <summary>
        /// General-purpose registers
        /// </summary>
        GpRegBank Gpr;

        /// <summary>
        /// Z/Y/Z registers
        /// </summary>
        ZmmBank Zmm;

        R.CS CS = default;

        R.DS DS = default;

        R.ES ES = default;

        R.FS FS = default;

        R.GS GS = default;

        R.SS SS = default;



    }

}