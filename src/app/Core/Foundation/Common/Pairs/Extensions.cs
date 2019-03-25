//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using static corefunc;


   /// <summary>
    /// Defines pair-related extensions
    /// </summary>
    public static class PairX
    {

        public static bool IsLeft<A,B>(this Traits.Copair<A,B> cp)
            => cp.left.Exists;

        public static bool IsRight<A,B>(this Traits.Copair<A,B> cp)
            => cp.right.Exists;
    }


}