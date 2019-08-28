//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics.X86;

    [Flags]
    public enum FpErrorMode
    {
        /// <summary>
        /// Raise exceptions upon error
        /// </summary>
        Raise = 0,

        /// <summary>
        /// Suppress exceptions upon error
        /// </summary>
        Suppress = 8

    }
    
    [Flags]
    public enum FpRoundDir : byte
    {
        /// <summary>
        /// _MM_FROUND_TO_NEAREST_INT, the default mode effects rounding to the nearest integer
        /// </summary>
        Default = 0,

        /// <summary>
        /// _MM_FROUND_TO_NEG_INF, Round toward negative infinity
        /// </summary>
        NegInf = 1,

        /// <summary>
        /// _MM_FROUND_TO_POS_INF, Round toward positive infinity
        /// </summary>
        PosInf = 2,

        /// <summary>
        /// _MM_FROUND_TO_ZERO, round toward 0
        /// </summary>
        Zero = 3,

        /// <summary>
        /// _MM_FROUND_CUR_DIRECTION, round toward the current direction as specified by __MM_SET_ROUNDING_MODE
        /// </summary>
        Current = 4,

        /// <summary>
        /// _MM_FROUND_CEIL, round toward positive infinity and do not suppress exceptions
        /// </summary>
        Ceil = PosInf | FpErrorMode.Raise,

        /// <summary>
        /// _MM_FROUND_FLOOR, round toward negative infinity and do not suppress exceptions
        /// </summary>
        Floor = NegInf | FpErrorMode.Raise,
        
        /// <summary>
        /// _MM_FROUND_TRUNC, Round toward zero and do not supress exceptions
        /// </summary>
        Trunc = Zero | FpErrorMode.Raise,

        /// <summary>
        /// _MM_FROUND_NEARBYINT, round toward the current direction and suppress exceptions
        /// </summary>
        Nearby = Current | FpErrorMode.Suppress

    }

    /// <summary>
    /// Classifier for floating-point comparisons
    /// </summary>
    public enum FpCmpMode
    {
        /// <summary>
        /// equal, ordered, non-signaling
        /// </summary>
        EQ_OQ = FloatComparisonMode.OrderedEqualNonSignaling,
        
        /// <summary>
        /// equal, ordered, signaling
        /// </summary>
        EQ_OS = FloatComparisonMode.OrderedEqualSignaling,


        /// <summary>
        /// equal, unordered, signaling
        /// </summary>
        EQ_UQ = FloatComparisonMode.UnorderedEqualNonSignaling,

        /// <summary>
        /// greater than, ordered, non-signaling
        /// </summary>
        GT_OQ = FloatComparisonMode.OrderedGreaterThanNonSignaling

    }    

    /*
    
 OrderedEqualNonSignaling = 0,
        OrderedLessThanSignaling = 1,
        OrderedLessThanOrEqualSignaling = 2,
        //
        // Summary:
        //     _CMP_UNORD_Q
        UnorderedNonSignaling = 3,
        UnorderedNotEqualNonSignaling = 4,
        UnorderedNotLessThanSignaling = 5,
        UnorderedNotLessThanOrEqualSignaling = 6,
        //
        // Summary:
        //     _CMP_ORD_Q
        OrderedNonSignaling = 7,
        UnorderedEqualNonSignaling = 8,
        UnorderedNotGreaterThanOrEqualSignaling = 9,
        UnorderedNotGreaterThanSignaling = 10,
        OrderedFalseNonSignaling = 11,
        OrderedNotEqualNonSignaling = 12,
        OrderedGreaterThanOrEqualSignaling = 13,
        OrderedGreaterThanSignaling = 14,
        UnorderedTrueNonSignaling = 15,
        OrderedEqualSignaling = 16,
        OrderedLessThanNonSignaling = 17,
        OrderedLessThanOrEqualNonSignaling = 18,
        //
        // Summary:
        //     _CMP_UNORD_S
        UnorderedSignaling = 19,
        UnorderedNotEqualSignaling = 20,
        UnorderedNotLessThanNonSignaling = 21,
        UnorderedNotLessThanOrEqualNonSignaling = 22,
        //
        // Summary:
        //     _CMP_ORD_S
        OrderedSignaling = 23,
        UnorderedEqualSignaling = 24,
        UnorderedNotGreaterThanOrEqualNonSignaling = 25,
        UnorderedNotGreaterThanNonSignaling = 26,
        OrderedFalseSignaling = 27,
        OrderedNotEqualSignaling = 28,
        OrderedGreaterThanOrEqualNonSignaling = 29,
        OrderedGreaterThanNonSignaling = 30,
        UnorderedTrueSignaling = 31    
    
     */
}