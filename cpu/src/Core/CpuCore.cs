//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using R = Registers;

    using static zfunc;


    /*
    uint mul<uint>(uint lhs, uint rhs)
    asm ----------------------------------------------------------------------------
    0000h  nop dword ptr [rax+rax]
    0005h  mov eax,ecx
    0007h  imul eax,edx
    000ah  ret
    end asm ------------------------------------------------------------------------        
    */
    partial class CpuCore
    {        

    }

}