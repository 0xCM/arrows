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


    partial class Machine
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
            ZMM.Reset();    
    
        }

        public void Start()
        {

        }

        R.RAX RAX = default;

        R.RCX RCX = default;

        R.RDX RDX = default;

        R.RBX RBX = default;

        R.RSI RSI = default;

        R.RDI RDI = default;

        R.RSP RSP = default;

        R.RBP RBP = default;

        R.R8 R8 = default;

        R.R9 R9 = default;

        R.R10 R10 = default;

        R.R11 R11 = default;

        R.R12 R12 = default;

        R.R13 R13 = default;

        R.R14 R14 = default;

        R.R15 R15 = default;

        R.CS CS = default;

        R.DS DS = default;

        R.ES ES = default;

        R.FS FS = default;

        R.GS GS = default;

        R.SS SS = default;

        RegisterBank<R.ZMM> ZMM = RegisterBank.Define<R.ZMM>(32);

        RegisterBank<R.XMM> YMM;

        RegisterBank<R.XMM> XMM;

    }

}