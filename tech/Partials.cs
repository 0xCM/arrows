//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    
    /// <summary>
    /// Defines the canonical general purpose 64-bit registers
    /// </summary>
    /// <remarks>
    /// See:
    /// https://docs.microsoft.com/en-us/windows-hardware/drivers/debugger/x64-architecture
    /// https://cs.brown.edu/courses/cs033/docs/guides/x64_cheatsheet.pdf
    /// </remarks>
    public static partial class Registers
    {
        const string RegInfo = "Defines the %d-bit content of the %s register";

        const string LayoutInfo = "Defines the %s register layout";
    
        const string RegPartInfo = "Defines selector for the lower %d bits of the %s register";
    
    }
    
    public partial class CpuCore
    {


    }

}