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
    using static BetweenMode;

    public enum BetweenMode
    {
        /// <summary>
        /// Describes an interval of the form [a,b]; equivalent to RightInclusive
        /// </summary>
        Inclusive,

        /// <summary>
        /// Describes an interval of the form (a,b); equivalent to RightInclusive
        /// </summary>
        Exclusive,

        /// <summary>
        /// Describes an interval of the form [a,b); equivalent to RightInclusive
        /// </summary>
        LeftInclusive,
        
        /// <summary>
        /// Describes an interval of the form [a,b); equivalent to LeftInclusive
        /// </summary>
        RightExclusive,

        /// <summary>
        /// Describes an interval of the form (a,b]; equivalent to LeftInclusive
        /// </summary>
        RightInclusive,

        /// <summary>
        /// Describes an interval of the form (a,b]; equivalent to RightInclusive
        /// </summary>
        LeftExclusive,

    }
    
    partial class math
    {
        [MethodImpl(Inline)]
        public static bool between(byte x, byte a, byte b, BetweenMode mode = Inclusive)    
        {
            if(mode == Inclusive)
                return x >= a && x <= b;
            else if(mode == Exclusive)
                return x > a && x < b;
            else if(mode == LeftInclusive || mode == RightExclusive)
                return x >= a && x < b;
            else // mode == LeftExclusive || mode == RightInclusive
                return x > a && x <= b;
            
        }

        [MethodImpl(Inline)]
        public static bool between(sbyte x, sbyte a, sbyte b, BetweenMode mode = Inclusive)    
        {
            if(mode == Inclusive)
                return x >= a && x <= b;
            else if(mode == Exclusive)
                return x > a && x < b;
            else if(mode == LeftInclusive || mode == RightExclusive)
                return x >= a && x < b;
            else // mode == LeftExclusive || mode == RightInclusive
                return x > a && x <= b;
            
        }

        [MethodImpl(Inline)]
        public static bool between(short x, short a, short b, BetweenMode mode = Inclusive)    
        {
            if(mode == Inclusive)
                return x >= a && x <= b;
            else if(mode == Exclusive)
                return x > a && x < b;
            else if(mode == LeftInclusive || mode == RightExclusive)
                return x >= a && x < b;
            else // mode == LeftExclusive || mode == RightInclusive
                return x > a && x <= b;
            
        }

        [MethodImpl(Inline)]
        public static bool between(ushort x, ushort a, ushort b, BetweenMode mode = Inclusive)    
        {
            if(mode == Inclusive)
                return x >= a && x <= b;
            else if(mode == Exclusive)
                return x > a && x < b;
            else if(mode == LeftInclusive || mode == RightExclusive)
                return x >= a && x < b;
            else // mode == LeftExclusive || mode == RightInclusive
                return x > a && x <= b;
            
        }

        [MethodImpl(Inline)]
        public static bool between(int x, int a, int b, BetweenMode mode = Inclusive)    
        {
            if(mode == Inclusive)
                return x >= a && x <= b;
            else if(mode == Exclusive)
                return x > a && x < b;
            else if(mode == LeftInclusive || mode == RightExclusive)
                return x >= a && x < b;
            else // mode == LeftExclusive || mode == RightInclusive
                return x > a && x <= b;
            
        }

        [MethodImpl(Inline)]
        public static bool between(uint x, uint a, uint b, BetweenMode mode = Inclusive)    
        {
            if(mode == Inclusive)
                return x >= a && x <= b;
            else if(mode == Exclusive)
                return x > a && x < b;
            else if(mode == LeftInclusive || mode == RightExclusive)
                return x >= a && x < b;
            else // mode == LeftExclusive || mode == RightInclusive
                return x > a && x <= b;
            
        }

        [MethodImpl(Inline)]
        public static bool between(long x, long a, long b, BetweenMode mode = Inclusive)    
        {
            if(mode == Inclusive)
                return x >= a && x <= b;
            else if(mode == Exclusive)
                return x > a && x < b;
            else if(mode == LeftInclusive || mode == RightExclusive)
                return x >= a && x < b;
            else // mode == LeftExclusive || mode == RightInclusive
                return x > a && x <= b;
            
        }

        [MethodImpl(Inline)]
        public static bool between(ulong x, ulong a, ulong b, BetweenMode mode = Inclusive)    
        {
            if(mode == Inclusive)
                return x >= a && x <= b;
            else if(mode == Exclusive)
                return x > a && x < b;
            else if(mode == LeftInclusive || mode == RightExclusive)
                return x >= a && x < b;
            else // mode == LeftExclusive || mode == RightInclusive
                return x > a && x <= b;
            
        }

        [MethodImpl(Inline)]
        public static bool between(float x, float a, float b, BetweenMode mode = Inclusive)    
        {
            if(mode == Inclusive)
                return x >= a && x <= b;
            else if(mode == Exclusive)
                return x > a && x < b;
            else if(mode == LeftInclusive || mode == RightExclusive)
                return x >= a && x < b;
            else // mode == LeftExclusive || mode == RightInclusive
                return x > a && x <= b;
            
        }

        [MethodImpl(Inline)]
        public static bool between(double x, double a, double b, BetweenMode mode = Inclusive)    
        {
            if(mode == Inclusive)
                return x >= a && x <= b;
            else if(mode == Exclusive)
                return x > a && x < b;
            else if(mode == LeftInclusive || mode == RightExclusive)
                return x >= a && x < b;
            else // mode == LeftExclusive || mode == RightInclusive
                return x > a && x <= b;
            
        }

    }

}