//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
// Derived from: Cephes Math Library Release 2.8:  June, 2000
// Copyright 1984, 1995, 2000 by Stephen L. Moshier
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    public static partial class cephes
    {

        const double MAXNUM =  1.79769313486231570815E308;    /* 2**1024*(1-MACHEP) */
        
        const double PI     =  3.14159265358979323846;       /* pi */
        
        const double PIO2   =  1.57079632679489661923;       /* pi/2 */
        
        const double PIO4   =  7.85398163397448309616E-1;    /* pi/4 */
        
        const double SQRT2  =  1.41421356237309504880;       /* sqrt(2) */
        
        const double SQRTH  =  7.07106781186547524401E-1;    /* sqrt(2)/2 */
        
        const double LOG2E  =  1.4426950408889634073599;     /* 1/log(2) */
        
        const double SQ2OPI =  7.9788456080286535587989E-1;  /* sqrt( 2/pi ) */
        
        const double LOGE2  =  6.93147180559945309417E-1;    /* log(2) */
        
        const double LOGSQ2 =  3.46573590279972654709E-1;    /* log(2)/2 */
        
        const double THPIO4 =  2.35619449019234492885;       /* 3*pi/4 */
        
        const double TWOOPI =  6.36619772367581343075535E-1; /* 2/pi */

        const double INFINITY = double.PositiveInfinity;

        const double NAN = double.NaN;

        const double MAXLOG =  7.09782712893383996732E2;     /* log(MAXNUM) */

        const double MINLOG = -7.451332191019412076235E2;     /* log(2**-1075) */


        [MethodImpl(Inline)]
        public static bool isfinite(double x)
            => double.IsFinite(x);

        [MethodImpl(Inline)]
        public static bool isinfinite(double x)
            => !double.IsFinite(x);

        [MethodImpl(Inline)]
        public static bool isnan(double x)
            => double.IsNaN(x);

    }
}