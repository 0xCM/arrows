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

    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public struct U16 
    {
        public static implicit operator U16(ushort src)
            => new U16(src);

        public static implicit operator ushort(U16 src)
            => src.src;

        public U16(ushort src)
        {
            this.x000 = 0;
            this.x001  =0;                
            this.src = src;
        }
                
        
        [FieldOffset(0)]
        public ushort src;
        
        [FieldOffset(0)]
        public byte x000;
                    
        [FieldOffset(1)]
        public byte x001;
    }


}