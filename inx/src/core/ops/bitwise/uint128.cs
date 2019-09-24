//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    
    using static As;
    using static zfunc;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static UInt128 and(in UInt128 lhs, in UInt128 rhs)
            => and(lhs.ToVec128(), rhs.ToVec128()).ToUInt128();

        [MethodImpl(Inline)]
        public static ref UInt128 and(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
        {
            dst = and(lhs.ToVec128(), rhs.ToVec128()).ToUInt128();
            return ref dst;            
        }


    }

}