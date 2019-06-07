//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

     
    using static zfunc;

    public static class VecConvertX
    {

        [MethodImpl(Inline)]
        public static Vec128<ulong> ToVec128(this in UInt128 src)
            => Vec128.define(src.lo, src.hi);

        [MethodImpl(Inline)]
        public static UInt128 ToUInt128(this in Vec128<ulong> src)
            => new UInt128(src[0], src[1]);



    }



}