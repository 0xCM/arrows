//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static corefunc;

    using C = Contracts;
    
    public static class QR
    {
        public static QR<T> define<T>(T q, T r)
            => new QR<T>(q,r);
    }


    public readonly struct QR<T>
    {
        public readonly T q;
        
        public readonly T r;

        [MethodImpl(Inline)]
        public QR(T q, T r)
        {
            this.q = q;
            this.r = r;
        }
    }


}