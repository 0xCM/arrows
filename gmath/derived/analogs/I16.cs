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

    public static class BitPatterns
    {


        [StructLayout(LayoutKind.Explicit )]
        public struct I16 
        {
            [FieldOffset(0)]
            public short value;
            
            [FieldOffset(0)]
            public byte x000;
                        
            [FieldOffset(1)]
            public byte x001;
        }

    }

}