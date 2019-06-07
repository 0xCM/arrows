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
    
    using static zfunc;
    
    public readonly struct Epsilon<T>
        where T : struct
    {
        public static implicit operator T(Epsilon<T> src)
            => src.Tolerance;
        public Epsilon(T tol)
        {
            this.Tolerance = tol;
            this.Range = closed(gmath.negate(tol), tol);            
        }
        
        public readonly T Tolerance;

        public readonly Interval<T> Range;
    }

    public static class Epsilon
    {
        public static Epsilon<T> define<T>(T tolerance)            
            where T : struct
                => new Epsilon<T>(tolerance);

        [MethodImpl(Inline)]
        public static bool Eq<T>(this Epsilon<T> e, T lhs, T rhs)
            where T : struct
                => e.Range.Contains(gmath.sub(lhs,rhs));
        
    }
}