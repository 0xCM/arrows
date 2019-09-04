//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
     using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    public static partial class mklx
    {
        /// <summary>
        /// Initializes a new VslStream for rng 
        /// </summary>
        /// <param name="brng">The rng that will power the stream</param>
        /// <param name="seed">The initial state of the rng, if any</param>
        /// <param name="index">The stream index, if any</param>
        [MethodImpl(Inline)]
        internal static VslStream NewStream(this BRNG brng, uint seed = 0, int index = 0)
            => mkl.vslStream(brng, seed,index);

        /// <summary>
        /// Gets the mkl brng identifier associated with a stream
        /// </summary>
        /// <param name="stream">The source stream</param>
        [MethodImpl(Inline)]    
        internal static BRNG Brng(this VslStream stream)
            => VSL.vslGetStreamStateBrng(stream);

        /// <summary>
        /// Gets the intel brng identifier associated with system rng classifier
        /// </summary>
        /// <param name="src">The mkl brng identifier</param>
        [MethodImpl(Inline)]    
        internal static BRNG ToBrng(this RngKind src)
            => (BRNG)src;

        /// <summary>
        /// Gets the system rng classifier associated with a mkl brng
        /// </summary>
        /// <param name="src">The mkl brng identifier</param>
        [MethodImpl(Inline)]    
        internal static RngKind ToRngKind(this BRNG src)
            => (RngKind)src;

        /// <summary>
        /// Gets system rng classifier associated with a stream
        /// </summary>
        /// <param name="stream">The source stream</param>
        [MethodImpl(Inline)]    
        internal static RngKind RngKind(this VslStream stream)
            => stream.Brng().ToRngKind();


    }


}