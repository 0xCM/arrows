//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;

    using Root;
    using static Class;

    using static corefunc;

    public static class Infinity
    {
        /// <summary>
        /// Determines whether a supplied value represents negative infinity
        /// </summary>
        /// <param name="x">The subject to test</param>
        /// <returns></returns>
        public static bool neginf(double x)
            => x == double.NegativeInfinity;

        /// <summary>
        /// Determines whether a supplied value represents positive infinity
        /// </summary>
        /// <param name="x">The subject to test</param>
        /// <returns></returns>
        public static bool posinf(double x)
            => x == double.PositiveInfinity;


        /// <summary>
        /// Determines whether a supplied value represents an infinite value
        /// </summary>
        /// <param name="x">The subject to test</param>
        /// <returns></returns>
        public static bool infinity(double x)
            => neginf(x) || posinf(x);

    }



    /// <summary>
    /// Singleton representative for negative infinity
    /// </summary>
    public readonly struct NegativeInfinity : Singleton<NegativeInfinity>, Infinity<NegativeInfinity>
    {
        public static readonly NegativeInfinity Inhabitant = default;

        public NegativeInfinity inhabitant => Inhabitant;

        public bool positive => false;

        public bool negative => true;
    }

    /// <summary>
    /// Singleton representative for positive infinity
    /// </summary>
    public readonly struct PositiveInfinity : Singleton<PositiveInfinity>, Infinity<PositiveInfinity>
    {
        public static readonly PositiveInfinity Inhabitant = default;

        public PositiveInfinity inhabitant => Inhabitant;

        public bool positive => true;

        public bool negative => false;
    }




}