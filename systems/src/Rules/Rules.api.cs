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
        public static LiteralExpr<T> Literal<T>(T value)
            => new LiteralExpr<T>(value);
        
        public static VarExpr<T> Var<T>(string name, T? value = null)
            where T : struct
                => new VarExpr<T>(name, value);


        public static DateOrientation DateBefore(Date max)
            => new DateOrientation(TimeMarker.Before, Var<Date>(nameof(max),max));

        public static DateOrientation DateMatches(Date match)
            => new DateOrientation(TimeMarker.Matches,Var<Date>(nameof(match),match));

        public static DateOrientation DateAfter(Date min)
            => new DateOrientation(TimeMarker.After, Var<Date>(nameof(min),min));

        public static DateOrientation DateBetween(Date min, Date max)
            => new DateOrientation(TimeMarker.Between, Var<Date>(nameof(min),min), Var<Date>(nameof(max),max));

    }

}