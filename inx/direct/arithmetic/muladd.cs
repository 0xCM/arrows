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
    using static System.Runtime.Intrinsics.X86.Fma;        
    using static zfunc;

    partial class dinx    
    {
        // dst = x*y + z
        [MethodImpl(Inline)]
        public static ref Vec128<float> mulAdd(ref Vec128<float> x, in Vec128<float> y, in Vec128<float> z)
        {
            x = MultiplyAdd(x,y,z);
            return ref x;
        }
                    
        // dst = x*y + z
        [MethodImpl(Inline)]
        public static ref Vec128<double> mulAdd(ref Vec128<double> x, in Vec128<double> y, in Vec128<double> z)
        {
            x = MultiplyAdd(x,y,z);
            return ref x;
        }

        [MethodImpl(Inline)]
        public static Vec128<float> mulAddNegated(in Vec128<float> x, in Vec128<float> y, in Vec128<float> z)
            => MultiplyAddNegated(x,y,z);

        [MethodImpl(Inline)]
        public static Vec128<double> mulAddNegated(in Vec128<double> x, in Vec128<double> y, in Vec128<double> z)
            => MultiplyAddNegated(x,y,z);

        [MethodImpl(Inline)]
        public static Vec128<float> mulAddSub(in Vec128<float> x, in Vec128<float> y, in Vec128<float> z)
            => MultiplyAddSubtract(x,y,z);

        [MethodImpl(Inline)]
        public static Vec128<double> mulAddSub(in Vec128<double> x, in Vec128<double> y, in Vec128<double> z)
            => MultiplyAddSubtract(x,y,z);

         // dst = x*y + z
        [MethodImpl(Inline)]
        public static Num128<float> mulAdd(in Num128<float> x, in Num128<float> y, in Num128<float> z)
            => MultiplyAddScalar(x,y,z);
                    
        // dst = x*y + z
        [MethodImpl(Inline)]
        public static Num128<double> mulAdd(in Num128<double> x, in Num128<double> y, in Num128<double> z)
            => MultiplyAddScalar(x,y,z);

        [MethodImpl(Inline)]
        public static Vec256<float> mulAdd(in Vec256<float> x, in Vec256<float> y, in Vec256<float> z)
            => MultiplyAdd(x,y,z);

        [MethodImpl(Inline)]
        public static Vec256<double> mulAdd(in Vec256<double> x, in Vec256<double> y, in Vec256<double> z)
            => MultiplyAdd(x,y,z);

        [MethodImpl(Inline)]
        public static Vec256<float> mulAddNegated(in Vec256<float> x, in Vec256<float> y, in Vec256<float> z)
            => MultiplyAddNegated(x,y,z);

        [MethodImpl(Inline)]
        public static Vec256<double> mulAddNegated(in Vec256<double> x, in Vec256<double> y, in Vec256<double> z)
            => MultiplyAddNegated(x,y,z);

        [MethodImpl(Inline)]
        public static Vec256<float> mulAddSub(in Vec256<float> x, in Vec256<float> y, in Vec256<float> z)
            => MultiplyAddSubtract(x,y,z);

        [MethodImpl(Inline)]
        public static Vec256<double> mulAddSub(in Vec256<double> x, in Vec256<double> y, in Vec256<double> z)
            => MultiplyAddSubtract(x,y,z);
    }
}