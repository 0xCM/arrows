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
        public static T xor<T>(T lhs, T rhs)
            where T : unmanaged
                => gmath.xor(lhs,rhs);

        [MethodImpl(Inline)]
        public static T xor<T>(in T lhs, in T rhs)
            where T : unmanaged
                => gmath.xor(lhs,rhs);

        [MethodImpl(Inline)]
        public static ref T xor<T>(ref T lhs, in T rhs, ref T dst)
            where T : struct
        {
            dst = gmath.xor(lhs,rhs);
            return ref dst;
        }


 
         
    }
}