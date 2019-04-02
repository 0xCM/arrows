//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Traits;

    using static zcore;


    /// <summary>
    /// Singleton representative for negative infinity
    /// </summary>
    public readonly struct NegativeInfinity : Infinity<NegativeInfinity>
    {
        /// <summary>
        /// Determines whether a supplied value represents negative infinity
        /// </summary>
        /// <param name="x">The subject to test</param>
        /// <returns></returns>
        public static bool test(double x)
            => x == double.NegativeInfinity;

        public static readonly NegativeInfinity Inhabitant = default;

        public NegativeInfinity inhabitant 
            => Inhabitant;

        public bool positive 
            => false;

        public bool negative 
            => true;
    }
}