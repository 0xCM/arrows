//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;

    partial class Operative
    {    

        public interface Absolutive<T> 
        {
            T abs(T x);
        }
    }

    partial class Structures
    {
        public interface Absolitive<S> : Structure<S>
            where S : Absolitive<S>,new()
        {
            S abs();
        }
    }
}