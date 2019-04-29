//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zcore;

    public static class Value
    {
        [MethodImpl(Inline)]
        public static Value<T> Define<T>(T value)
            => new Value<T>(value);
    }


    public readonly struct Value<T>
    {
        [MethodImpl(Inline)]
        public static implicit operator T(Value<T> src)
            => src.Wrapped;

        [MethodImpl(Inline)]
        public static implicit operator Value<T>(T src)
            => new Value<T>(src);

        [MethodImpl(Inline)]
        public Value(T Value)
            => this.Wrapped = Value;

        public readonly T Wrapped;        
    }

}