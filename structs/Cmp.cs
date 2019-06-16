//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public static class Cmp
    {
        public static Cmp<T> Result<T>(bool succeeded)
            where T : struct
             => succeeded ? Cmp<T>.True : Cmp<T>.False;
    }

    /// <summary>
    /// Captures the results of a comparison operation
    /// </summary>
    public readonly struct Cmp<T>
        where T : struct
    {
        internal static readonly Cmp<T> True = new Cmp<T>(true);   

        internal static readonly Cmp<T> False = new Cmp<T>(false);   

        public Cmp(bool Result)
            => this.Result = Result;

        public readonly Bit Result;
    }

}