//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static zfunc;

    public enum TriangularKind : byte
    {
        
        /// <summary>
        /// Classifies a matrix as lower-triangular
        /// </summary>
        Lower,
        
        /// <summary>
        /// Classifies a matrix as upper-triangular
        /// </summary>
        Upper,
    }    
}