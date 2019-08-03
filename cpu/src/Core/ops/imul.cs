//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Z0.Asm;
    using static zfunc;

    partial class CpuCore
    {

        /// <summary>
        /// Performs integer multiplication between source and target registers
        /// and places the result in the target register
        /// </summary>
        /// <param name="dst">Target register identifer</param>
        /// <param name="src">Source register identifier</param>
        public int imul(GpRegId dst, GpRegId src)
        {            
            var srcLoc = src.Address();
            var dstLoc = dst.Address();
            
            ref var srcRef = ref Gpr.Ref(srcLoc);
            ref var dstRef = ref Gpr.Ref(dstLoc);
            srcRef.CopyTo(ref dstRef, srcLoc.Size);

            return 0;            
        }




    }

}