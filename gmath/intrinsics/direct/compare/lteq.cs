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
    

    /*
    
        public static bool CompareScalarOrderedGreaterThan(Vector128<double> left, Vector128<double> right);
        public static bool CompareScalarOrderedGreaterThanOrEqual(Vector128<double> left, Vector128<double> right);
        public static bool CompareScalarOrderedLessThan(Vector128<double> left, Vector128<double> right);
        public static bool CompareScalarOrderedLessThanOrEqual(Vector128<double> left, Vector128<double> right);
        public static bool CompareScalarOrderedNotEqual(Vector128<double> left, Vector128<double> right);
        public static Vector128<double> CompareScalarUnordered(Vector128<double> left, Vector128<double> right);
        public static bool CompareScalarUnorderedEqual(Vector128<double> left, Vector128<double> right);
        public static bool CompareScalarUnorderedGreaterThan(Vector128<double> left, Vector128<double> right);
        public static bool CompareScalarUnorderedGreaterThanOrEqual(Vector128<double> left, Vector128<double> right);
        public static bool CompareScalarUnorderedLessThan(Vector128<double> left, Vector128<double> right);
        public static bool CompareScalarUnorderedLessThanOrEqual(Vector128<double> left, Vector128<double> right);
        public static bool CompareScalarUnorderedNotEqual(Vector128<double> left, Vector128<double> right);    
     */

    using static mfunc;



    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<float> lteq(Num128<float> lhs, Vec128<float> rhs)
            => Avx2.CompareLessThanOrEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> lteq(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.CompareLessThanOrEqual(lhs, rhs);
    }


}