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

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct m512i
    {
        public static m512i Define(m256i lo, m256i hi)
            => new m512i(lo,hi);
        
        public m512i(m256i lo, m256i hi)
        {
            this.v0 = lo;
            this.v1 = hi;
        }
        
        [FieldOffset(0)]
        public m256i v0;

        
        [FieldOffset(32)]
        public m256i v1;
    }     

}