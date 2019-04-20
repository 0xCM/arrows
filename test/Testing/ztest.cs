//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using MathNet.Numerics;

    using static zcore;

    /// <summary>
    /// A reference calculator
    /// </summary>
    public static class RefCalc
    {

        [MethodImpl(Inline)]
        public static long pow(long @base, int exp)
        {
            var result = 1L;
            for(var i= 0; i<exp; i++)
                result = result * @base;
            return result;
        }

        [MethodImpl(Inline)]
        public static ulong pow(ulong @base, int exp)
        {
            var result = 1UL;
            for(var i= 0; i<exp; i++)
                result = result * @base;
            return result;
        }


        [MethodImpl(Inline)]
        public static ulong fact(ulong src)        
            => (ulong)SpecialFunctions.Factorial(src);

        

    }

    public static class ztest
    {


        static void dotell(object msg, string member)
            => babble($"{msg}", member);

        static string msg(object input, object expect, object actual)
            => $"input := {input}, expected := {expect}, actual = {actual}";

        public static void tell(object msg, [CallerMemberName] string member = null)
            => babble($"{msg}", member);
        
        public static void require(bool condition, object input, object expect, object actual, bool tell = false, [CallerMemberName] string member = null)
            => on(condition, 
                () => onTrue(tell, () => dotell(msg(input,expect,actual), member)), 
                () => throw new Exception($"input := {input}, expected := {expect}, actual = {actual}"));

    }

}