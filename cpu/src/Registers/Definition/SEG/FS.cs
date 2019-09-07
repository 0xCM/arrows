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
        /// Extra data segment register 2/3 - pointer to extra data
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct FS : ICpuReg16
        {
            [FieldOffset(0)]
            public ushort fs;

            [MethodImpl(Inline)]
            public static implicit operator ushort(FS src)
                => src.fs;

            [MethodImpl(Inline)]
            public static implicit operator FS(ushort src)
                => new FS(src);

            [MethodImpl(Inline)]
            public FS(ushort src)
                => fs = src;            
 
       }
    }
}