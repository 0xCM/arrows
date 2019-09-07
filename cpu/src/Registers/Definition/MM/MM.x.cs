//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;
    using static Registers;

    public static class MMx
    {
        [MethodImpl(Inline)]
        public static XMM ToRegister<T>(this Vec128<T> src)
            where T : unmanaged
                => XMM.FromVec<T>(src);

        [MethodImpl(Inline)]
        public static YMM ToRegister<T>(this Vec256<T> src)
            where T : unmanaged
                => YMM.FromVec<T>(src);

    }


}