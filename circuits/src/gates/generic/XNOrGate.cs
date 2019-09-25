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

    public readonly struct XNOrGate<T> : IBinaryGate<T>, IBinaryGate<Vec128<T>>, IBinaryGate<Vector256<T>>
        where T : unmanaged
    {
        internal static readonly XNOrGate<T> Gate = default;

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y)
            => !(x ^ y);

        [MethodImpl(Inline)]
        public T Send(in T x, in T y)
            => gbits.flip(gmath.xor(x, y));

        [MethodImpl(Inline)]
        public Vec128<T> Send(in Vec128<T> x, in Vec128<T> y)
            => gbits.flip(gbits.vxor(in x,in y));

        [MethodImpl(Inline)]
        public Vector256<T> Send(in Vector256<T> x, in Vector256<T> y)
            => gbits.flip(gbits.vxor(x,y));

    }

}