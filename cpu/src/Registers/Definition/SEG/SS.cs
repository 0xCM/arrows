//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    
    partial class Registers
    {
        /// <summary>
        /// Stack segment register - pointer to stack
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct SS : ICpuReg16
        {
            [FieldOffset(0)]
            public ushort ss;

            [MethodImpl(Inline)]
            public static implicit operator ushort(SS src)
                => src.ss;

            [MethodImpl(Inline)]
            public static implicit operator SS(ushort src)
                => new SS(src);

            [MethodImpl(Inline)]
            public SS(ushort src)
                => ss = src;

        }
    }
}