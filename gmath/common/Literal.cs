//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    
    using static mfunc;

    public static class Konst
    {
        [MethodImpl(Inline)]
        public static Konst<T> Define<T>(T value)
            where T : struct
            => new Konst<T>(value);
    }


    public readonly struct Konst<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public static implicit operator T(Konst<T> src)
            => src.Wrapped;

        [MethodImpl(Inline)]
        public static implicit operator Konst<T>(T src)
            => new Konst<T>(src);

        [MethodImpl(Inline)]
        public Konst(T Value)
            => this.Wrapped = Value;

        public readonly T Wrapped;        
    }
    
    public abstract class Literal<T,L>
        where T : Literal<T,L>
    {
        [MethodImpl(Inline)]
        public static implicit operator L(Literal<T,L> src)
            => src.Value;

        public readonly L Value;

        protected Literal(L Value)
            => this.Value = Value;
    }

}