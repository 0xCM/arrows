//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    static class VslSSTaskHandle
    {
        [MethodImpl(Inline)]
        public static unsafe VslSSTaskHandle<T> Create<T>(Span<T> samples, int dim)
            where T : struct
                => VslSSTaskHandle<T>.Create(samples,dim);

        [MethodImpl(Inline)]
        public static unsafe VslSSTaskHandle<T> Create<T>(Sample<T> samples)
            where T : struct
                => VslSSTaskHandle<T>.Create(samples);

        [MethodImpl(Inline)]
        public static VslSSTaskHandle<T> Wrap<T>(IntPtr ptr)
            where T : struct
                => VslSSTaskHandle<T>.Wrap(ptr);
    }
}