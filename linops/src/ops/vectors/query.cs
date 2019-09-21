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

    partial class Linear
    {
        /// <summary>
        /// Returns true of each component of the source vector equals a specified value; otherwise, returns false
        /// </summary>
        /// <param name="src">The source vector to interrogate</param>
        /// <param name="match">The target value to match</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        public static bool all<N,T>(in BlockVector<N,T> src, T match)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            for(var i=0; i< BlockVector<N,T>.Length; i++)            
                if(gmath.neq(src[i],match))
                    return false;
            return true;
        }


    }
}