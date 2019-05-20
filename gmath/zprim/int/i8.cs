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
    using static mfunc;

    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public ref struct i8
    {
        public i8(sbyte src)
        {
            this.x000 = 0;
            this.src =0;                
            this.src = src;
        }
                
        [FieldOffset(0)]
        public sbyte src;
        
        
        [FieldOffset(0)]
        public byte x000;
        
    }



}