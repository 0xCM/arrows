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
    using static System.Runtime.Intrinsics.X86.FloatComparisonMode;
    
    
    using static zfunc;
    using static mfunc;

    
    partial class dinx
    {
        static bool IsNaN(double test)
            => double.IsNaN(test);

        [MethodImpl(Inline)]
        static bool[] TestNaN(Vector128<double> src)
            => array(
                IsNaN(src.GetElement(0)), 
                IsNaN(src.GetElement(1))
                );

        [MethodImpl(Inline)]
        static bool[] TestNaN(Vector128<float> src)
            => array(
                IsNaN(src.GetElement(0)), 
                IsNaN(src.GetElement(1)),
                IsNaN(src.GetElement(2)), 
                IsNaN(src.GetElement(3))
                );

        [MethodImpl(Inline)]
        static bool[] TestNaN(Vector256<float> src)
            => array(
                IsNaN(src.GetElement(0)), 
                IsNaN(src.GetElement(1)),
                IsNaN(src.GetElement(2)), 
                IsNaN(src.GetElement(3)),
                IsNaN(src.GetElement(4)), 
                IsNaN(src.GetElement(5)),
                IsNaN(src.GetElement(6)), 
                IsNaN(src.GetElement(7))
                );


        [MethodImpl(Inline)]
        public static bool[] cmpf(in Vec128<float> lhs,in Vec128<float> rhs, FloatCompareKind mode)
            => TestNaN(Avx2.Compare(lhs,rhs,(FloatComparisonMode)mode));

        [MethodImpl(Inline)]
        public static bool[] cmpf(in Vec128<double> lhs,in Vec128<double> rhs, FloatCompareKind mode)
            => TestNaN(Avx2.Compare(lhs,rhs,(FloatComparisonMode)mode));

        [MethodImpl(Inline)]
        public static Vec256<float> cmpf(in Vec256<float> lhs,in Vec256<float> rhs, FloatCompareKind mode)
            => clearNaN(Avx2.Compare(lhs,rhs,(FloatComparisonMode)mode));

        [MethodImpl(Inline)]
        public static Vec256<double> cmpf(in Vec256<double> lhs, in Vec256<double> rhs, FloatCompareKind mode)
            => clearNaN(Avx2.Compare(lhs,rhs,(FloatComparisonMode)mode));

    }


    public enum FloatCompareKind : byte
    {
        //
        // Summary:
        //     _CMP_EQ_OQ
        EqOrdNS = EqualOrderedNonSignaling,
        //
        // Summary:
        //     _CMP_LT_OS
        LtOrdS= LessThanOrderedSignaling,
        
        //
        // Summary:
        //     _CMP_LE_OS
        LtEqOrdS = LessThanOrEqualOrderedSignaling,
        
        //
        // Summary:
        //     _CMP_UNORD_Q
        UnOrdNS = UnorderedNonSignaling,
        
        //
        // Summary:
        //     _CMP_NEQ_UQ
        NEqUnOrdNS = NotEqualUnorderedNonSignaling,
        
        //
        // Summary:
        //     _CMP_NLT_US
        NLtUnOrdS = NotLessThanUnorderedSignaling,
        
        //
        // Summary:
        //     _CMP_NLE_US
        NLtEqUnOrdS = NotLessThanOrEqualUnorderedSignaling,
        
        //
        // Summary:
        //     _CMP_ORD_Q
        OrdNS = OrderedNonSignaling,
        
        //
        // Summary:
        //     _CMP_EQ_UQ
        EqUnOrdNS = EqualUnorderedNonSignaling,
        
        //
        // Summary:
        //     _CMP_NGE_US
        NGtEqUnOrdS = NotGreaterThanOrEqualUnorderedSignaling,
        
        //
        // Summary:
        //     _CMP_NGT_US
        NGtUnOrdS = NotGreaterThanUnorderedSignaling,
        
        //
        // Summary:
        //     _CMP_FALSE_OQ
        FalsOrdNS = FalseOrderedNonSignaling,
        //
        // Summary:
        //     _CMP_NEQ_OQ
        NEqOrdNS = NotEqualOrderedNonSignaling,
        
        //
        // Summary:
        //     _CMP_GE_OS
        GtEqOrdS = GreaterThanOrEqualOrderedSignaling,
        
        //
        // Summary:
        //     _CMP_GT_OS
        GtOrdS = FloatComparisonMode.GreaterThanOrderedSignaling,
        
        //
        // Summary:
        //     _CMP_TRUE_UQ
        TrueUnOrdNS = FloatComparisonMode.TrueUnorderedNonSignaling,
        
        //
        // Summary:
        //     _CMP_EQ_OS
        EqOrdS = EqualOrderedSignaling,
        
        //
        // Summary:
        //     _CMP_LT_OQ
        LtOrdNS = LessThanOrderedNonSignaling,
        
        //
        // Summary:
        //     _CMP_LE_OQ
        LtEqOrdNS = LessThanOrEqualOrderedNonSignaling,
        
        //
        // Summary:
        //     _CMP_UNORD_S
        UnOrdS = UnorderedSignaling,
        
        //
        // Summary:
        //     _CMP_NEQ_US
        NEqUnOrdS = NotEqualUnorderedSignaling,
        
        //
        // Summary:
        //     _CMP_NLT_UQ
        NLtUnOrdNS = NotLessThanUnorderedNonSignaling,
        
        //
        // Summary:
        //     _CMP_NLE_UQ
        NLtEqUnOrdNS = NotLessThanOrEqualUnorderedNonSignaling,
        
        //
        // Summary:
        //     _CMP_ORD_S
        OrdS = OrderedSignaling,
        
        //
        // Summary:
        //     _CMP_EQ_US
        EqUnOrdS= EqualUnorderedSignaling,
        
        //
        // Summary:
        //     _CMP_NGE_UQ
        NGtEqUnOrdNS = NotGreaterThanOrEqualUnorderedNonSignaling,
        
        //
        // Summary:
        //     _CMP_NGT_UQ
        NGtUnOrdNS = NotGreaterThanUnorderedNonSignaling,
        
        //
        // Summary:
        //     _CMP_FALSE_OS
        FalseOrdS = FalseOrderedSignaling,
        
        //
        // Summary:
        //     _CMP_NEQ_OS
        NEqOrdS = NotEqualOrderedSignaling,
        
        //
        // Summary:
        //     _CMP_GE_OQ
        GtEqOrdNS = GreaterThanOrEqualOrderedNonSignaling,
        
        //
        // Summary:
        //     _CMP_GT_OQ
        GtOrdNS = GreaterThanOrderedNonSignaling,
        
        //
        // Summary:
        //     _CMP_TRUE_US
        TrueUnOrdS = TrueUnorderedNonSignaling
 
    }

}