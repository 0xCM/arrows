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

    public readonly struct AndGate<T> : IBinaryGate<T>,  IBinaryGate<Vector128<T>>, IBinaryGate<Vector256<T>>
        where T : unmanaged
    {
        internal static readonly AndGate<T> Gate = default;

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y)
            => x & y;

        [MethodImpl(Inline)]
        public T Send(in T x, in T y)
            => gmath.and(x,y);

        [MethodImpl(Inline)]
        public Vector128<T> Send(in Vector128<T> a, in Vector128<T> b)
            => gbits.vand(a,b);

        [MethodImpl(Inline)]
        public Vector256<T> Send(in Vector256<T> a, in Vector256<T> b)
            => gbits.vand<T>(a,b);

    }
}