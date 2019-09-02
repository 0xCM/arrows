//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using Avx = System.Runtime.Intrinsics.X86.Avx;   
    using static zfunc;
    using static As;
        
    partial class dinxx
    {
        public static bool TestZ<T>(this Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
                => ginx.testz(in lhs, in rhs);

        public static bool TestZ<T>(this Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
                => ginx.testz(in lhs, in rhs);

        public static bool TestC<T>(this Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
                => ginx.testc(in lhs, in rhs);

        public static bool TestC<T>(this Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
                => ginx.testc(in lhs, in rhs);


    }

}