//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {
        [MethodImpl(Inline)]
        public static T and<T>(T lhs, T rhs)
            where T : struct
                => gmath.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static ref T and<T>(ref T lhs, in T rhs)
            where T : struct
               => ref gmath.and(ref lhs, in rhs);
     
   }

    
}