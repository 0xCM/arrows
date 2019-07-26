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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;
    using static Span256;
    using static Span128;
    using static As;

    partial class dinx
    {
        public static Vec128<ushort> sad(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => SumAbsoluteDifferences(lhs,rhs);

        public static Vec256<ushort> sad(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => SumAbsoluteDifferences(lhs,rhs);


    }

}