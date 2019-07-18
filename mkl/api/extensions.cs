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

    public static class mklx
    {
        /// <summary>
        /// Gets the brng identifier associated with a stream
        /// </summary>
        /// <param name="stream">The source stream</param>
        [MethodImpl(Inline)]    
        public static BRNG Brng(this VslStream stream)
            => mkl.brng(stream);


    }


}