//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Z0.Asm;

    using static zfunc;

    partial class CpuCore
    {
        /// <summary>
        /// Copies the content of one register to another
        /// </summary>
        /// <param name="dst">Target register identifer</param>
        /// <param name="src">Source register identifier</param>
        public int mov(GpRegId dst, GpRegId src)
        {            
            var srcLoc = src.Address();
            var dstLoc = dst.Address();

            if(srcLoc.Size > dstLoc.Size)
                return -1;
            
            ref var srcRef = ref Gpr.Ref(srcLoc);
            ref var dstRef = ref Gpr.Ref(dstLoc);
            srcRef.CopyTo(ref dstRef, srcLoc.Size);

            return 0;            
        }

        /// <summary>
        /// Copies the content of an identified register to a target reference
        /// </summary>
        /// <param name="dst">The target reference</param>
        /// <param name="src">Source register identifier</param>
        /// <typeparam name="T">Target reference type</typeparam>
        public int mov<T>(ref T dst, GpRegId src)
            where T : struct
        {
            var srcLoc = src.Address();
            var dstSize = Unsafe.SizeOf<T>();
            if(srcLoc.Size > dstSize)
                return -1;

            ref var srcRef = ref Gpr.Ref(srcLoc);
            ref var dstRef = ref Unsafe.As<T, byte>(ref dst);
            srcRef.CopyTo(ref dstRef, srcLoc.Size);
            
            return 0;
        }

        /// <summary>
        /// Copies a source value to an identified register
        /// </summary>
        /// <param name="dst">Target register identifer</param>
        /// <param name="src">Source value</param>
        /// <typeparam name="T">Source value type</typeparam>
        public int mov<T>(GpRegId dst, T src)
            where T : struct
        {
            var dstLoc = dst.Address();
            var srcSize = Unsafe.SizeOf<T>();
            if(srcSize > dstLoc.Size)
                return -1;

            ref var srcRef = ref src.Head();
            ref var dstRef = ref Gpr.Ref(dstLoc);
            srcRef.CopyTo(ref dstRef, dstLoc.Size);
            
            return 0;
        }
    }
}
