//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Text;


    using static zcore;
    using static zfunc;

    partial class xcore
    {

        /// <summary>
        /// x:ulong => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this ulong src)
            where T : struct
            => convert<ulong,T>(src);
        

    }
}
