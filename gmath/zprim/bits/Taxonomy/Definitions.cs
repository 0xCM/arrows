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
    using System.IO;
    
    using static zfunc;
    using static mfunc;

    /// <summary>
    ///  Defines bit-level classificaitons
    /// </summary>
    public enum BitKind 
    {        
        /// <summary>
        ///  For a sequence of bits {b[N-1],..., b[1], b[0]}, identifies the 
        ///  least index i in {0,..., N-1}, and the corresponding bit b[i],
        ///  for which b[i] = 1
        /// </summary>
        LoOn,

        /// <summary>
        ///  For a sequence of bits {b[N-1],..., b[1], b[0]}, identifies the 
        ///  least index i in {0,..., N-1}, and the corresponding bit b[i],
        ///  for which b[i] = 0
        /// </summary>
        LoOff,
        
        /// <summary>
        ///  For a sequence of bits {b[N-1],..., b[1], b[0]}, identifies the 
        ///  greatest index i in {0,..., N-1}, and the corresponding bit b[i],
        ///  for which b[i] = 1
        /// </summary>
        HiOn,

        /// <summary>
        ///  For a sequence of bits {b[N-1],..., b[1], b[0]}, identifies the 
        ///  greatest index i in {0,..., N-1}, and the corresponding bit b[i],
        ///  for which b[i] = 0
        /// </summary>
        HiOff


        


    }

}