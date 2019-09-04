//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    
    
    using static zfunc;


    public static class Rules
    {
        /// <summary>
        /// Defines a literal expression
        /// </summary>
        /// <param name="value">The literal value</param>
        /// <typeparam name="T">The literal type</typeparam>
        public static LiteralExpr<T> Literal<T>(T value)
            => new LiteralExpr<T>(value);
        
        /// <summary>
        /// Defines a variable expression
        /// </summary>
        /// <param name="name">The variable name</param>
        /// <param name="value">The initial value, if any</param>
        /// <typeparam name="T">The variable type</typeparam>
        public static VarExpr<T> Var<T>(string name, T? value = null)
            where T : struct
                => new VarExpr<T>(name, value);
        
        public static MembershipExpr<T> IsMember<T>(HashSet<T> matches)
            => new MembershipExpr<T>(MembershipTest.IsMember, matches);

        public static MembershipExpr<T> IsNotMember<T>(HashSet<T> matches)
            => new MembershipExpr<T>(MembershipTest.IsNotMember, matches);

        public static DateCmpExpr DateBefore(Date max)
            => new DateCmpExpr(TimeMarker.Before, Var<Date>(nameof(max),max));

        public static DateCmpExpr DateMatches(Date match)
            => new DateCmpExpr(TimeMarker.Matches,Var<Date>(nameof(match),match));

        public static DateCmpExpr DateAfter(Date min)
            => new DateCmpExpr(TimeMarker.After, Var<Date>(nameof(min),min));

        public static DateCmpExpr DateBetween(Date min, Date max)
            => new DateCmpExpr(TimeMarker.Between, Var<Date>(nameof(min),min), Var<Date>(nameof(max),max));

    }

}