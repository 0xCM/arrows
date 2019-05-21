//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public static class Quorem
    {
        [MethodImpl(Inline)]
        public static Quorem<T> define<T>(in T q, in T r)
            => new Quorem<T>(q,r);

        [MethodImpl(Inline)]
        public static Quorem<T> define<T>((T Quotient, T Remainder) src)
            => Quorem.define(src.Quotient, src.Remainder);

        [MethodImpl(Inline)]
        public static (T Quotient, T Remainder) Deconstruct<T>(this Quorem<T> src)
            => (src.Quotient, src.Remainder);
    }

    public ref struct Quorem<T>
    {
        [MethodImpl(Inline)]
        public static implicit operator Quorem<T>((T Quotient, T Remainder) src)
            => Quorem.define(src);

        [MethodImpl(Inline)]
        public static implicit operator (T Quotient, T Remainder)(Quorem<T> src)
            => src.Deconstruct();

        [MethodImpl(Inline)]
        public Quorem(in T q, in T r)
        {
            this.Quotient = q;
            this.Remainder = r;
        }
        
        public T Quotient;
        
        public T Remainder;

        public override string ToString()
            => $"{Quotient} \\ {Remainder}";

    }


}