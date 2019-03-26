//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static zcore;


   /// <summary>
    /// Defines pair-related extensions
    /// </summary>
    partial class xcore
    {

        public static bool IsLeft<A,B>(this Traits.Copair<A,B> cp)
            => cp.left.Exists;

        public static bool IsRight<A,B>(this Traits.Copair<A,B> cp)
            => cp.right.Exists;
    }


}