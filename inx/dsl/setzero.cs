//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
        
    using static zfunc;    


    public static partial class x86
    {


        [MethodImpl(Inline)]
        public static m256i _mm256_setzero_si256()
            => Vec256.zero<long>();


    }


}