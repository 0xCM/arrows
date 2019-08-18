//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public readonly struct MuxGate : ITernaryGate
    {
        internal static readonly MuxGate G = default;

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y, Bit control)
            => control ? y : x;
    }

    public readonly struct MuxGate<T> : ITernaryGate<T>
        where T : struct
    {
        internal static readonly MuxGate<T> G = default;

        [MethodImpl(Inline)]
        public T Send(T x, T y, T control)
        {
            return gbits.or(gbits.andnot(x, control), gbits.and(y, control));
            //return gbits.xor(gbits.and(gbits.xor(x,y), control), x);
        }
            
    }

    public readonly struct MuxGate128<T> : ITernaryGate<Vec128<T>>
        where T : struct
    {
        internal static readonly MuxGate128<T> G = default;

        [MethodImpl(Inline)]
        public Vec128<T> Send(Vec128<T> x, Vec128<T> y, Vec128<T> control)
            => gbits.or(gbits.andnot(x, control), gbits.and(y, control));
    }

    public readonly struct MuxGate256<T> : ITernaryGate<Vec256<T>>
        where T : struct
    {
        internal static readonly MuxGate256<T> G = default;

        [MethodImpl(Inline)]
        public Vec256<T> Send(Vec256<T> x, Vec256<T> y, Vec256<T> control)
            => gbits.or(gbits.andnot(x, control), gbits.and(y, control));
    }

}