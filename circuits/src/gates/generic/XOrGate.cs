//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public readonly struct XOrGate<T> : IBinaryGate<T>, IBinaryGate<Vec128<T>>, IBinaryGate<Vector256<T>>
        where T : unmanaged
    {
        internal static readonly XOrGate<T> Gate = default;

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y)
            => x ^ y;

        [MethodImpl(Inline)]
        public T Send(in T a, in T b)
            => gmath.xor(a,b);

        [MethodImpl(Inline)]
        public Vec128<T> Send(in Vec128<T> a, in Vec128<T> b)
            => gbits.vxor(in a,in b);

        [MethodImpl(Inline)]
        public Vector256<T> Send(in Vector256<T> a, in Vector256<T> b)
            => gbits.vxor(a,b);

    }

}