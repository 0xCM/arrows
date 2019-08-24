//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;
    using static dinx;

    partial class BitsX
    {
        [MethodImpl(Inline)]
        public static Vec128<T> Flip<T>(this Vec128<T> src)
            where T : struct
                => gbits.flip(in src);

        [MethodImpl(Inline)]
        public static Vec256<T> Flip<T>(this Vec256<T> src)
            where T : struct
                => gbits.flip(in src);

        [MethodImpl(Inline)]
        public static void Flip<T>(this Vec128<T> lhs, ref T dst)
            where T : struct
                => gbits.flip(in lhs, ref dst);

        [MethodImpl(Inline)]
        public static void Flip<T>(this Vec256<T> lhs, ref T dst)
            where T : struct
                => gbits.flip(in lhs, ref dst);

    }
}