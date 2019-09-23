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


    public static unsafe partial class Asm
    {
        [MethodImpl(Inline)]
        static Vector256<T> vload<T>(ref YMM src)
            where T : unmanaged
            => ginx.lddqu256(in YMM.As<T>(ref src));


        [MethodImpl(Inline)]
        static Vector128<T> vload<T>(ref XMM src)
            where T : unmanaged
            => ginx.lddqu128(in src.As<T>());

        [MethodImpl(Inline)]
        static Vector256<T> vload<T>(ref Perm8 src)
            where T : unmanaged
                => ginx.lddqu256(in head(src.ToSpan<T>()));

    }


}