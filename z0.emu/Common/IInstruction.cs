//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public interface IInstruction
    {
        
    }

    /// <summary>
    /// Characterizes an instruction that accepts a source register
    /// and a target register
    /// </summary>
    /// <typeparam name="S">The source register type</typeparam>
    /// <typeparam name="T">The target register type</typeparam>
    public interface IInstruction<S,T>
        where S : ICpuReg
        where T : ICpuReg
    {
        
    }


}