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
        public static Quorem<T> define<T>(T q, T r)
            => new Quorem<T>(q,r);
    }


    public readonly struct Quorem<T>
    {
        public readonly T q;
        
        public readonly T r;

        [MethodImpl(Inline)]
        public Quorem(T q, T r)
        {
            this.q = q;
            this.r = r;
        }
    }


}