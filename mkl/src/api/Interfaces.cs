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

    public interface IRngStream : IDisposable
    {
        /// <summary>
        /// The type of rng in use
        /// </summary>
        RngKind Rng {get;}
        
    }

    public interface ISampleBuffer<T>
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