//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;

    using static Traits;

    using static corefunc;


    /// <summary>
    /// Singleton representative for positive infinity
    /// </summary>
    public readonly struct PositiveInfinity : Singleton<PositiveInfinity>, Infinity<PositiveInfinity>
    {
        /// <summary>
        /// Determines whether a supplied value represents positive infinity
        /// </summary>
        /// <param name="x">The subject to test</param>
        /// <returns></returns>
        public static bool test(double x)
            => x == double.PositiveInfinity;

        public static readonly PositiveInfinity Inhabitant = default;

        public PositiveInfinity inhabitant => Inhabitant;

        public bool positive => true;

        public bool negative => false;
    }



}