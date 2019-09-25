//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    
    using Avx = System.Runtime.Intrinsics.X86.Avx;   
    using static zfunc;
    using static As;
        
    partial class dinxx
    {
        public static bool TestC<T>(this Vector128<T> lhs, Vector128<T> rhs)
            where T : struct
                => ginx.testc(lhs, rhs);

        public static bool TestC<T>(this Vector256<T> lhs, Vector256<T> rhs)
            where T : struct
                => ginx.testc(lhs, rhs);

        public static bool TestZ<T>(this Vector128<T> lhs, Vector128<T> rhs)
            where T : struct
                => ginx.testz<T>(lhs, rhs);

        public static bool TestZ<T>(this Vector256<T> lhs, Vector256<T> rhs)
            where T : struct
                => ginx.testz<T>(lhs, rhs);

    }

}