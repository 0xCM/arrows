//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zfunc;

    /// <summary>
    /// These scenarios were derived from the implementation of System.Math
    /// </summary>
    class SysMathCases : Deconstructable<SysMathCases>
    {
        public SysMathCases()
            : base(callerfile())
        {

        }

        [MethodImpl(Inline | Optimize)]
        public static sbyte Abs(sbyte value)
        {
            if (value < 0)
                value = (sbyte)-value;
            return value;
        }


        [MethodImpl(Inline | Optimize)]
        public static short Abs16(short value)
        {
            if (value < 0)
                value = (short)-value;
            return value;
        }

        [MethodImpl(Inline | Optimize)]
        public static int Abs32(int value)
        {
            if (value < 0)
                value = -value;
            return value;
        }

        [MethodImpl(Inline | Optimize)]
        public static long Abs64(long value)
        {
            if (value < 0)
                value = -value;
            return value;
        }

        [MethodImpl(Inline | Optimize)]
        public static byte Max(byte val1, byte val2)
            => (val1 >= val2) ? val1 : val2;

        [MethodImpl(Inline | Optimize)]
        public static short Max(short val1, short val2)
            => (val1 >= val2) ? val1 : val2;

        [MethodImpl(Inline | Optimize)]
        public static int Max(int val1, int val2)
            => (val1 >= val2) ? val1 : val2;

        [MethodImpl(Inline | Optimize)]
        public static long Max(long val1, long val2)
            => (val1 >= val2) ? val1 : val2;

        [MethodImpl(Inline | Optimize)]
        public static sbyte Max(sbyte val1, sbyte val2)
            => (val1 >= val2) ? val1 : val2;
        


    }

}