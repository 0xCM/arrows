//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static int movemask(in Vec128<sbyte> src)
            => MoveMask(src);

        [MethodImpl(Inline)]
        public static int movemask(in Vec128<byte> src)
            => MoveMask(src);

        [MethodImpl(Inline)]
        public static int movemask(in Vec128<float> src)
            => MoveMask(src);

        [MethodImpl(Inline)]
        public static int movemask(in Vec128<double> src)
            => MoveMask(src);

        [MethodImpl(Inline)]
        public static int movemask(in Vec256<sbyte> src)
            => MoveMask(src);

        [MethodImpl(Inline)]
        public static int movemask(in Vec256<byte> src)
            => MoveMask(src);
 

        [MethodImpl(Inline)]
        public static int movemask(in Vec256<float> src)
            => MoveMask(src);

        [MethodImpl(Inline)]
        public static int movemask(in Vec256<double> src)
            => MoveMask(src);

    }

}