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
        
    using static zfunc;    

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<float> recipsqrt(Vec128<float> src)
            => Avx2.ReciprocalSqrt(src);
    
     
        [MethodImpl(Inline)]
        public static ref Num128<float> recipsqrt(ref Num128<float> src)
        {
            src = ReciprocalSqrtScalar(src);
            return ref src;
        }

    }

}