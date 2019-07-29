//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    
    partial class math
    {
        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by lower and upper bounds
        /// </summary>
        /// <param name="x">The test value</param>
        /// <param name="a">The lower bound</param>
        /// <param name="b">The uppper bound</param>
        [MethodImpl(Inline)]
        public static bool between(byte x, byte a, byte b)    
            => x >= a && x <= b;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by lower and upper bounds
        /// </summary>
        /// <param name="x">The test value</param>
        /// <param name="a">The lower bound</param>
        /// <param name="b">The uppper bound</param>
        [MethodImpl(Inline)]
        public static bool between(sbyte x, sbyte a, sbyte b)    
            => x >= a && x <= b;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by lower and upper bounds
        /// </summary>
        /// <param name="x">The test value</param>
        /// <param name="a">The lower bound</param>
        /// <param name="b">The uppper bound</param>
        [MethodImpl(Inline)]
        public static bool between(short x, short a, short b)    
            => x >= a && x <= b;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by lower and upper bounds
        /// </summary>
        /// <param name="x">The test value</param>
        /// <param name="a">The lower bound</param>
        /// <param name="b">The uppper bound</param>
        [MethodImpl(Inline)]
        public static bool between(ushort x, ushort a, ushort b)    
            => x >= a && x <= b;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by lower and upper bounds
        /// </summary>
        /// <param name="x">The test value</param>
        /// <param name="a">The lower bound</param>
        /// <param name="b">The uppper bound</param>
        [MethodImpl(Inline)]
        public static bool between(int x, int a, int b)    
            => x >= a && x <= b;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by lower and upper bounds
        /// </summary>
        /// <param name="x">The test value</param>
        /// <param name="a">The lower bound</param>
        /// <param name="b">The uppper bound</param>
        [MethodImpl(Inline)]
        public static bool between(uint x, uint a, uint b)    
            => x >= a && x <= b;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by lower and upper bounds
        /// </summary>
        /// <param name="x">The test value</param>
        /// <param name="a">The lower bound</param>
        /// <param name="b">The uppper bound</param>
        [MethodImpl(Inline)]
        public static bool between(long x, long a, long b)    
            => x >= a && x <= b;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by lower and upper bounds
        /// </summary>
        /// <param name="x">The test value</param>
        /// <param name="a">The lower bound</param>
        /// <param name="b">The uppper bound</param>
        [MethodImpl(Inline)]
        public static bool between(ulong x, ulong a, ulong b)    
            => x >= a && x <= b;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by lower and upper bounds
        /// </summary>
        /// <param name="x">The test value</param>
        /// <param name="a">The lower bound</param>
        /// <param name="b">The uppper bound</param>
        [MethodImpl(Inline)]
        public static bool between(float x, float a, float b)    
            => x >= a && x <= b;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by lower and upper bounds
        /// </summary>
        /// <param name="x">The test value</param>
        /// <param name="a">The lower bound</param>
        /// <param name="b">The uppper bound</param>
        [MethodImpl(Inline)]
        public static bool between(double x, double a, double b)    
            => x >= a && x <= b;
    }

}