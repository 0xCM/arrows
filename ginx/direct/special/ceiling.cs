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
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
        
    using static zfunc;    

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<float> ceiling(Vec128<float> src)
            => Ceiling(src);

        [MethodImpl(Inline)]
        public static Vec128<double> ceiling(Vec128<double> src)
            => Ceiling(src);

        [MethodImpl(Inline)]
        public static Vec256<float> ceiling(Vec256<float> src)
            => Ceiling(src);

        [MethodImpl(Inline)]
        public static Vec256<double> ceiling(Vec256<double> src)
            => Ceiling(src);

        [MethodImpl(Inline)]
        public static void ceiling(Vec128<float> src, ref float dst)
            => store(Ceiling(src), ref dst);

        [MethodImpl(Inline)]
        public static void ceiling(Vec128<double> src, ref double dst)
            => store(Ceiling(src), ref dst);

        [MethodImpl(Inline)]
        public static void ceiling(Vec256<float> src, ref float dst)
            => store(Ceiling(src), ref dst);

        [MethodImpl(Inline)]
        public static void ceiling(Vec256<double> src, ref double dst)
            => store(Ceiling(src), ref dst);

    }

}