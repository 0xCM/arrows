//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;

    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public ref struct I16 
    {
        public I16(short src)
        {
            this.x000 = 0;
            this.x001  =0;                
            this.src = src;
        }
                
        
        [FieldOffset(0)]
        public short src;
        
        [FieldOffset(0)]
        public byte x000;
                    
        [FieldOffset(1)]
        public byte x001;
    }


}