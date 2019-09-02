//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    partial class fmath
    {

        public static bool fcmp(float x, float y, FpCmpMode mode)
        {
            var result = mode switch
            {
                FpCmpMode.EQ_OQ => x == y,
                FpCmpMode.EQ_OS => x == y,
                FpCmpMode.EQ_UQ => x == y,
                FpCmpMode.EQ_US => x == y,

                FpCmpMode.NEQ_OQ => x != y,
                FpCmpMode.NEQ_OS => x != y,
                FpCmpMode.NEQ_UQ => x != y,
                FpCmpMode.NEQ_US => x != y,

                FpCmpMode.LT_OQ => x < y,
                FpCmpMode.LT_OS => x < y,

                FpCmpMode.GT_OQ =>  x > y,
                FpCmpMode.GT_OS =>  x > y,

                FpCmpMode.LE_OQ =>  x <= y,
                FpCmpMode.LE_OS =>  x <= y,
                
                FpCmpMode.GE_OQ => x >= y,
                FpCmpMode.GE_OS => x >= y,

                FpCmpMode.NGE_UQ => !(x >= y),                    
                FpCmpMode.NGE_US => !(x >= y),                    
                
                FpCmpMode.NGT_UQ => !(x > y),                    
                FpCmpMode.NGT_US => !(x > y),

                FpCmpMode.NLE_UQ => !(x <= y),
                FpCmpMode.NLE_US => !(x <= y),
                
                FpCmpMode.NLT_UQ => !(x < y),
                FpCmpMode.NLT_US => !(x < y),

                _ => throw new NotSupportedException()
            };
                            
            return result; 
        }

        public static bool fcmp(double x, double y, FpCmpMode mode)
        {
            var result = mode switch
            {
                FpCmpMode.EQ_OQ => x == y,
                FpCmpMode.EQ_OS => x == y,
                FpCmpMode.EQ_UQ => x == y,
                FpCmpMode.EQ_US => x == y,

                FpCmpMode.NEQ_OQ => x != y,
                FpCmpMode.NEQ_OS => x != y,
                FpCmpMode.NEQ_UQ => x != y,
                FpCmpMode.NEQ_US => x != y,

                FpCmpMode.LT_OQ => x < y,
                FpCmpMode.LT_OS => x < y,

                FpCmpMode.GT_OQ =>  x > y,
                FpCmpMode.GT_OS =>  x > y,

                FpCmpMode.LE_OQ =>  x <= y,
                FpCmpMode.LE_OS =>  x <= y,
                
                FpCmpMode.GE_OQ => x >= y,
                FpCmpMode.GE_OS => x >= y,

                FpCmpMode.NGE_UQ => !(x >= y),                    
                FpCmpMode.NGE_US => !(x >= y),                    
                
                FpCmpMode.NGT_UQ => !(x > y),                    
                FpCmpMode.NGT_US => !(x > y),

                FpCmpMode.NLE_UQ => !(x <= y),
                FpCmpMode.NLE_US => !(x <= y),
                
                FpCmpMode.NLT_UQ => !(x < y),
                FpCmpMode.NLT_US => !(x < y),

                _ => throw new NotSupportedException()
            };
                            
            return result; 
        }


        public static bool[] fcmp(Span<float> lhs, Span<float> rhs, FpCmpMode kind)
        {
            var len = length(lhs,rhs);
            var result = alloc<bool>(len);
            for(var i = 0; i< len; i++)
                result[i] = fcmp(lhs[i], rhs[i], kind);
            return result;
        }

        public static bool[] fcmp(Span<double> lhs, Span<double> rhs, FpCmpMode kind)
        {
            var len = length(lhs,rhs);
            var result = alloc<bool>(len);
            for(var i = 0; i< len; i++)
                result[i] = fcmp(lhs[i], rhs[i], kind);
            return result;
        }

    }

}