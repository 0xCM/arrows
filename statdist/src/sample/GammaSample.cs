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

    using static zfunc;
    using static nfunc;

    /// <summary>
    /// Encapsulates data sampled from a Gamma distribution joined with
    /// the BRNG identifier and distribution parameters that were specified
    /// when the sample was taken
    /// </summary>
    public readonly struct GammaSample<T>
        where T : struct
    {
        public GammaSample(RngKind rng, T Alpha, T Dx, T Beta, Memory<T> data)
        {
            this.SourceRng = rng;
            this.Alpha = Alpha;
            this.Dx = Dx;
            this.Beta = Beta;
            this.SampleData = data;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly RngKind SourceRng;

        public readonly T Alpha;

        /// <summary>
        /// The displacement
        /// </summary>
        public readonly T Dx; 

        public readonly T Beta;

        /// <summary>
        /// The data that has been sampled according to the attendant parameters
        /// </summary>
        public readonly Memory<T> SampleData;        

    }

}