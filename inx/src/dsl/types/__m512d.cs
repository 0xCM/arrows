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
    public ref struct __m512d
    {
        [FieldOffset(0)]
        public double x0d;

        [FieldOffset(8)]
        public double x1d;

        [FieldOffset(16)]
        public double x2d;

        [FieldOffset(24)]
        public double x3d;

        [FieldOffset(32)]
        public double x4d;

        [FieldOffset(40)]
        public double x5d;

        [FieldOffset(48)]
        public double x6d;

        [FieldOffset(56)]
        public double x7d;

    }

 
}