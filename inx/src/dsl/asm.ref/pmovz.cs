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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static zfunc;

    partial class AsmRef
    {
        [MethodImpl(Inline), AsmEncoding("pmovzxbw",
            Spec: "",
            Call: "vpmovzxbw xmm0,qword ptr [rdx]",
            Code: "c4 e2 79 30 02"
        )]        
        public static Vector128<short> pmovzxbw(Vector128<byte> a)        
            => ConvertToVector128Int16(a);

        [MethodImpl(Inline), AsmEncoding("pmovzbd",
            Spec: "",
            Call: "vpmovzxbd xmm0,dword ptr [rdx]",
            Code: "c4 e2 79 31 02"
        )]        
        public static Vector128<int> pmovzbd(Vector128<byte> xmm0)        
            => ConvertToVector128Int32(xmm0);

        [MethodImpl(Inline), AsmEncoding("pmovzbq",
            Spec: "",
            Call: "vpmovzxbq xmm0,word ptr [rdx]",
            Code: "c4 e2 79 32 02"
        )]        
        public static Vector128<long> pmovzbq(Vector128<byte> xmm0)        
            => ConvertToVector128Int64(xmm0);


    }

}