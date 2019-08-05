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
        public static Vec128<float> ceil(in Vec128<float> src)
            => Ceiling(src);

        [MethodImpl(Inline)]
        public static Vec128<double> ceil(in Vec128<double> src)
            => Ceiling(src);

        [MethodImpl(Inline)]
        public static Vec256<float> ceil(in Vec256<float> src)
            => Ceiling(src);

        [MethodImpl(Inline)]
        public static Vec256<double> ceil(in Vec256<double> src)
            => Ceiling(src);

        [MethodImpl(Inline)]
        public static void ceil(in Vec128<float> src, ref float dst)
            => store(Ceiling(src), ref dst);

        [MethodImpl(Inline)]
        public static void ceil(in Vec128<double> src, ref double dst)
            => store(Ceiling(src), ref dst);

        [MethodImpl(Inline)]
        public static void ceil(in Vec256<float> src, ref float dst)
            => store(Ceiling(src), ref dst);

        [MethodImpl(Inline)]
        public static void ceil(in Vec256<double> src, ref double dst)
            => store(Ceiling(src), ref dst);


    }

}