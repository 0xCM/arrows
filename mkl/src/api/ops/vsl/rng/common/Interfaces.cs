//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
	using static zfunc;
    using static As;

    public interface ISampler<T>
        where T : unmanaged
    {
        /// <summary>
        /// The internal buffer length
        /// </summary>
        int BufferLength {get;}

        /// <summary>
        /// The sample values
        /// </summary>
        IEnumerable<T> Samples {get;}


        /// <summary>
        /// The type of distibution being sampled
        /// </summary>
        DistKind DistKind{get;}

    }


}