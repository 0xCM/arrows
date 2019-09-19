//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;    

    partial class dfp
    {

        /// <summary>
        /// Negates each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> negate(in Vec128<float> src)
            =>  fsub(Vec128<float>.Zero, src);

        /// <summary>
        /// Negates each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> negate(in Vec128<double> src)
            =>  fsub(Vec128<double>.Zero, src);

        /// <summary>
        /// Negates each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> negate(in Vec256<float> src)
            =>  fsub(Vec256<float>.Zero, src);

        /// <summary>
        /// Negates each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> negate(in Vec256<double> src)
            =>  fsub(Vec256<double>.Zero, src);

    }

}