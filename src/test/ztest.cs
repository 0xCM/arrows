//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Runtime.CompilerServices;

    using static zcore;
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