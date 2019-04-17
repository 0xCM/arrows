//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;
    using Primal = PrimOps.Reify;

    /// <summary>
    /// Defines diagnostic versions of the primops api
    /// </summary>
    public static class primopsd
    {
        static T announce<T>(T x, Func<T,string> f)
        {
            inform(f(x));
            return x;
        }

        public static T zero<T>()        
            where T : struct, IEquatable<T>
                => announce(primops.zero<T>(), x => $"zero = {x}");

        public static T one<T>()        
            where T : struct, IEquatable<T>
                => announce(primops.one<T>(), x => $"one = {x}");

        public static T inc<T>(T src)        
            where T : struct, IEquatable<T>
                => announce(primops.inc(src), x => $"++{src} = {x}");

        public static T dec<T>(T src)        
            where T : struct, IEquatable<T>
                => announce(primops.dec(src), x => $"--{src} = {x}");

        public static bool lt<T>(T lhs, T rhs)        
            where T : struct, IEquatable<T>
                => announce(primops.lt(lhs,rhs), x => $"{lhs} < {rhs} = {x}");

        public static bool gt<T>(T lhs, T rhs)        
            where T : struct, IEquatable<T>
                => announce(primops.gt(lhs,rhs), x => $"{lhs} > {rhs} = {x}");

        public static bool eq<T>(T lhs, T rhs)        
            where T : struct, IEquatable<T>
                => announce(primops.eq(lhs,rhs), x => $"{lhs} == {rhs} = {x}");

        public static bool neq<T>(T lhs, T rhs)        
            where T : struct, IEquatable<T>
                => announce(primops.neq(lhs,rhs), x => $"{lhs} != {rhs} = {x}");

        public static T add<T>(T lhs, T rhs)        
            where T : struct, IEquatable<T>
                => announce(primops.add(lhs,rhs), x => $"{lhs} + {rhs} = {x}");

        public static T mul<T>(T lhs, T rhs)        
            where T : struct, IEquatable<T>
                => announce(primops.mul(lhs,rhs), x => $"{lhs} * {rhs} = {x}");

        public static T div<T>(T lhs, T rhs)        
            where T : struct, IEquatable<T>
                => announce(primops.div(lhs,rhs), x => $"{lhs} / {rhs} = {x}");

        public static T mod<T>(T lhs, T rhs)        
            where T : struct, IEquatable<T>
                => announce(primops.mod(lhs,rhs), x => $"{lhs} % {rhs} = {x}");

    }

}
