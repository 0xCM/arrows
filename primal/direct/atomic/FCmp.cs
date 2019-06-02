//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Numerics;
    using System.Runtime.Intrinsics.X86;
    
    
    using static zfunc;

    partial class math
    {

        public static bool fcmp(double x, double y, FloatComparisonMode mode)
        {
            var result = mode switch{
                FloatComparisonMode.OrderedEqualNonSignaling => x == y,
                FloatComparisonMode.OrderedEqualSignaling => x == y,
                FloatComparisonMode.UnorderedEqualNonSignaling => x == y,
                FloatComparisonMode.UnorderedEqualSignaling => x == y,

                FloatComparisonMode.OrderedNotEqualNonSignaling => x != y,
                FloatComparisonMode.OrderedNotEqualSignaling => x != y,
                FloatComparisonMode.UnorderedNotEqualNonSignaling => x != y,
                FloatComparisonMode.UnorderedNotEqualSignaling => x != y,

                FloatComparisonMode.OrderedLessThanNonSignaling => x < y,
                FloatComparisonMode.OrderedLessThanSignaling => x < y,

                FloatComparisonMode.OrderedGreaterThanNonSignaling=>  x > y,
                FloatComparisonMode.OrderedGreaterThanSignaling =>  x > y,

                FloatComparisonMode.OrderedLessThanOrEqualNonSignaling =>  x <= y,
                FloatComparisonMode.OrderedLessThanOrEqualSignaling =>  x <= y,
                
                FloatComparisonMode.OrderedGreaterThanOrEqualNonSignaling => x >= y,
                FloatComparisonMode.OrderedGreaterThanOrEqualSignaling => x >= y,

                FloatComparisonMode.UnorderedNotGreaterThanOrEqualNonSignaling => !(x >= y),                    
                FloatComparisonMode.UnorderedNotGreaterThanOrEqualSignaling => !(x >= y),                    
                
                FloatComparisonMode.UnorderedNotGreaterThanNonSignaling => !(x > y),                    
                FloatComparisonMode.UnorderedNotGreaterThanSignaling => !(x > y),

                FloatComparisonMode.UnorderedNotLessThanOrEqualNonSignaling => !(x <= y),
                FloatComparisonMode.UnorderedNotLessThanOrEqualSignaling => !(x <= y),
                
                FloatComparisonMode.UnorderedNotLessThanNonSignaling => !(x < y),
                FloatComparisonMode.UnorderedNotLessThanSignaling => !(x < y),

                _ => throw new NotSupportedException()
            };
                            
            return result; 
        }

        public static bool[] fcmp(Span<double> lhs, Span<double> rhs, FloatComparisonMode kind)
        {
            var len = length(lhs,rhs);
            var result = alloc<bool>(len);
            for(var i = 0; i< len; i++)
                result[i] = fcmp(lhs[i], rhs[i], kind);
            return result;
        }

    }

}