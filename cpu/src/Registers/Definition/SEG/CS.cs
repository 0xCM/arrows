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
        /// Code segment register - pointer to code
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct CS : ICpuReg16
        {
            [FieldOffset(0)]
            public ushort cs;

            [MethodImpl(Inline)]
            public static implicit operator ushort(CS src)
                => src.cs;

            [MethodImpl(Inline)]
            public static implicit operator CS(ushort src)
                => new CS(src);

            [MethodImpl(Inline)]
            public CS(ushort src)
                => cs = src;        
 
       }
    }
}