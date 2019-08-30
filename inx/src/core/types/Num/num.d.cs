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

    using static System.Runtime.Intrinsics.X86.Sse;    
    using static System.Runtime.Intrinsics.X86.Sse2;    
    
    using static zfunc;

    public partial class dinx
    {



        [MethodImpl(Inline)]
        public static bool ngt(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarNotGreaterThan(lhs, rhs).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool ngt(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarNotGreaterThan(lhs, rhs).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool nlt(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarNotLessThan(lhs, rhs).IsNaN(0);
        
        [MethodImpl(Inline)]
        public static bool nlt(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarNotLessThan(lhs, rhs).IsNaN(0);
        
        /// <summary>
        /// Determines whether the first component is NaN
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        static bool IsNaN(this Vector128<float> src, int index)
                => src.GetElement(index).IsNaN();

        /// <summary>
        /// Determines whether the first component is NaN
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        static bool IsNaN(this Vector128<double> src, int index)
            => src.GetElement(index).IsNaN();   
    }
}